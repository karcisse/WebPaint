using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading;

namespace PT_LAB_6
{
    public struct Data
    {
        public int x1, y1;
        public int x2, y2;
        public int port;
        public int color;
        public Data(int x11, int y11, int x22, int y22, int port1, int c)
        {
            this.x1 = x11;
            this.y1 = y11;
            this.x2 = x22;
            this.y2 = y22;
            this.port = port1;
            this.color = c;
        }
    }
    public partial class Form1 : Form
    {
        Bitmap drawArea;
        public Form1()
        {
            InitializeComponent();

            drawArea = new Bitmap(board.Size.Width, board.Size.Height);
            board.Image = drawArea;
            mypen = new Pen(Brushes.Black);
            mypen.Width = 4.0F;
            
        }
        int mouseX=0;
        int mouseY=0;
        bool draw = false;
        Pen mypen;
        UdpClient udpClient;
        IPEndPoint ipep;
        volatile IPEndPoint senders;
        volatile Byte[] data;
        Thread recieverThread;
        int _color = 0;

        public int getPenColor()
        {
            if (mypen.Color==Color.Black)
            {
                return 0;
            }
            if (mypen.Color==Color.Red)
            {
                return 1;
            }
            if (mypen.Color==Color.Blue)
            {
                return 2;
            }
            if (mypen.Color==Color.Yellow)
            {
                return 3;
            }
            return 0;
        }
        public void setPenColor(int color)
        {
            if (color == 0)
            {
                mypen.Color = Color.Black;
                this._color = color;
            }
            if (color == 1)
            {
                mypen.Color = Color.Red;
                this._color = color;
            }
            if (color == 2)
            {
                mypen.Color = Color.Blue;
                this._color = color;
            }
            if (color == 3)
            {
                mypen.Color = Color.Yellow;
                this._color = color;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ColorBtn_Click(object sender, EventArgs e)
        {
            colorForm form = new colorForm(this);
            form.Show();
        }
        private void recieve()
        {
            while (true)
            {
                senders = new IPEndPoint(IPAddress.Any, 0);

                //Byte[] data = newsock.Receive(ref senders);
                data = udpClient.Receive(ref senders);
                Data tmp = fromBytes(data);

                Graphics g;
                g = Graphics.FromImage(drawArea);

                // g.DrawLine(mypen, mouseX, mouseY, e.X, e.Y);
                int tmpColor = _color;
                setPenColor(tmp.color);
                g.DrawLine(mypen, tmp.x1, tmp.y1, tmp.x2, tmp.y2);
                board.Image = drawArea;
                setPenColor(tmpColor);
                g.Dispose();
            }
        }
        private void board_MouseDown(object sender, MouseEventArgs e)
        {
            draw = true;
        }

        private void board_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                Graphics g;
                g = Graphics.FromImage(drawArea);

                // g.DrawLine(mypen, mouseX, mouseY, e.X, e.Y);

                if (mouseY == 0 && mouseX == 0)
                {
                    g.DrawLine(mypen, e.X, e.Y, e.X, e.Y);
                    sendPoint(e.X, e.Y, e.X, e.Y, mypen);

                }
                else
                {
                    g.DrawLine(mypen, mouseX, mouseY, e.X, e.Y);
                    sendPoint(mouseX, mouseY, e.X, e.Y, mypen);
                }

                board.Image = drawArea;
                g.Dispose();
            }
            mouseX = e.X;
            mouseY = e.Y;
        }

        private void board_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
        }

        private void sendPoint(int x1,int y1, int x2, int y2, Pen pen)
        {
            Data tmp = new Data(x1, y1, x2, y2,((IPEndPoint)udpClient.Client.LocalEndPoint).Port,_color);
            Byte[] sendBytes = getBytes(tmp);
            udpClient.Send(sendBytes, sendBytes.Length);
        }

        private byte[] getBytes(Data str) {
            int size = Marshal.SizeOf(str);
            byte[] arr = new byte[size];

            IntPtr ptr = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(str, ptr, true);
            Marshal.Copy(ptr, arr, 0, size);
            Marshal.FreeHGlobal(ptr);
            return arr;
        }

        private Data fromBytes(byte[] arr)
        {
            Data str = new Data();

            int size = Marshal.SizeOf(str);
            IntPtr ptr = Marshal.AllocHGlobal(size);

            Marshal.Copy(arr, 0, ptr, size);

            str = (Data)Marshal.PtrToStructure(ptr, str.GetType());
            Marshal.FreeHGlobal(ptr);

            return str;
        }

        private void ConBtn_Click(object sender, EventArgs e)
        {
            ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 0);
            udpClient = new UdpClient(ipep);

            recieverThread = new Thread(new ThreadStart(this.recieve));
            recieverThread.Start();

            udpClient.Connect(IPAddress.Parse(serverIP.Text), int.Parse(serverPort.Text));
            Data tmp = new Data(-1, -1, -1, -1, ((IPEndPoint)udpClient.Client.LocalEndPoint).Port,_color);
            Byte[] sendBytes = getBytes(tmp);
            udpClient.Send(sendBytes, sendBytes.Length);
        }

        private void DisConBtn_Click(object sender, EventArgs e)
        {
            //Byte[] disconnect = new Byte[] { 1 };
            //udpClient.Send(disconnect, disconnect.Length);
            Data tmp = new Data(-1, -1, -1, -1, ((IPEndPoint)udpClient.Client.LocalEndPoint).Port, -1);
            Byte[] sendBytes = getBytes(tmp);
            udpClient.Send(sendBytes, sendBytes.Length);
            recieverThread.Abort();
            udpClient.Close();
        }
    }
}
