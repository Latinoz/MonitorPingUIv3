using System.Threading;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using MonitorPingUI;

public class PingClass
{
    //public int n;                                                   //переменная для подсчета количества icmp запросов

    //public string outAnswer;                                        //переменная вывода сообщения в окно "вывода"
    public TextOutAnswer outAnswer;

    //public async Task<string> DoPingThreadAsync(string address)     //Метод отправки icmp запросов в цикле
    public async Task<TextOutAnswer> DoPingThreadAsync(string address)
    {
        Ping pingSender = new Ping();

        try

        {

            PingReply reply;
            
            {
                //n++;
   
                {

                    var result = await Task.Run(() =>
                    {
 
                        reply = pingSender.Send(address);
                        Thread.Sleep(1000);
                        return reply.Status;

                    });

                    if (result == IPStatus.Success)
                    {
                        //outAnswer = "ICMP answer received - " + n + " times" + '\n';
                        //outAnswer = "ICMP answer received";
                        outAnswer = TextOutAnswer.Success;

                    }

                    else

                    {
                        //outAnswer = "Host is not available!";
                        outAnswer = TextOutAnswer.Warning;

                    }

                    return outAnswer;
                }

            }

        }

        catch (PingException)
        {
            //outAnswer = "Invalid ip address!";
            outAnswer = TextOutAnswer.Error;
        }

        return outAnswer;
    }

}

