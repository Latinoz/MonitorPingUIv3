using System;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace MonitorPingUI
{
    public partial class MainForm : Form
    {
        public bool x = false;                            //Объявление переменной, служит для остановки цикла выполнения мониторинга
                                                          //из форм
        public bool x1 = false;

        public bool x2 = false;

        public bool x3 = false;

        public bool x4 = false;

        public TextOutAnswer answer;                      //переменная answer с типом TextOutAnswer

        public MainForm()
        {
            InitializeComponent();

            this.ShowInTaskbar = false;
            notifyIcon1.Click += notifyIcon1_MouseDoubleClick;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void IPadressBox_TextChanged(object sender, EventArgs e)
        {


        }

        private void IPOutputAnswer_Click(object sender, EventArgs e)
        {

        }

        private async void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;

            buttonStop.Enabled = true;

            x = false;

            if (String.IsNullOrEmpty(IPadressBox.Text))
            {
                DataTextFromIP.Text = "Enter ip address";

                x = true;

                buttonStart.Enabled = true;

                buttonStop.Enabled = false;
            }

            else
            {
                
                PingClass objectPing = new PingClass();
                while (true)
                 if (x == true)
                 {
                        break;
                 }

                else
                {
                        answer = await objectPing.DoPingThreadAsync(IPadressBox.Text);          // Пингуем хост и выводим значение 
                        if (answer == TextOutAnswer.Success)
                        {
                           IPOutputAnswer.BackColor = Color.LightGreen;
                           IPOutputAnswer.Text = "ICMP answer received";
                        }
                        else if(answer == TextOutAnswer.Warning)
                        {
                           IPOutputAnswer.BackColor = Color.Red;
                           IPOutputAnswer.Text = "Host is not available!";
                           // задаем текст подсказки
                           notifyIcon1.BalloonTipText = "Host is not available!";
                           // устанавливаем зголовк
                           notifyIcon1.BalloonTipTitle = "Attention";
                           // отображаем подсказку 3 секунд
                           notifyIcon1.ShowBalloonTip(3);
                        }
                        else if(answer == TextOutAnswer.Error)
                        {
                           x = true;
                           buttonStart.Enabled = true;
                           buttonStop.Enabled = false;
                           IPOutputAnswer.BackColor = Color.Gray;
                           IPOutputAnswer.Text = "Invalid ip address!";
                        }
                }

            }

        }


        private void buttonStop_Click(object sender, EventArgs e)
        {
            x = true;                    //Остановить цикл отправки ICMP запросов

            buttonStart.Enabled = true;

            buttonStop.Enabled = false;

            
            
        }

        private void DataTextFromIP_Click(object sender, EventArgs e)
        {
            
        }
 
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void IPadressBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void IPOutputAnswer1_Click(object sender, EventArgs e)
        {

        }

        private async void buttonStart1_Click(object sender, EventArgs e)
        {
            buttonStart1.Enabled = false;

            buttonStop2.Enabled = true;

            x1 = false;

            if (String.IsNullOrEmpty(IPadressBox1.Text))                   //Проверка на пустое поле
            {
                DataTextFromIP1.Text = "Enter ip address";

                x1 = true;

                buttonStart1.Enabled = true;

                buttonStop2.Enabled = false;
            }

            else
            {
                PingClass objectPing1 = new PingClass();
                while (true)
                    
                 if (x1 == true)
                 {
                            break;
                  }
                    else
                    {
                        answer = await objectPing1.DoPingThreadAsync(IPadressBox1.Text);
                        if (answer == TextOutAnswer.Success)
                        {
                            IPOutputAnswer1.BackColor = Color.LightGreen;
                            IPOutputAnswer1.Text = "ICMP answer received";
                        }
                        else if (answer == TextOutAnswer.Warning)
                        {
                            IPOutputAnswer1.BackColor = Color.Red;
                            IPOutputAnswer1.Text = "Host is not available!";
                            notifyIcon1.BalloonTipText = "Host is not available!";
                            notifyIcon1.BalloonTipTitle = "Attention";
                            notifyIcon1.ShowBalloonTip(3);

                        }
                        else if (answer == TextOutAnswer.Error)
                        {
                            x1 = true;
                            buttonStart1.Enabled = true;
                            buttonStop2.Enabled = false;
                            IPOutputAnswer1.BackColor = Color.Gray;
                            IPOutputAnswer1.Text = "Invalid ip address!";
                        }
                    }
            }
        }

        private void buttonStop2_Click(object sender, EventArgs e)
        {
            x1 = true;

            buttonStart1.Enabled = true;

            buttonStop2.Enabled = false;


        }
        
        private void DataTextFromIP1_Click(object sender, EventArgs e)
        {

        }

        private void IPadressBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void IPOutputAnswer2_Click(object sender, EventArgs e)
        {

        }

        private async void buttonStart2_Click(object sender, EventArgs e)
        {
            buttonStart2.Enabled = false;

            buttonStop3.Enabled = true;

            x2 = false;

            if (String.IsNullOrEmpty(IPadressBox2.Text))
            {
                DataTextFromIP2.Text = "Enter ip address";

                x2 = true;

                buttonStart2.Enabled = true;

                buttonStop3.Enabled = false;
            }

            else
            {
                PingClass objectPing2 = new PingClass();
                while (true)

                    if (x2 == true)
                    {
                        break;
                    }
                    else
                    {
                        // Пингуем хост и выводим значение   
                        answer = await objectPing2.DoPingThreadAsync(IPadressBox2.Text);
                        if (answer == TextOutAnswer.Success)
                        {
                            IPOutputAnswer2.BackColor = Color.LightGreen;
                            IPOutputAnswer2.Text = "ICMP answer received";
                        }
                        else if (answer == TextOutAnswer.Warning)
                        {
                            IPOutputAnswer2.BackColor = Color.Red;
                            IPOutputAnswer2.Text = "Host is not available!";
                            notifyIcon1.BalloonTipText = "Host is not available!";
                            notifyIcon1.BalloonTipTitle = "Attention";
                            notifyIcon1.ShowBalloonTip(3);

                        }
                        else if (answer == TextOutAnswer.Error)
                        {
                            x2 = true;
                            buttonStart2.Enabled = true;
                            buttonStop3.Enabled = false;
                            IPOutputAnswer2.BackColor = Color.Gray;
                            IPOutputAnswer2.Text = "Invalid ip address!";
                        }
                    }
            }
        }

        private void buttonStop3_Click(object sender, EventArgs e)
        {
            x2 = true;

            buttonStart2.Enabled = true;

            buttonStop3.Enabled = false;
        }

        private void DataTextFromIP2_Click(object sender, EventArgs e)
        {

        }

        private void IPadressBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void IPOutputAnswer3_Click(object sender, EventArgs e)
        {

        }

        private async void buttonStart3_Click(object sender, EventArgs e)
        {
            buttonStart3.Enabled = false;

            buttonStop4.Enabled = true;

            x3 = false;

            if (String.IsNullOrEmpty(IPadressBox3.Text))
            {
                DataTextFromIP3.Text = "Enter ip address";

                x3 = true;

                buttonStart3.Enabled = true;

                buttonStop4.Enabled = false;
            }

            else
            {
                PingClass objectPing3 = new PingClass();
                while (true)

                    if (x3 == true)
                    {
                        break;
                    }
                    else
                    {
                        // Пингуем хост и выводим значение   
                        answer = await objectPing3.DoPingThreadAsync(IPadressBox3.Text);
                        if (answer == TextOutAnswer.Success)
                        {
                            IPOutputAnswer3.BackColor = Color.LightGreen;
                            IPOutputAnswer3.Text = "ICMP answer received";
                        }
                        else if (answer == TextOutAnswer.Warning)
                        {
                            IPOutputAnswer3.BackColor = Color.Red;
                            IPOutputAnswer3.Text = "Host is not available!";
                            notifyIcon1.BalloonTipText = "Host is not available!";
                            notifyIcon1.BalloonTipTitle = "Attention";
                            notifyIcon1.ShowBalloonTip(3);

                        }
                        else if (answer == TextOutAnswer.Error)
                        {
                            x3 = true;
                            buttonStart3.Enabled = true;
                            buttonStop4.Enabled = false;
                            IPOutputAnswer3.BackColor = Color.Gray;
                            IPOutputAnswer3.Text = "Invalid ip address!";
                        }
                    }
            }
        }

        private void buttonStop4_Click(object sender, EventArgs e)
        {
            x3 = true;

            buttonStart3.Enabled = true;

            buttonStop4.Enabled = false;
        }

        private void DataTextFromIP3_Click(object sender, EventArgs e)
        {

        }

        private void IPadressBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void IPOutputAnswer4_Click(object sender, EventArgs e)
        {

        }

        private async void buttonStart4_Click(object sender, EventArgs e)
        {
            buttonStart4.Enabled = false;

            buttonStop5.Enabled = true;

            x4 = false;

            if (String.IsNullOrEmpty(IPadressBox4.Text))
            {
                DataTextFromIP4.Text = "Enter ip address";

                x4 = true;

                buttonStart4.Enabled = true;

                buttonStop5.Enabled = false;
            }

            else
            {
                PingClass objectPing4 = new PingClass();
                while (true)

                    if (x4 == true)
                    {
                        break;
                    }
                    else
                    {
                        // Пингуем хост и выводим значение        
                        answer = await objectPing4.DoPingThreadAsync(IPadressBox4.Text);
                        if (answer == TextOutAnswer.Success)
                        {
                            IPOutputAnswer4.BackColor = Color.LightGreen;
                            IPOutputAnswer4.Text = "ICMP answer received";
                        }
                        else if (answer == TextOutAnswer.Warning)
                        {
                            IPOutputAnswer4.BackColor = Color.Red;
                            IPOutputAnswer4.Text = "Host is not available!";
                            notifyIcon1.BalloonTipText = "Host is not available!";
                            notifyIcon1.BalloonTipTitle = "Attention";
                            notifyIcon1.ShowBalloonTip(3);

                        }
                        else if (answer == TextOutAnswer.Error)
                        {
                            x4 = true;
                            buttonStart4.Enabled = true;
                            buttonStop5.Enabled = false;
                            IPOutputAnswer4.BackColor = Color.Gray;
                            IPOutputAnswer4.Text = "Invalid ip address!";
                        }
                    }
            }
        }

        private void buttonStop5_Click(object sender, EventArgs e)
        {
            x4 = true;

            buttonStart4.Enabled = true;

            buttonStop5.Enabled = false;
        }

        private void DataTextFromIP4_Click(object sender, EventArgs e)
        {

        }


        private void buttonReset_Click(object sender, EventArgs e)
        {
            
            //IPadressBox.ResetText();           //Сбросить значения окна ввода ip адреса

            DataTextFromIP.ResetText();        //Сбросить значения окна вывода информации

            IPOutputAnswer.ResetText();        //Сбросить значения окна вывода окна дополнительной информации


            //IPadressBox1.ResetText();           

            DataTextFromIP1.ResetText();        

            IPOutputAnswer1.ResetText();        


            //IPadressBox2.ResetText();           

            DataTextFromIP2.ResetText();       

            IPOutputAnswer2.ResetText();       


            //IPadressBox3.ResetText();           

            DataTextFromIP3.ResetText();        

            IPOutputAnswer3.ResetText();        


            //IPadressBox4.ResetText();           

            DataTextFromIP4.ResetText();        

            IPOutputAnswer4.ResetText();        

        }

        
    }
}