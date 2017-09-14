using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
using System.Windows.Forms;


namespace MonitorPingUI
{
    public partial class MainForm : Form
    {
        public string address_for;

        
        static private void SetCancelTrue()               //Метод присваивания переменной, для блокировки 
        {
            PingClass objectPing = new PingClass();
            //cancelCycle = true;
            objectPing.cancelCycle = true;

        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void IPadressBox_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void IPOutputAnswer_Click(object sender, EventArgs e)
        {
            //PingClass objectPing = new PingClass();

            //if (objectPing.outAnswer == "yes")
            //{
            //    IPOutputAnswer.Text = "YES PING!";
            //}
            //else
            //{
            //    IPOutputAnswer.Text = "NO PING!";
            //}
            //if (objectPing.notCorrectAddress == "error")
            //{
            //    MessageBox.Show("ERROR111");
            //}
            //IPOutputAnswer.Text = objectPing.outAnswer;
            //MessageBox.Show(objectPing.outAnswer);
        }

        private async void buttonStart_Click(object sender, EventArgs e)
        {

            //PingClass objectPing = new PingClass();

            //objectPing.address = IPadressBox.Text;
            //address_for = IPadressBox.Text;
            //objectPing.DoPingThread(IPadressBox.Text);

            //MessageBox.Show(objectPing.address);

            if (String.IsNullOrEmpty(IPadressBox.Text))
            {
                DataTextFromIP.Text = "Введите ip адрес";
            }

            else
            {
                PingClass objectPing = new PingClass();
                while (true)
                {
                    IPOutputAnswer.Text = await objectPing.DoPingThreadAsync(IPadressBox.Text);      // Пингуем хост и выводим значение           
                }
            }
        }

        //private async void buttonStart_Click(object sender, EventArgs e)
        //{

        //PingClass objectPing = new PingClass();

        //objectPing.address = IPadressBox.Text;
        //address_for = IPadressBox.Text;
        //objectPing.DoPingThread(IPadressBox.Text);

        //MessageBox.Show(objectPing.address);

        //if (String.IsNullOrEmpty(IPadressBox.Text))
        //{
        //    DataTextFromIP.Text = "Введите ip адрес";
        //}

        //else
        //{
        //    PingClass objectPing = new PingClass();
        //    objectPing.DoPingThreadAsync(IPadressBox.Text);           // Пингуем хост
        // }

        //}

        private void buttonStop_Click(object sender, EventArgs e)
        {

            SetCancelTrue();                  //Остановить цикл отправки ICMP запросов

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

        
    }
}