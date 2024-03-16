using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DataAccess.Tests.Utilities
{
    public static class ConnectionStringProvider
    {
        public static string GetConnectionString() => "Data Source=Data.sqlite";
    }
}
