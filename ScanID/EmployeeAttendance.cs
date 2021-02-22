using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.IO;
using MySql.Data.MySqlClient;

namespace ScanID
{
	class EmployeeAttendance
	{
		MY_DB db = new MY_DB();

		public bool insertAttendance(string id, DateTime datetoday, DateTime in1)
		{
			MySqlCommand command = new MySqlCommand("INSERT INTO `employeeattendance`(`id`, `datetoday`, `in1`, `out1`, `in2`, `out2`, `in3`, `out3`) VALUES (@id,@datetoday,@in1,@out1,@in2,@out2,@in3,@out3)", db.getConnection);

			//@id,@datetoday,@in1,@out1,@in2,@out2,@in3,@out3
			command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
			command.Parameters.Add("@datetoday", MySqlDbType.DateTime).Value = datetoday;
			command.Parameters.Add("@in1", MySqlDbType.DateTime).Value = datetoday;
			command.Parameters.Add("@out1", MySqlDbType.DateTime).Value = null;
			command.Parameters.Add("@in2", MySqlDbType.DateTime).Value = null;
			command.Parameters.Add("@out2", MySqlDbType.DateTime).Value = null;
			command.Parameters.Add("@in3", MySqlDbType.DateTime).Value = null;
			command.Parameters.Add("@out3", MySqlDbType.DateTime).Value = null;

			

			db.openConnection();

			if (command.ExecuteNonQuery() == 1)
			{
				db.closeConnection();
				return true;
			}
			else
			{
				db.closeConnection();
				return false;
			}
		}
	}
}
