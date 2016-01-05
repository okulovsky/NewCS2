using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide05
{

    class DisposableClass : IDisposable
    {
        string name;

        public DisposableClass(string name)
        {
            this.name = name;
        }

        private bool isDisposed = false;

        ~DisposableClass()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this); //финализатор не будет вызываться
        }

        protected virtual void Dispose(bool fromDisposeMethod)
        {
            if (!isDisposed)
            {
                if (fromDisposeMethod)
                {
                    Console.WriteLine("Очистка управляемых ресурсов в {0}",name);
                }
                Console.WriteLine("Очистка неуправляемых ресурсов в {0}", name);
                isDisposed = true;
                // base.Dispose(isDisposing); // если унаследован от Disposable класса
            }
        }
    }

    public class Program
    {
        public static void Main1()
        {
            var disposable = new DisposableClass("DisposedManually");
            disposable.Dispose();

            using(disposable=new DisposableClass("DisposedWithUsing"))
            {
                Console.WriteLine("Внутри using");
            }

            disposable = new DisposableClass("DisposedWithGC");
        }

        public static void MainX()
        {
            Main1();
            GC.Collect();
        }
    }
}