using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLNV.DATA.DBContext
{
    public class DbContext : IDisposable
    {
        public MySqlConnection Connection { get; }

        public DbContext(string ConnectionString)
        {
            Connection = new MySqlConnection(ConnectionString);
        }
        public void Dispose()
        {
            Connection.Dispose();
        }
    }
}
