using System;
using SharpDX.DirectInput;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

//시리얼 통신 참고 레퍼런스
//https://unininu.tistory.com/304
//https://ggaebap.tistory.com/56
//richTextBox 자동스크롤 Focus 내용
//https://ssscool.tistory.com/13
//폼간의 데이터 통신
//https://dream-hacker.tistory.com/55
//크로스 스레드
//https://afsdzvcx123.tistory.com/entry/C-%EC%9C%88%ED%8F%BC-%EC%9C%88%ED%8F%BC-%EC%93%B0%EB%A0%88%EB%93%9CThread-%EC%82%AC%EC%9A%A9%ED%95%98%EA%B8%B0



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

        //private bool joystickDo = false;
        Form2 newform2 = new Form2();
        

        private void 컨트롤러ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (joy != null)
            {
                btn_joyStart.BackColor = Color.Firebrick;
                btn_joyStop.BackColor = Color.MediumSeaGreen;
                joy.Abort();
                tryNum = 0;
            }
            newform2.ShowDialog();
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
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("ADD360");  //"ADD360" 시리얼통신으로 송신

            }
        }
        public int nume = 0;
        private void btn_SpeedCheck_Click(object sender, EventArgs e)
        {
            nume = nume - 10;
            speedometer.Angle=nume.ToString();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void getJoystick()
        {
            //  <1> 기기 검색
            // Initialize DirectInput
            var directInput = new DirectInput();

            // Find a Joystick Guid
            var joystickGuid = Guid.Empty;

            foreach (var deviceInstance in directInput.GetDevices(DeviceType.Gamepad, DeviceEnumerationFlags.AllDevices))
            {
                joystickGuid = deviceInstance.InstanceGuid;//디바이스 인스턴스를 넣음

            }

            // If Gamepad not found, look for a Joystick
            if (joystickGuid == Guid.Empty)//Guid.Empty는 인스턴스가 안들어 있는 것이다 .
            {

                foreach (var deviceInstance in directInput.GetDevices(DeviceType.Joystick, DeviceEnumerationFlags.AllDevices))
                    joystickGuid = deviceInstance.InstanceGuid;// 다시 인스턴스 넣어라

            }
            //게임패드 먼저 검색후, 조이 스틱 탐색

            // If Joystick not found, throws an error
            if (joystickGuid == Guid.Empty)
            {
                //richTextBox_line.AppendText("No joystick/Gamepad found.");
                //richTextBox_line.AppendText("\n");
                //richTextBox_line.ScrollToCaret();//리치텍스트박스 자동 스크롤 


            }
            // <2> 조이스틱 선언
            else
            {

                // Instantiate the joystick
                var joystick = new Joystick(directInput, joystickGuid); //조이스틱 객체 선언

              

                //richTextBox_line.AppendText("Found Joystick/Gamepad with GUID: " + joystickGuid);
                //richTextBox_line.AppendText("\n");
                //richTextBox_line.ScrollToCaret();//리치텍스트박스 자동 스크롤 

                // Query all suported ForceFeedback effects
                var allEffects = joystick.GetEffects();

                foreach (var effectInfo in allEffects)
                {
                    

                    //richTextBox_line.AppendText("Effect available " + effectInfo.Name);
                    //richTextBox_line.AppendText("\n");
                    //richTextBox_line.ScrollToCaret();//리치텍스트박스 자동 스크롤 
                }
                // Set BufferSize in order to use buffered data.
                joystick.Properties.BufferSize = 128;


                //<3>값가져오기 시작 


                // Acquire the joystick
                joystick.Acquire();

                //서보모터 2개만 사용
                int left_Y = 0; //모터 세기 (0~32768) >> ( 0~32)
                //int left_X = -1; //안쓰는 값 
                //int right_Y = -1; //안쓰는 값
                int right_X = 0;// (-32767 ~ 327678)>> ( -32 ~ 32) (-):좌회전, (+):우회전 
                int rightBtn_Up = 0; //1일때는 상승 동작, 0일 때는 동작 X
                int rightBtn_Dn = 0; //1일때는 하강 동작, 0일 때는 동작 X


                //                왼쪽
                //- X 왼쪽 0 오른쪽 65535(1000단위로 나눔)
                //- Y 아래 65535 , 위0
                //- Buttons8: 누를때 128, 땔때 0

                //오른쪽 조이스틱(날개 좌우 위아래)
                //-rotation x: 왼쪽 0 오른쪽 65535(1000단위로 나눔)
                //- rotation Y 아래 65535 , 위0
                //--Buttons9: 누를때 128, 땔때 0

                //오른쪽 7번 버튼 
                //누르고 있으면 128, 때는 순간 0
                //이름은 Button5

                //오른쪽 8번 버튼 
                //누르고 있으면 128, 때는 순간 0
                //이름은 Z


                // Poll events from joystick
                while (true)
                {
                    joystick.Poll();//조이스틱 조작할 시에 

                    JoystickUpdate[] states = joystick.GetBufferedData();

                    foreach (var state in states)
                    {
                        
                        //richTextBox_line.AppendText(state.ToString());
                        //richTextBox_line.AppendText("\n");
                        //richTextBox_line.ScrollToCaret();//리치텍스트박스 자동 스크롤 

                        int val = state.Value;
                        //JoystickOffset offset = state.Offset;
                        JoystickOffset joyType = state.Offset;
                        String strType = joyType.ToString();



                        int typeCorrect = 0;
                        if (strType == "Y")
                        {
                            int val2 = val - 32767;//원점을 0으로 잡기 위함이다. 
                            if (val2 < 0)
                            {
                                val2 = val2 * (-1);

                            }

                            left_Y = val2 / 1000;// (0~32768) >> (0~32)
                            typeCorrect = 1;
                        }
                        else if (strType == "RotationX")
                        {
                            int val2 = val - 32767;//원점을 0으로 잡기 위함이다. 

                            if (val2 < 0)
                            {
                                val2 = val2 * (-1);
                                val2 = val2 / 1000;
                                right_X = val2 * (-1);


                            }
                            else if (val2 > 0)
                            {
                                right_X = val2 / 1000;

                            }
                            typeCorrect = 1;

                        }
                        else if (strType == "Buttons5")
                        {
                            if (val == 128)
                            {
                                rightBtn_Up = 1;
                            }
                            else
                            {
                                rightBtn_Up = 0;

                            }
                            typeCorrect = 1;



                        }
                        else if (strType == "Z")
                        {
                            if (val == 128)
                            {
                                rightBtn_Dn = 1;
                            }
                            else
                            {
                                rightBtn_Dn = 0;

                            }
                            typeCorrect = 1;

                        }
                        if (typeCorrect == 1)
                        {
                            string compileStr = "Speed : " + left_Y.ToString() + " ";
                            compileStr = compileStr + "Turn :  " + right_X.ToString() + " ";
                            compileStr = compileStr + "UP : " + rightBtn_Up.ToString() + " ";
                            compileStr = compileStr + "DOWN : " + rightBtn_Dn.ToString() + " ";

                            if (left_Y > 30) {
                                left_Y = 30;
                            }

                            int speedAngle = left_Y * 10;

                            speedometer.Angle = speedAngle.ToString();

                           
                            //richTextBox_compile.AppendText(compileStr);
                            //richTextBox_compile.AppendText("\n");
                            //richTextBox_compile.ScrollToCaret();//리치텍스트박스 자동 스크롤 
                        }
                        else
                        {   
                            //richTextBox_compile.AppendText("Can't Compile Data");
                            //richTextBox_compile.AppendText("\n");
                            // richTextBox_compile.ScrollToCaret();//리치텍스트박스 자동 스크롤 

                        }


                    }
                }

            }
        }
        Thread joy;
        int tryNum=0;
       
       
        private void btn_Joystick_Click(object sender, EventArgs e) //처음 누르면 시작, 다음에 누르면 정지, 그 다음 다시 시작
        {
          
            if (tryNum == 0)
            {
                btn_joyStart.BackColor = Color.MediumSeaGreen;
                btn_joyStop.BackColor = Color.Firebrick;

                joy = new Thread(getJoystick);
                joy.Name = "Test Thread";
                //joy.IsBackground = true;
                joy.Start();

            }
           
            tryNum++;
            

               
        }
        
        private void btn_joyStop_Click(object sender, EventArgs e)
        {
            if (joy !=null)
            {
                btn_joyStart.BackColor = Color.Firebrick;
                btn_joyStop.BackColor = Color.MediumSeaGreen;
                joy.Abort();
                tryNum = 0;
            }
        }

        private void btn_findCom_Click(object sender, EventArgs e)
        {
            comboBox_Com.DataSource = SerialPort.GetPortNames(); //연결 가능한 시리얼 포트 이름을 콤보박스에 가져오기
        }

        private void fuelMeter1_Load(object sender, EventArgs e)
        {
            fuelMeter1.Angle = 85.ToString(); // 대충 넣은 값

        }
    }
}
