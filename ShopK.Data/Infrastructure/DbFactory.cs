using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopK.Data.Infrastructure
{
    //ke thua interface va abstract
    public class DbFactory : Disposable, IDbFactory
    {
        private ShopKDbContext dbContext;

        //Phuong thuc Init se khoi tao 1 doi tuong cho dbContext
        public ShopKDbContext Init()
        {
            //Kiem tra neu = no null thi khoi tao dbContext
            return dbContext ?? (dbContext = new ShopKDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();//Khac null thi Dispose no
        }
    }
}
