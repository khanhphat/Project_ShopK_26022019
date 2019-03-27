using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopK.Data.Infrastructure
{
    //ke thua tu interface co san cua c#
    public class Disposable : IDisposable
    {
        private bool isDisposed;

        //Khi huy doi tuong dispose thi ko dispose
        ~Disposable()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            //thu hoi vung nho
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!isDisposed && disposing)
            {
                DisposeCore();
            }
            isDisposed = true;
        }

        protected virtual void DisposeCore()
        {

        }
    }
}
