using System.Threading;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

//namespace MonitorPingUI
//{

public class PingClass
{
    public int n;                                         //переменная для подсчета количества icmp запросов

    public string outAnswer;                              //переменная вывода сообщения в окно "вывода"

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
 
                        reply = pingSender.Send(address);
                        Thread.Sleep(1000);
                        return reply.Status;

                    });

                    if (result == IPStatus.Success)
                    {
                        //IPOutputAnswer.BackColor = Color.Gray;
                        //string backColor = "Color.Gray";
                        //IPOutputAnswer.Text = "ICMP ответ получен - " + n + " Раз" + '\n';
                        outAnswer = "ICMP answer received - " + n + " times" + '\n';
                        //outAnswer = "ICMP ответ получен";

                    }

                    else

                    {

                        //IPOutputAnswer.BackColor = Color.Red;
                        //IPOutputAnswer.Text = "Ping'a нет!";
                        //outAnswerNo = "Ping'a нет!";
                        outAnswer = "Host is not available!";

                    }

                    return outAnswer;
                }

            }

        }

        catch (PingException)
        {
            
            outAnswer = "Invalid ip address!";
        }

        return outAnswer;
    }

}

//}