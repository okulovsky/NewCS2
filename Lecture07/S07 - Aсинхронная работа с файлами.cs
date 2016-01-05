using System;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Slide07
{
    class SlowStream : Stream
    {
        public int WritesCount { get; private set; }
        public readonly int WriteDelay;

        public SlowStream(int writeDelay)
        {
            WriteDelay = writeDelay;
        }

        public override bool CanRead
        {
            get { return false; }
        }

        public override bool CanSeek
        {
            get { return false; }
        }

        public override bool CanWrite
        {
            get { return true; }
        }

        public override void Flush()
        {
           
        }

        public override long Length
        {
            get { return 0; }
        }

        public override long Position
        {
            get;
            set;
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            return 0;
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            return 0;
        }

        public override void SetLength(long value)
        {
            
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            Thread.Sleep(WriteDelay);
            WritesCount++;
        }
    }


    class Program
    {
        static int Rounds;

        static void MakeExperiment(
            Func<Stream> streamFactory, 
            Func<byte[]> informationProducer, 
            Action<Stream,Func<byte[]>> actions)
        {
            if (streamFactory == null) return;
            Stopwatch watch = new Stopwatch();
            var stream = streamFactory();
            watch.Start();
            actions(stream, informationProducer);
            watch.Stop();
            stream.Close();
            Console.WriteLine(watch.ElapsedMilliseconds);
        }


        static void Main(string[] args)
        {
            

            Action<Stream, Func<byte[]>> syncronousActions = (stream, producer) =>
                {
                    for (int i = 0; i < Rounds; i++)
                    {
                        var info = producer();
                        stream.Write(info, 0, info.Length);
                    }
                };

            Action<Stream, Func<byte[]>> asyncronousActions = (stream, producer) =>
                {
                    IAsyncResult result = null;
                    for (int i = 0; i < Rounds; i++)
                    {
                        var info = producer();
                        if (result != null) stream.EndWrite(result);
                        result=stream.BeginWrite(info, 0, info.Length, null, null);
                    }
                    stream.EndWrite(result);
                };

            Action<Stream, Func<byte[]>> asyncAwaitActions = (stream, producer) =>
                {
                    MakeWriteAsync(stream, producer).Wait();
                };


            Func<Stream> streamFactory = null;
            Func<byte[]> infoProducer = null;
            if (false)
            {
                streamFactory = () => new SlowStream(10);
                infoProducer = () => { Thread.Sleep(10); return new byte[0]; };
                Rounds = 100;
            }
            else
            {
                streamFactory = () => File.Open("bin", FileMode.Create, FileAccess.Write);
                infoProducer = () => { Thread.Sleep(5); return new byte[10000000]; };
                Rounds = 100;
            }
            
            
            MakeExperiment(streamFactory, infoProducer, syncronousActions);
            MakeExperiment(streamFactory, infoProducer, asyncronousActions);
            MakeExperiment(streamFactory, infoProducer, asyncAwaitActions);


        }

        async static Task  MakeWriteAsync(Stream stream, Func<byte[]> producer)
        {
            for (int i=0;i<Rounds;i++)
            {
                var info = producer();
                await stream.WriteAsync(info,0,info.Length);
            }
        }
    }
}
