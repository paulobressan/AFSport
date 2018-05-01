using AFSport.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Service.Base
{
    public abstract class BaseDAO : IDisposable
    {
        protected readonly Context _context;
        public BaseDAO()
        {
            this._context = new Context();
        }

        public void Dispose()
        {
            this._context.Dispose();
        }
    }
}
