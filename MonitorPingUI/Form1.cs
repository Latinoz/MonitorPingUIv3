using System;
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

        public MainForm()
        {
            InitializeComponent();
        }

        private void IPadressBox_TextChanged(object sender, EventArgs e)
        {


        }

        private void IPOutputAnswer_Click(object sender, EventArgs e)
        {

        }

        private async void buttonStart_Click(object sender, EventArgs e)
        {
            x = false;

            if (String.IsNullOrEmpty(IPadressBox.Text))
            {
                DataTextFromIP.Text = "Enter ip address";
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
                    IPOutputAnswer.Text = await objectPing.DoPingThreadAsync(IPadressBox.Text);      // Пингуем хост и выводим значение           
                }

            }

        }


        private void buttonStop_Click(object sender, EventArgs e)
        {
            x = true;                    //Остановить цикл отправки ICMP запросов
        
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
            x1 = false;

            if (String.IsNullOrEmpty(IPadressBox1.Text))
            {
                DataTextFromIP1.Text = "Enter ip address";
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
                         IPOutputAnswer1.Text = await objectPing1.DoPingThreadAsync(IPadressBox1.Text);      // Пингуем хост и выводим значение           
                     }
            }
        }

        private void buttonStop2_Click(object sender, EventArgs e)
        {
            x1 = true;
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
            x2 = false;

            if (String.IsNullOrEmpty(IPadressBox2.Text))
            {
                DataTextFromIP2.Text = "Enter ip address";
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
                        IPOutputAnswer2.Text = await objectPing2.DoPingThreadAsync(IPadressBox2.Text);      // Пингуем хост и выводим значение           
                    }
            }
        }

        private void buttonStop3_Click(object sender, EventArgs e)
        {
            x2 = true;
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
            x3 = false;

            if (String.IsNullOrEmpty(IPadressBox3.Text))
            {
                DataTextFromIP3.Text = "Enter ip address";
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
                        IPOutputAnswer3.Text = await objectPing3.DoPingThreadAsync(IPadressBox3.Text);      // Пингуем хост и выводим значение           
                    }
            }
        }

        private void buttonStop4_Click(object sender, EventArgs e)
        {
            x3 = true;
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
            x4 = false;

            if (String.IsNullOrEmpty(IPadressBox4.Text))
            {
                DataTextFromIP4.Text = "Enter ip address";
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
                        IPOutputAnswer4.Text = await objectPing4.DoPingThreadAsync(IPadressBox4.Text);      // Пингуем хост и выводим значение           
                    }
            }
        }

        private void buttonStop5_Click(object sender, EventArgs e)
        {
            x4 = true;
        }

        private void DataTextFromIP4_Click(object sender, EventArgs e)
        {

        }


        private void buttonReset_Click(object sender, EventArgs e)
        {
            
            IPadressBox.ResetText();           //Сбросить значения окна ввода ip адреса

            DataTextFromIP.ResetText();        //Сбросить значения окна вывода информации

            IPOutputAnswer.ResetText();        //Сбросить значения окна вывода окна дополнительной информации


            IPadressBox1.ResetText();           

            DataTextFromIP1.ResetText();        

            IPOutputAnswer1.ResetText();        


            IPadressBox2.ResetText();           

            DataTextFromIP2.ResetText();       

            IPOutputAnswer2.ResetText();       


            IPadressBox3.ResetText();           

            DataTextFromIP3.ResetText();        

            IPOutputAnswer3.ResetText();        


            IPadressBox4.ResetText();           

            DataTextFromIP4.ResetText();        

            IPOutputAnswer4.ResetText();        

        }
    }
}