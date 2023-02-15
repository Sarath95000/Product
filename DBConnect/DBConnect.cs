using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SampleProduct
{
    class DBConnect
    {
        private string DataSource { set; get; }
        private string InitialCatalog { set; get; }
        private bool IsIntegratedSecurity { set; get; }
        internal static SqlConnection connectionObject { set; get; }

        internal DBConnect(string DataSource, string InitialCatalog, bool IsIntegratedSecurity)
        {
            this.DataSource = DataSource;
            this.InitialCatalog = InitialCatalog;
            this.IsIntegratedSecurity = IsIntegratedSecurity;
            connectionObject = connectDB();
        }

        public SqlConnection connectDB()
        {
            SqlConnection connection = new SqlConnection($"Data Source ={ DataSource }; Initial Catalog = { InitialCatalog }; Integrated Security = {IsIntegratedSecurity}");
            return connection;
        }
    }
}
