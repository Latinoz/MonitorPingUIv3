using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

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

        public bool checkLog = false;                   //Переменная для Вкл/Выкл логирования

        public bool checkLog1 = false;

        public bool checkLog2 = false;

        public bool checkLog3 = false;

        public bool checkLog4 = false;

        public bool checkAlarm = true;                   //Переменная для Отк/Вкл оповещения в трее

        public bool checkAlarm1 = true;

        public bool checkAlarm2 = true;

        public bool checkAlarm3 = true;

        public bool checkAlarm4 = true;

        public bool UpdateInForm = false;                 //Для Запроса сохранения в файл

        public TextOutAnswer answer;                      //переменная answer с типом TextOutAnswer

        public MainForm()
        {
            InitializeComponent();

            this.ShowInTaskbar = false;
            notifyIcon1.Click += notifyIcon1_MouseDoubleClick;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, EventArgs e)         //При двойном клике мыше отображение окна 
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadDataFromJson();                                                        //Загрузка списка ip адресов из json
        }

        private void MainForm_Resize(object sender, EventArgs e)                       //При минимизации окна, переносит "окно" в трей
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                this.Hide();
            }

            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)      //При закрытии программы, сохранять или нет
        {
            if (UpdateInForm)
            {
                DialogResult result = MessageBox.Show("Save Changes?", "Attention", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Сохраняем
                    SaveDatesToJson();
                }
                else if (result == DialogResult.No)
                {
                    //Не сохраняем
                }
                else e.Cancel = true;//Отменяем действие
            }
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

            UpdateInForm = true;

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
                            if (checkLog == true)
                            {
                                Logging.DoLog(IPadressBox.Text,IPOutputAnswer.Text);
                            }
                        }
                        else if (answer == TextOutAnswer.Warning)
                        {
                            IPOutputAnswer.BackColor = Color.Red;
                            IPOutputAnswer.Text = "Host is not available!";
                            if (checkLog == true)
                            {
                                Logging.DoLog(IPadressBox.Text, IPOutputAnswer.Text);
                            }

                            if (checkAlarm == true)
                            {
                                // задаем текст подсказки
                                notifyIcon1.BalloonTipText = IPadressBox.Text + " is not available!";
                                // устанавливаем заголовок
                                notifyIcon1.BalloonTipTitle = "Attention";
                                // отображаем подсказку 3 секунд
                                notifyIcon1.ShowBalloonTip(3);
                            }
                        }
                        else if (answer == TextOutAnswer.Error)
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

            //UpdateInForm = true;

        }

        private void DataTextFromIP_Click(object sender, EventArgs e)
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

            UpdateInForm = true;

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
                            if (checkLog1 == true)
                            {
                                Logging.DoLog(IPadressBox1.Text, IPOutputAnswer1.Text);
                            }
                        }
                        else if (answer == TextOutAnswer.Warning)
                        {
                            IPOutputAnswer1.BackColor = Color.Red;
                            IPOutputAnswer1.Text = "Host is not available!";
                            if (checkLog1 == true)
                            {
                                Logging.DoLog(IPadressBox1.Text, IPOutputAnswer1.Text);
                            }
                            if (checkAlarm1 == true)
                            {
                                notifyIcon1.BalloonTipText = IPadressBox1.Text + " is not available!";
                                notifyIcon1.BalloonTipTitle = "Attention";
                                notifyIcon1.ShowBalloonTip(3);
                            }
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

            UpdateInForm = true;

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
                            if (checkLog2 == true)
                            {
                                Logging.DoLog(IPadressBox2.Text, IPOutputAnswer2.Text);
                            }
                        }
                        else if (answer == TextOutAnswer.Warning)
                        {
                            IPOutputAnswer2.BackColor = Color.Red;
                            IPOutputAnswer2.Text = "Host is not available!";
                            if (checkLog2 == true)
                            {
                                Logging.DoLog(IPadressBox2.Text, IPOutputAnswer2.Text);
                            }
                            if (checkAlarm2 == true)
                            {
                                notifyIcon1.BalloonTipText = IPadressBox2.Text + " is not available!";
                                notifyIcon1.BalloonTipTitle = "Attention";
                                notifyIcon1.ShowBalloonTip(3);
                            }
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

            UpdateInForm = true;

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
                            if (checkLog3 == true)
                            {
                                Logging.DoLog(IPadressBox3.Text, IPOutputAnswer3.Text);
                            }
                        }
                        else if (answer == TextOutAnswer.Warning)
                        {
                            IPOutputAnswer3.BackColor = Color.Red;
                            IPOutputAnswer3.Text = "Host is not available!";
                            if (checkLog3 == true)
                            {
                                Logging.DoLog(IPadressBox3.Text, IPOutputAnswer3.Text);
                            }
                            if (checkAlarm3 == true)
                            {
                                notifyIcon1.BalloonTipText = IPadressBox3.Text + " is not available!";
                                notifyIcon1.BalloonTipTitle = "Attention";
                                notifyIcon1.ShowBalloonTip(3);
                            }
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

            UpdateInForm = true;

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
                            if (checkLog4 == true)
                            {
                                Logging.DoLog(IPadressBox4.Text, IPOutputAnswer4.Text);
                            }
                        }
                        else if (answer == TextOutAnswer.Warning)
                        {
                            IPOutputAnswer4.BackColor = Color.Red;
                            IPOutputAnswer4.Text = "Host is not available!";
                            if (checkLog4 == true)
                            {
                                Logging.DoLog(IPadressBox4.Text, IPOutputAnswer4.Text);
                            }
                            if (checkAlarm4 == true)
                            {
                                notifyIcon1.BalloonTipText = IPadressBox4.Text + " is not available!";
                                notifyIcon1.BalloonTipTitle = "Attention";
                                notifyIcon1.ShowBalloonTip(3);
                            }
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

        
        public void SaveDatesToJson()                          //Метод сохранения всех значений ячеек, для ввода ip адреса
        {

            List<Json> iphosts = new List<Json>
            {
                new Json(IPadressBox.Text),
                new Json(IPadressBox1.Text),
                new Json(IPadressBox2.Text),
                new Json(IPadressBox3.Text),
                new Json(IPadressBox4.Text)
            };

            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Json>));

            using (FileStream fs = new FileStream("hosts.json", FileMode.Create))
            {
                jsonFormatter.WriteObject(fs, iphosts);
            }
        }

        public void LoadDataFromJson()
        {
            string path = @"hosts.json";

            if (File.Exists(path))
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {

                    DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Json>));

                    List<Json> iphostsload = (List<Json>)jsonFormatter.ReadObject(fs);

                    IPadressBox.Text = iphostsload[0].Hosts;
                    IPadressBox1.Text = iphostsload[1].Hosts;
                    IPadressBox2.Text = iphostsload[2].Hosts;
                    IPadressBox3.Text = iphostsload[3].Hosts;
                    IPadressBox4.Text = iphostsload[4].Hosts;

                }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkLog = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkLog1 = true;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkLog2 = true;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkLog3 = true;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            checkLog4 = true;
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutForm aboutform = new AboutForm();
            aboutform.ShowDialog();
        }

        private void saveListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDatesToJson();
        }

        private void enableAlarmInTrayToolStripMenuItem_Click(object sender, EventArgs e)     //Метод Включение-Отключение оповещения в трее
        {
            ToolStripMenuItem checkBoxTwo = (ToolStripMenuItem)sender;

            if (checkBoxTwo.Checked == true)
            {
                checkBoxTwo.Checked = false;
                checkAlarm = false;
                checkAlarm1 = false;
                checkAlarm2 = false;
                checkAlarm3 = false;
                checkAlarm4 = false;
            }
            else
            {
                checkBoxTwo.Checked = true;
                checkAlarm = true;
                checkAlarm1 = true;
                checkAlarm2 = true;
                checkAlarm3 = true;
                checkAlarm4 = true;
            }
           

        }
    }
}