using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class DisposeExample : IDisposable
    {
        private bool isDisposed = false;

        private void Cleaning(bool disposing)
        {
            if (isDisposed)  return;

                Console.WriteLine("Освобождение неуправляемых ресурсов");

                if (disposing)
                {
                    Console.WriteLine("Освобождение управляемых ресурсов");

                    isDisposed = true;
                }
              
        }
        public void Dispose()
        {
            Cleaning(true);
            GC.SuppressFinalize(this);
        }

        ~DisposeExample()
        {
            Cleaning(false);
        }
        public void DoSomething()
        {
            Console.WriteLine("Выполнение определённых операций");

            isDisposed = true;
        }


    }
}
