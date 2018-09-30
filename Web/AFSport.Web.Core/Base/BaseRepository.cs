using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace AFSport.Web.Core.Base
{
    public abstract class BaseRepository : IDisposable
    {
        protected readonly IConfiguration _configuration;
        protected IDbConnection _context { get; set; }
        public BaseRepository()
        {
            
        }
        public BaseRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            this._context = new MySqlConnection(_configuration.GetConnectionString("AFSport"));
        }

        public void Dispose()
        {
            _context.Close();
            _context.Dispose();
        }
    }
}
