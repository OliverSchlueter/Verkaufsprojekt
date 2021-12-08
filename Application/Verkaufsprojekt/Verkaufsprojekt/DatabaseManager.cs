using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verkaufsprojekt {
    class DatabaseManager {

		public static DatabaseManager Database;

		private string ConnectionString;
		public OleDbConnection Connection;
		public OleDbCommand Command;
		public OleDbDataReader Reader;

		public DatabaseManager(string connectionString) {
			ConnectionString = connectionString;
			Connection = new OleDbConnection(ConnectionString);
			Command = new OleDbCommand();
			Command.Connection = Connection;
			Reader = null;
		}

		public void execute(string sql) {
			try {
				Connection.Open();
				Command.CommandText = sql;
				Command.ExecuteNonQuery();
				Connection.Close();
			} catch (Exception) {
				MessageBox.Show("Ein Fehler ist unterlaufen", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		public OleDbDataReader Read(string sql) {
			try {
				Connection.Open();
				Command.CommandText = sql;
				Reader = Command.ExecuteReader();
				return Reader;
			} catch (Exception e) {
				MessageBox.Show("Ein Fehler ist unterlaufen:\n" + e.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}

			return null;
		}

		public void CloseReaderAndConnection() {
            if (!Reader.IsClosed) {
				Reader.Close();
            }

			if(Connection.State == System.Data.ConnectionState.Open) {
				Connection.Close();
            }

        }

		/**
		 * Each entry in the List does contain one row
		 * Each entry in the Array does contain one field
		 * 
		 * Return: Results of sql-query
		 */
		public List<object[]> GetData(string sql) {
			List<object[]> data = new List<object[]>();

			OleDbDataReader reader = Read(sql);

            while (reader.Read()) {
				object[] values = new object[reader.FieldCount];
				reader.GetValues(values);
				data.Add(values);
            }

			CloseReaderAndConnection();

			return data;
		}

		/**
		 * Do not use
		 */
		private static void example() {
			List<object[]> data = DatabaseManager.Database.GetData("SELECT vorname, nachname FROM benutzer");

			for (int i = 0; i < data.Count; i++) {
				string row = "";
				foreach (object value in data[i]) {
					row += value.ToString() + " ; ";
				}
				MessageBox.Show(row);
			}
		}

	}
}
