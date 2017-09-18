using System.Threading;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

//namespace MonitorPingUI
//{

public class PingClass
{
    public int n;                                         //переменная для подсчета количества icmp запросов

    public string outAnswer;                              //переменная вывода сообщения в окно "вывода"

    public bool cancelCycle = false;                            //переменная отключения цикла (кнопка Stop)


    public async Task<string> DoPingThreadAsync(string address)     //Метод отправки icmp запросов в цикле
    {
        Ping pingSender = new Ping();

        try

        {

            PingReply reply;
            
            {
                n++;
   
                {

                    var result = await Task.Run(() =>
                    {

                        //Ping pingSender = new Ping();
                        reply = pingSender.Send(address);
                        Thread.Sleep(1000);
                        return reply.Status;

                    });

                    if (result == IPStatus.Success)
                    {
                        //IPOutputAnswer.BackColor = Color.Gray;
                        //string backColor = "Color.Gray";
                        //IPOutputAnswer.Text = "ICMP ответ получен - " + n + " Раз" + '\n';
                        outAnswer = "ICMP ответ получен - " + n + " Раз" + '\n';
                        //outAnswer = "ICMP ответ получен";

                    }

                    else

                    {

                        //IPOutputAnswer.BackColor = Color.Red;
                        //IPOutputAnswer.Text = "Ping'a нет!";
                        //outAnswerNo = "Ping'a нет!";
                        outAnswer = "Хост не доступен!";

                    }

                    return outAnswer;
                }

            }

        }

        catch (PingException)
        {
            
            outAnswer = "Некорректный ip адрес!";
        }

        return outAnswer;
    }

}

//}