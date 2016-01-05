using System;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Slide04
{
    class Program
    {
        static void Server()
        {
            var listener = new TcpListener(13000);
            listener.Start();
            using (var client = listener.AcceptTcpClient())
            {
                var stream = client.GetStream();
                var textStream = new StreamReader(stream);
                while (true)
                {
                    var line = textStream.ReadLine();
                    if (line == "") break;
                    Console.WriteLine(line);
                }
            }
            listener.Stop();
        }

        static void MainX(string[] args)
        {
            new Action(Server).BeginInvoke(null, null);
            Thread.Sleep(1000);

            using (var client = new TcpClient())
            {
                client.Connect("127.0.0.1", 13000);
                var stream = client.GetStream();
                var textStream = new StreamWriter(stream);
                textStream.WriteLine("Test line 1");
                textStream.Flush();
                textStream.WriteLine("Test line 2");
                textStream.Flush();
                textStream.WriteLine();
                textStream.Flush();
            }

            Thread.Sleep(1000);
        }
    }
}
