using System;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide02
{
    class Program
    {

        const string Filename = "text.txt";
        static string CreateReport()
        {
            throw new Exception();
        }

        static void CheckFile()
        {
            Console.WriteLine(File.ReadAllText(Filename));
        }
        static void MakeReport1()
        {
            var writer = new StreamWriter(Filename);
            writer.WriteLine("Report header");
            writer.WriteLine(CreateReport());
            writer.Close();
        }

        static void MakeReport2()
        {
            try
            {
                var writer = new StreamWriter(Filename);
                writer.WriteLine("Report header");
                writer.WriteLine(CreateReport());
                writer.Close();
            }
            catch
            {
                Console.WriteLine("Error making report");
            }
        }

        static void MakeReport3()
        {
            StreamWriter writer=null;
            try
            {
                writer = new StreamWriter(Filename);
                writer.WriteLine("Report header");
                writer.WriteLine(CreateReport());
            }
            catch (Exception e)
            {
                Console.WriteLine("Error making report: " + e.Message);
            }
            finally
            {
                writer.Close();
            }
        }

        static void MakeReport4()
        {
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(Filename);
                writer.WriteLine("Report header");
                writer.WriteLine(CreateReport());
            }
            catch (Exception e)
            {
                Console.WriteLine("Error making report: " + e.Message);
            }
            finally
            {
                if (writer!=null)
                    writer.Close();
            }
        }

        static void MakeReport5()
        {
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(Filename);
                writer.WriteLine("Report header");
                writer.WriteLine(CreateReport());
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }
    
        static void MakeReport6()
        {
            using (var writer = new StreamWriter(Filename))
            {
                writer.WriteLine("Report header");
                writer.WriteLine(CreateReport());
            }
        }


        static void MainX(string[] args)
        {
            //MakeReport1();
            //MakeReport2();
            //MakeReport3();
            //MakeReport4();
            //TryMakeReport(MakeReport5);
            //TryMakeReport(MakeReport6);
            //CheckFile();
        }
        static void TryMakeReport(Action reportMaker)
        {
            try
            {
                reportMaker();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error making report: " + e.Message);
            }
        }

    }
}
