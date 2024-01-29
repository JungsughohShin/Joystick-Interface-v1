namespace Joystick_Interface_v1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.환경ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.컨트롤러ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_SerialSend = new System.Windows.Forms.TextBox();
            this.btn_SerialSend = new System.Windows.Forms.Button();
            this.comboBox_Com = new System.Windows.Forms.ComboBox();
            this.comboBox_Baud = new System.Windows.Forms.ComboBox();
            this.btn_Cnt = new System.Windows.Forms.Button();
            this.richTextBox_Serial = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Dcnt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label_status = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.환경ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1302, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 환경ToolStripMenuItem
            // 
            this.환경ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.컨트롤러ToolStripMenuItem});
            this.환경ToolStripMenuItem.Name = "환경ToolStripMenuItem";
            this.환경ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.환경ToolStripMenuItem.Text = "환경";
            // 
            // 컨트롤러ToolStripMenuItem
            // 
            this.컨트롤러ToolStripMenuItem.Name = "컨트롤러ToolStripMenuItem";
            this.컨트롤러ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.컨트롤러ToolStripMenuItem.Text = "컨트롤러 확인";
            this.컨트롤러ToolStripMenuItem.Click += new System.EventHandler(this.컨트롤러ToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(73, 629);
            this.panel2.TabIndex = 0;
            // 
            // textBox_SerialSend
            // 
            this.textBox_SerialSend.Location = new System.Drawing.Point(89, 299);
            this.textBox_SerialSend.Multiline = true;
            this.textBox_SerialSend.Name = "textBox_SerialSend";
            this.textBox_SerialSend.Size = new System.Drawing.Size(480, 37);
            this.textBox_SerialSend.TabIndex = 3;
            // 
            // btn_SerialSend
            // 
            this.btn_SerialSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_SerialSend.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_SerialSend.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_SerialSend.Location = new System.Drawing.Point(575, 299);
            this.btn_SerialSend.Name = "btn_SerialSend";
            this.btn_SerialSend.Size = new System.Drawing.Size(75, 37);
            this.btn_SerialSend.TabIndex = 4;
            this.btn_SerialSend.Text = "Send";
            this.btn_SerialSend.UseVisualStyleBackColor = true;
            this.btn_SerialSend.Click += new System.EventHandler(this.btn_SerialSend_Click);
            // 
            // comboBox_Com
            // 
            this.comboBox_Com.FormattingEnabled = true;
            this.comboBox_Com.ImeMode = System.Windows.Forms.ImeMode.On;
            this.comboBox_Com.Location = new System.Drawing.Point(129, 361);
            this.comboBox_Com.Name = "comboBox_Com";
            this.comboBox_Com.Size = new System.Drawing.Size(80, 20);
            this.comboBox_Com.TabIndex = 5;
            // 
            // comboBox_Baud
            // 
            this.comboBox_Baud.FormattingEnabled = true;
            this.comboBox_Baud.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
            this.comboBox_Baud.Location = new System.Drawing.Point(129, 387);
            this.comboBox_Baud.Name = "comboBox_Baud";
            this.comboBox_Baud.Size = new System.Drawing.Size(80, 20);
            this.comboBox_Baud.TabIndex = 6;
            // 
            // btn_Cnt
            // 
            this.btn_Cnt.Location = new System.Drawing.Point(91, 423);
            this.btn_Cnt.Name = "btn_Cnt";
            this.btn_Cnt.Size = new System.Drawing.Size(57, 34);
            this.btn_Cnt.TabIndex = 7;
            this.btn_Cnt.Text = "연결";
            this.btn_Cnt.UseVisualStyleBackColor = true;
            this.btn_Cnt.Click += new System.EventHandler(this.btn_Cnt_Click);
            // 
            // richTextBox_Serial
            // 
            this.richTextBox_Serial.Location = new System.Drawing.Point(89, 32);
            this.richTextBox_Serial.Name = "richTextBox_Serial";
            this.richTextBox_Serial.Size = new System.Drawing.Size(561, 261);
            this.richTextBox_Serial.TabIndex = 8;
            this.richTextBox_Serial.Text = "";
            this.richTextBox_Serial.TextChanged += new System.EventHandler(this.richTextBox_Serial_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "COM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "Baud";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_Dcnt
            // 
            this.btn_Dcnt.Location = new System.Drawing.Point(154, 423);
            this.btn_Dcnt.Name = "btn_Dcnt";
            this.btn_Dcnt.Size = new System.Drawing.Size(55, 34);
            this.btn_Dcnt.TabIndex = 11;
            this.btn_Dcnt.Text = "해제";
            this.btn_Dcnt.UseVisualStyleBackColor = true;
            this.btn_Dcnt.Click += new System.EventHandler(this.btn_Dcnt_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label_status);
            this.panel1.Controls.Add(this.btn_Dcnt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.richTextBox_Serial);
            this.panel1.Controls.Add(this.btn_Cnt);
            this.panel1.Controls.Add(this.comboBox_Baud);
            this.panel1.Controls.Add(this.comboBox_Com);
            this.panel1.Controls.Add(this.btn_SerialSend);
            this.panel1.Controls.Add(this.textBox_SerialSend);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1302, 653);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(89, 470);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(40, 12);
            this.label_status.TabIndex = 12;
            this.label_status.Text = "Status";
            this.label_status.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 653);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 환경ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 컨트롤러ToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_SerialSend;
        private System.Windows.Forms.Button btn_SerialSend;
        private System.Windows.Forms.ComboBox comboBox_Com;
        private System.Windows.Forms.ComboBox comboBox_Baud;
        private System.Windows.Forms.Button btn_Cnt;
        private System.Windows.Forms.RichTextBox richTextBox_Serial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Dcnt;
        private System.Windows.Forms.Panel panel1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label_status;
    }
}

