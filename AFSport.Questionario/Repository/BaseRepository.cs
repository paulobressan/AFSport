using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;

namespace AFSport.Questionario.Repository
{
    public abstract class BaseRepository : IDisposable
    {
        protected IDbConnection _context { get; set; }
        public BaseRepository()
        {
            _context = new MySqlConnection(ConfigurationManager.ConnectionStrings["conexaoQuestionario"].ConnectionString);
        }

        public void Dispose()
        {
            _context.Close();
            _context.Dispose();
        }
    }
}
