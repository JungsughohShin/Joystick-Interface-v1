using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

//시리얼 통신 참고 레퍼런스
//https://unininu.tistory.com/304
//https://ggaebap.tistory.com/56
//richTextBox 자동스크롤 Focus 내용
//https://ssscool.tistory.com/13


namespace Joystick_Interface_v1
{ 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) //폼이 로드되면
        {
            comboBox_Com.DataSource = SerialPort.GetPortNames(); //연결 가능한 시리얼 포트 이름을 콤보박스에 가져오기
        }

        private void 컨트롤러ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btn_Cnt_Click(object sender, EventArgs e) //통신 연결하기 버튼 누르면
        {
            if (!serialPort1.IsOpen)
            {//시리얼 포트가 열려 있지 않으면 
                serialPort1.PortName = comboBox_Com.Text; // 콤보박스의 선택된 COM포트 명을 시리얼 포트명으로 지정
                serialPort1.BaudRate = Convert.ToInt32(comboBox_Baud.Text); //// 콤보박스의 선택된 통신 속도로 지정
                serialPort1.DataBits = 8;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Parity = Parity.None;
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived); //이것이 꼭 필요하다

                serialPort1.Open();  //시리얼포트 열기

                label_status.Text = "포트가 열렸습니다.";
                comboBox_Com.Enabled = false;  //COM포트설정 콤보박스 비활성화
            }

            else  //시리얼포트가 열려 있으면
            {
                label_status.Text = "포트가 이미 열려 있습니다.";
            }
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e) //시리얼 통신 수신시 쓰레드 충돌을 피하기 위해 Invoke 사용
        {
            this.Invoke(new EventHandler(MySerialReceived));
            // 메인 쓰레드와 수신 쓰레드의 충돌 방지를 위해 Invoke 사용. MySerialReceived로 이동하여 추가 작업 실행.


        }
        private void MySerialReceived(object s, EventArgs e)  //여기에서 수신 데이터를 사용자의 용도에 따라 처리한다.
        {
            //ReadByte로 수신 버퍼에 있는 데이타를 읽어서 ReceiveData라는 integer 변수에 저장을 했다.
            //이 ReceiveData는 int형식이기 때문에 텍스트박스에 출력하기 위해 string으로 형식 변환을 한 뒤 출력한다.
            //이 부분은 수신 데이타를 사용자가 원하는 목적에 따라 마음대로 코드를 바꾸면 된다.

            //int ReceiveData = serialPort1.ReadByte();  //시리얼 버터에 수신된 데이타를 ReceiveData 읽어오기
            richTextBox_Serial.AppendText( serialPort1.ReadLine());  //int 형식을 string형식으로 변환하여 출력
            //richTextBox_Serial.AppendText("\n");
            //richTextBox_Serial.Focus();
            richTextBox_Serial.ScrollToCaret();//리치텍스트박스 자동 스크롤 

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_SerialSend_Click(object sender, EventArgs e)
        {
            serialPort1.Write(textBox_SerialSend.Text);  //텍스트박스의 텍스트를 시리얼통신으로 송신
        }

        private void btn_Dcnt_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)  //시리얼포트가 열려 있으면
            {
                serialPort1.Close();  //시리얼포트 닫기

                label_status.Text = "포트가 닫혔습니다.";
                comboBox_Com.Enabled = true;  //COM포트설정 콤보박스 활성화
            }
            else  //시리얼포트가 닫혀 있으면
            {
                label_status.Text = "포트가 이미 닫혀 있습니다.";
            }
        }

        private void richTextBox_Serial_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_SerialComCheck_Click(object sender, EventArgs e)
        {
            serialPort1.Write("ADD360");  //"ADD360" 시리얼통신으로 송신
        }
        public int nume = 0;
        private void btn_SpeedCheck_Click(object sender, EventArgs e)
        {
            nume = nume + 10;
            speedometer.Angle=nume.ToString();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }
    }
}
