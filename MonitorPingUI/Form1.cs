using System;
using System.Windows.Forms;


namespace MonitorPingUI
{
    public partial class MainForm : Form
    {
        public bool x = false;

        public bool x1 = false;

        //private async void SetCancelTrue()               //Метод присваивания переменной, для блокировки 
        //private void SetCancelTrue()
        //{
            //PingClass objectPing = new PingClass();
         //   objectPing.cancelCycle = true;

        //}

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
                DataTextFromIP.Text = "Введите ip адрес";
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
            x = true;
            //SetCancelTrue();                  //Остановить цикл отправки ICMP запросов

        }

        private void DataTextFromIP_Click(object sender, EventArgs e)
        {
            //PingClass objectPing = new PingClass();
            //string value = Convert.ToString(objectPing.test);
            //MessageBox.Show(value);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            //cancelCycle = false;               //Сброс переменной, для остановки цикла в начальное значение  
            PingClass objectPing = new PingClass();
            objectPing.cancelCycle = false;

            IPadressBox.ResetText();           //Сбросить значения окна ввода ip адреса

            DataTextFromIP.ResetText();        //Сбросить значения окна вывода информации

            IPOutputAnswer.ResetText();        //Сбросить значения окна вывода окна дополнительной информации

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
                DataTextFromIP1.Text = "Введите ip адрес";
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
            //SetCancelTrue();                  //Остановить цикл отправки ICMP запросов
        }
        
        private void DataTextFromIP1_Click(object sender, EventArgs e)
        {

        }
    }
}