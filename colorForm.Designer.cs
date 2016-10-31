namespace PT_LAB_6
{
    partial class colorForm
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
            this.redRadioBtn = new System.Windows.Forms.RadioButton();
            this.blueRadioBtn = new System.Windows.Forms.RadioButton();
            this.yellowRadioBtn = new System.Windows.Forms.RadioButton();
            this.applyBtn = new System.Windows.Forms.Button();
            this.blackRadioBtn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // redRadioBtn
            // 
            this.redRadioBtn.AutoSize = true;
            this.redRadioBtn.BackColor = System.Drawing.Color.Red;
            this.redRadioBtn.Location = new System.Drawing.Point(58, 41);
            this.redRadioBtn.Name = "redRadioBtn";
            this.redRadioBtn.Size = new System.Drawing.Size(100, 17);
            this.redRadioBtn.TabIndex = 0;
            this.redRadioBtn.TabStop = true;
            this.redRadioBtn.Text = "                         ";
            this.redRadioBtn.UseVisualStyleBackColor = false;
            // 
            // blueRadioBtn
            // 
            this.blueRadioBtn.AutoSize = true;
            this.blueRadioBtn.BackColor = System.Drawing.Color.Blue;
            this.blueRadioBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.blueRadioBtn.Location = new System.Drawing.Point(58, 64);
            this.blueRadioBtn.Name = "blueRadioBtn";
            this.blueRadioBtn.Size = new System.Drawing.Size(100, 17);
            this.blueRadioBtn.TabIndex = 1;
            this.blueRadioBtn.TabStop = true;
            this.blueRadioBtn.Text = "                         ";
            this.blueRadioBtn.UseVisualStyleBackColor = false;
            // 
            // yellowRadioBtn
            // 
            this.yellowRadioBtn.AutoSize = true;
            this.yellowRadioBtn.BackColor = System.Drawing.Color.Yellow;
            this.yellowRadioBtn.Location = new System.Drawing.Point(58, 87);
            this.yellowRadioBtn.Name = "yellowRadioBtn";
            this.yellowRadioBtn.Size = new System.Drawing.Size(100, 17);
            this.yellowRadioBtn.TabIndex = 2;
            this.yellowRadioBtn.TabStop = true;
            this.yellowRadioBtn.Text = "                         ";
            this.yellowRadioBtn.UseVisualStyleBackColor = false;
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(30, 132);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(144, 59);
            this.applyBtn.TabIndex = 3;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // blackRadioBtn
            // 
            this.blackRadioBtn.AutoSize = true;
            this.blackRadioBtn.BackColor = System.Drawing.Color.Black;
            this.blackRadioBtn.Location = new System.Drawing.Point(58, 18);
            this.blackRadioBtn.Name = "blackRadioBtn";
            this.blackRadioBtn.Size = new System.Drawing.Size(100, 17);
            this.blackRadioBtn.TabIndex = 4;
            this.blackRadioBtn.TabStop = true;
            this.blackRadioBtn.Text = "                         ";
            this.blackRadioBtn.UseVisualStyleBackColor = false;
            // 
            // colorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 203);
            this.Controls.Add(this.blackRadioBtn);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.yellowRadioBtn);
            this.Controls.Add(this.blueRadioBtn);
            this.Controls.Add(this.redRadioBtn);
            this.Name = "colorForm";
            this.Text = "colorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton redRadioBtn;
        private System.Windows.Forms.RadioButton blueRadioBtn;
        private System.Windows.Forms.RadioButton yellowRadioBtn;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.RadioButton blackRadioBtn;
    }
}