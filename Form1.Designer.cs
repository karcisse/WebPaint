namespace PT_LAB_6
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.board = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.serverIP = new System.Windows.Forms.TextBox();
            this.serverPort = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.TextBox();
            this.ConBtn = new System.Windows.Forms.Button();
            this.DisConBtn = new System.Windows.Forms.Button();
            this.ColorBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.board)).BeginInit();
            this.SuspendLayout();
            // 
            // board
            // 
            this.board.BackColor = System.Drawing.Color.DarkGreen;
            this.board.Location = new System.Drawing.Point(12, 12);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(766, 408);
            this.board.TabIndex = 0;
            this.board.TabStop = false;
            this.board.MouseDown += new System.Windows.Forms.MouseEventHandler(this.board_MouseDown);
            this.board.MouseMove += new System.Windows.Forms.MouseEventHandler(this.board_MouseMove);
            this.board.MouseUp += new System.Windows.Forms.MouseEventHandler(this.board_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(798, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server IP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(798, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Server port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(798, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Status";
            // 
            // serverIP
            // 
            this.serverIP.Location = new System.Drawing.Point(865, 13);
            this.serverIP.Name = "serverIP";
            this.serverIP.Size = new System.Drawing.Size(100, 20);
            this.serverIP.TabIndex = 4;
            this.serverIP.Text = "127.0.0.1";
            // 
            // serverPort
            // 
            this.serverPort.Location = new System.Drawing.Point(865, 45);
            this.serverPort.Name = "serverPort";
            this.serverPort.Size = new System.Drawing.Size(100, 20);
            this.serverPort.TabIndex = 5;
            this.serverPort.Text = "9050";
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(865, 78);
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Size = new System.Drawing.Size(100, 20);
            this.status.TabIndex = 6;
            // 
            // ConBtn
            // 
            this.ConBtn.Location = new System.Drawing.Point(865, 160);
            this.ConBtn.Name = "ConBtn";
            this.ConBtn.Size = new System.Drawing.Size(75, 23);
            this.ConBtn.TabIndex = 7;
            this.ConBtn.Text = "Connect";
            this.ConBtn.UseVisualStyleBackColor = true;
            this.ConBtn.Click += new System.EventHandler(this.ConBtn_Click);
            // 
            // DisConBtn
            // 
            this.DisConBtn.Location = new System.Drawing.Point(865, 201);
            this.DisConBtn.Name = "DisConBtn";
            this.DisConBtn.Size = new System.Drawing.Size(75, 23);
            this.DisConBtn.TabIndex = 8;
            this.DisConBtn.Text = "Disconnect";
            this.DisConBtn.UseVisualStyleBackColor = true;
            this.DisConBtn.Click += new System.EventHandler(this.DisConBtn_Click);
            // 
            // ColorBtn
            // 
            this.ColorBtn.Location = new System.Drawing.Point(865, 241);
            this.ColorBtn.Name = "ColorBtn";
            this.ColorBtn.Size = new System.Drawing.Size(75, 23);
            this.ColorBtn.TabIndex = 9;
            this.ColorBtn.Text = "Color";
            this.ColorBtn.UseVisualStyleBackColor = true;
            this.ColorBtn.Click += new System.EventHandler(this.ColorBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 429);
            this.Controls.Add(this.ColorBtn);
            this.Controls.Add(this.DisConBtn);
            this.Controls.Add(this.ConBtn);
            this.Controls.Add(this.status);
            this.Controls.Add(this.serverPort);
            this.Controls.Add(this.serverIP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.board);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.board)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox board;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox serverIP;
        private System.Windows.Forms.TextBox serverPort;
        private System.Windows.Forms.TextBox status;
        private System.Windows.Forms.Button ConBtn;
        private System.Windows.Forms.Button DisConBtn;
        private System.Windows.Forms.Button ColorBtn;

    }
}

