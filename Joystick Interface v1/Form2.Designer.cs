namespace Joystick_Interface_v1
{
    partial class Form2
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
            this.richTextBox_line = new System.Windows.Forms.RichTextBox();
            this.richTextBox_compile = new System.Windows.Forms.RichTextBox();
            this.btnJoyStart = new System.Windows.Forms.Button();
            this.btnJoyStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox_line
            // 
            this.richTextBox_line.Location = new System.Drawing.Point(12, 12);
            this.richTextBox_line.Name = "richTextBox_line";
            this.richTextBox_line.Size = new System.Drawing.Size(520, 350);
            this.richTextBox_line.TabIndex = 0;
            this.richTextBox_line.Text = "";
            this.richTextBox_line.TextChanged += new System.EventHandler(this.richTextBox_line_TextChanged);
            // 
            // richTextBox_compile
            // 
            this.richTextBox_compile.Location = new System.Drawing.Point(548, 12);
            this.richTextBox_compile.Name = "richTextBox_compile";
            this.richTextBox_compile.Size = new System.Drawing.Size(520, 350);
            this.richTextBox_compile.TabIndex = 1;
            this.richTextBox_compile.Text = "";
            // 
            // btnJoyStart
            // 
            this.btnJoyStart.Location = new System.Drawing.Point(12, 392);
            this.btnJoyStart.Name = "btnJoyStart";
            this.btnJoyStart.Size = new System.Drawing.Size(80, 50);
            this.btnJoyStart.TabIndex = 2;
            this.btnJoyStart.Text = "Start";
            this.btnJoyStart.UseVisualStyleBackColor = true;
            this.btnJoyStart.Click += new System.EventHandler(this.btnJoyStart_Click);
            // 
            // btnJoyStop
            // 
            this.btnJoyStop.Location = new System.Drawing.Point(98, 392);
            this.btnJoyStop.Name = "btnJoyStop";
            this.btnJoyStop.Size = new System.Drawing.Size(80, 50);
            this.btnJoyStop.TabIndex = 3;
            this.btnJoyStop.Text = "Stop";
            this.btnJoyStop.UseVisualStyleBackColor = true;
            this.btnJoyStop.Click += new System.EventHandler(this.btnJoyStop_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 633);
            this.Controls.Add(this.btnJoyStop);
            this.Controls.Add(this.btnJoyStart);
            this.Controls.Add(this.richTextBox_compile);
            this.Controls.Add(this.richTextBox_line);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_line;
        private System.Windows.Forms.RichTextBox richTextBox_compile;
        private System.Windows.Forms.Button btnJoyStart;
        private System.Windows.Forms.Button btnJoyStop;
    }
}