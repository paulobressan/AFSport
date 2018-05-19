using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace AFSport.Service.Base
{
    public abstract class BaseRepository : IDisposable
    {
        protected IDbConnection _context { get; set; }   
        public BaseRepository()
        {
            this._context = new MySqlConnection(ConfigurationManager.ConnectionStrings["conexao"].ConnectionString);
        }

        public void Dispose()
        {
            _context.Close();
            _context.Dispose();
        }
    }
}
