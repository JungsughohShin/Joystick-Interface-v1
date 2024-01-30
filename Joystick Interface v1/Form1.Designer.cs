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
            this.menu_ControlCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_joyStart = new System.Windows.Forms.Button();
            this.btn_SpeedCheck = new System.Windows.Forms.Button();
            this.btn_SerialComCheck = new System.Windows.Forms.Button();
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
            this.speedometer = new UserSpeedometer.UserControl1();
            this.label_status = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btn_joyStop = new System.Windows.Forms.Button();
            this.btn_findCom = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
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
            this.menu_ControlCheck});
            this.환경ToolStripMenuItem.Name = "환경ToolStripMenuItem";
            this.환경ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.환경ToolStripMenuItem.Text = "환경";
            // 
            // menu_ControlCheck
            // 
            this.menu_ControlCheck.Name = "menu_ControlCheck";
            this.menu_ControlCheck.Size = new System.Drawing.Size(150, 22);
            this.menu_ControlCheck.Text = "컨트롤러 확인";
            this.menu_ControlCheck.Click += new System.EventHandler(this.컨트롤러ToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.btn_findCom);
            this.panel2.Controls.Add(this.btn_joyStop);
            this.panel2.Controls.Add(this.btn_joyStart);
            this.panel2.Controls.Add(this.btn_SpeedCheck);
            this.panel2.Controls.Add(this.btn_SerialComCheck);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(73, 629);
            this.panel2.TabIndex = 0;
            // 
            // btn_joyStart
            // 
            this.btn_joyStart.BackColor = System.Drawing.Color.DarkGray;
            this.btn_joyStart.Location = new System.Drawing.Point(8, 130);
            this.btn_joyStart.Name = "btn_joyStart";
            this.btn_joyStart.Size = new System.Drawing.Size(53, 44);
            this.btn_joyStart.TabIndex = 15;
            this.btn_joyStart.Text = "Joy   Start";
            this.btn_joyStart.UseVisualStyleBackColor = false;
            this.btn_joyStart.Click += new System.EventHandler(this.btn_Joystick_Click);
            // 
            // btn_SpeedCheck
            // 
            this.btn_SpeedCheck.BackColor = System.Drawing.Color.DarkGray;
            this.btn_SpeedCheck.Location = new System.Drawing.Point(8, 70);
            this.btn_SpeedCheck.Name = "btn_SpeedCheck";
            this.btn_SpeedCheck.Size = new System.Drawing.Size(53, 44);
            this.btn_SpeedCheck.TabIndex = 14;
            this.btn_SpeedCheck.Text = "SpeedCheck";
            this.btn_SpeedCheck.UseVisualStyleBackColor = false;
            this.btn_SpeedCheck.Click += new System.EventHandler(this.btn_SpeedCheck_Click);
            // 
            // btn_SerialComCheck
            // 
            this.btn_SerialComCheck.BackColor = System.Drawing.Color.DarkGray;
            this.btn_SerialComCheck.Location = new System.Drawing.Point(8, 8);
            this.btn_SerialComCheck.Name = "btn_SerialComCheck";
            this.btn_SerialComCheck.Size = new System.Drawing.Size(53, 44);
            this.btn_SerialComCheck.TabIndex = 13;
            this.btn_SerialComCheck.Text = "Serial Check";
            this.btn_SerialComCheck.UseVisualStyleBackColor = false;
            this.btn_SerialComCheck.Click += new System.EventHandler(this.btn_SerialComCheck_Click);
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
            this.panel1.Controls.Add(this.speedometer);
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
            // speedometer
            // 
            this.speedometer.Angle = "0";
            this.speedometer.Location = new System.Drawing.Point(701, 436);
            this.speedometer.MeterName = "SPEED";
            this.speedometer.Name = "speedometer";
            this.speedometer.Number1 = "0";
            this.speedometer.Number2 = "5";
            this.speedometer.Number3 = "10";
            this.speedometer.Number4 = "15";
            this.speedometer.Number5 = "20";
            this.speedometer.Number6 = "25";
            this.speedometer.Number7 = "30";
            this.speedometer.Size = new System.Drawing.Size(205, 205);
            this.speedometer.TabIndex = 13;
            this.speedometer.Load += new System.EventHandler(this.userControl11_Load);
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
            // btn_joyStop
            // 
            this.btn_joyStop.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_joyStop.Location = new System.Drawing.Point(8, 189);
            this.btn_joyStop.Name = "btn_joyStop";
            this.btn_joyStop.Size = new System.Drawing.Size(53, 44);
            this.btn_joyStop.TabIndex = 16;
            this.btn_joyStop.Text = "Joy   Stop";
            this.btn_joyStop.UseVisualStyleBackColor = false;
            this.btn_joyStop.Click += new System.EventHandler(this.btn_joyStop_Click);
            // 
            // btn_findCom
            // 
            this.btn_findCom.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_findCom.Location = new System.Drawing.Point(8, 252);
            this.btn_findCom.Name = "btn_findCom";
            this.btn_findCom.Size = new System.Drawing.Size(53, 44);
            this.btn_findCom.TabIndex = 17;
            this.btn_findCom.Text = "Find COM";
            this.btn_findCom.UseVisualStyleBackColor = false;
            this.btn_findCom.Click += new System.EventHandler(this.btn_findCom_Click);
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
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 환경ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_ControlCheck;
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
        private System.Windows.Forms.Button btn_SerialComCheck;
        private UserSpeedometer.UserControl1 speedometer;
        private System.Windows.Forms.Button btn_SpeedCheck;
        private System.Windows.Forms.Button btn_joyStart;
        private System.Windows.Forms.Button btn_joyStop;
        private System.Windows.Forms.Button btn_findCom;
    }
}

