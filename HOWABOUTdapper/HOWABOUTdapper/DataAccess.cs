using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace HOWABOUTdapper
{
    public class DataAccess
    {
        public List<Person> GetPeople(string lastname)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.connectionString("SQLConnectionString")))
            {
                //直接查询
                //var obj = connection.Query<Person>($"select * from Person where LastName = '{ lastname}' ").ToList();
                //执行存储过程
                var obj = connection.Query<Person>("dbo.People_GetByLastName @LastName", new { LastName = lastname }).ToList();
                //var onjExcute = connection.Execute();
                return obj;
            }
        }
    }
}
