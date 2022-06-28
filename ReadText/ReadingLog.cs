
using ArrayToExcel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace ReadText
{
	public class ReadingLog
	{
		public List<string> ReadText(string folderName, string date)
		{
			try
			{
				List<string> list = new List<string>();
				var data = File.ReadLines(@"\\KARIS00232\\Doruk\\" + folderName + "\\" + date + "_Entegrasyon.1.10.ev.log");

				foreach (var item in data)
				{
					list.Add(String.Join(Environment.NewLine, item));
				}
				return list;
			}
			catch (Exception ex)
			{
				//MessageBox.Show(ex.Message.ToString());
				throw;
			}
		}
		public List<string> ReadText()
		{
			List<string> list = new List<string>();
			var data = File.ReadLines(@"\\KARIS00232\\Doruk\\202206\\20220621_Entegrasyon.1.10.ev.log");

			foreach (var item in data)
			{
				list.Add(String.Join(Environment.NewLine, item));
			}
			return list;
		}

		public static void SendToExcel(List<string> rows,string logDetay)
		{
			var dataSet = new DataSet();

			//for (var i = 1; i <= 1; i++)
			//{
			var table = new DataTable($"Table");
			dataSet.Tables.Add(table);

			table.Columns.Add(logDetay, typeof(string));
			//table.Rows.Count = rows.Count + 2;
			//table.Columns.Add($"Column {i}-2", typeof(int));
			//table.Columns.Add($"Column {i}-3", typeof(DateTime));

			for (var x = 0; x < rows.Count; x++)
				table.Rows.Add(rows[x].ToString());
			//table.Rows.Add($"Text #{x}", x * 1000, DateTime.Now.AddDays(-x));
			//}

			var excel = dataSet.ToExcel();

			File.WriteAllBytes($@"C:\\Users\\mustafa.karamuklu\\Desktop\\PromanageLog.xlsx".ToLower(), excel);
		}

		public static void SendMail()
		{

		}
	}
}
