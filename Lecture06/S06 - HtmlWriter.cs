using System;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide06
{


    class HtmlWriter : IDisposable
    {
        StreamWriter destination;
        public HtmlWriter(StreamWriter destination)
        {
            this.destination = destination;
        }



        public void Write(string content)
        {
            destination.WriteLine(content);
        }

        #region Disposable pattern

        private bool isDisposed = false;

        ~HtmlWriter()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this); //деструктор не будет вызываться
        }

        protected virtual void Dispose(bool fromDisposeMethod)
        {
            if (!isDisposed)
            {
                if (fromDisposeMethod)
                {
                    destination.Dispose();
                }
                isDisposed = true;
            }
        }

        #endregion

        public TagToken Tag(string tagName)
        {
            destination.WriteLine("<{0}>", tagName);
            return new TagToken(this, tagName);
        }

        public class TagToken : IDisposable
        {
            readonly HtmlWriter writer;
            readonly string tag;
            public TagToken(HtmlWriter writer, string tag)
            {
                this.writer = writer;
                this.tag = tag;
            }
            public void Dispose()
            {
                writer.destination.WriteLine("</{0}>", tag);
            }
        }
    }

    

    class Program
    {
        static void Main(string[] args)
        {
            using (var htmlWriter = new HtmlWriter(new StreamWriter("text")))
            {
                using(htmlWriter.Tag("body"))
                {
                    htmlWriter.Write("some content");
                }
            }

            Console.WriteLine(File.ReadAllText("text"));
        }
    }
}
