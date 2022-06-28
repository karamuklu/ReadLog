using ReadText;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LogOku
{
	public partial class Form1 : Form
	{
		BackgroundWorker worker = new BackgroundWorker();
		public Form1()
		{
			InitializeComponent();
		}

		ReadingLog ReadingLog = new ReadingLog();
		List<string> list = new List<string>();
		private void btnReadLog_Click(object sender, EventArgs e)
		{
			if (dtpDate.Value > DateTime.Now)
			{
				MessageBox.Show("Seçtiğiniz tarihle ilgili log bulunamadı");
			}
			else
			{


				if (list.Count == 0)
				{
					list = ReadingLog.ReadText(dtpDate.Value.ToString("yyyyMM"), dtpDate.Value.ToString("yyyyMMdd"));
				}
				else
				{
					list.Clear();
					list = ReadingLog.ReadText(dtpDate.Value.ToString("yyyyMM"), dtpDate.Value.ToString("yyyyMMdd"));
					listBox1.Items.Clear();
				}

				progressBar1.Maximum = list.Count + 1;
				progressBar1.Value = 1;
				progressBar1.Minimum = 1;
				foreach (var item in list)
				{
					listBox1.Items.Add(item);
					progressBar1.Value = progressBar1.Value + 1;
				}
				label1.Text = "Kayıt sayısı : " + list.Count.ToString();
				btnFind.Enabled = true;
				btnSendExcel.Enabled = true;
			}
		}
		private void btnFind_Click(object sender, EventArgs e)
		{

			if (dtpDate.Value > DateTime.Now)
			{
				MessageBox.Show("Seçtiğiniz tarihle ilgili log bulunamadı");
			}

			list = ReadingLog.ReadText(dtpDate.Value.ToString("yyyyMM"), dtpDate.Value.ToString("yyyyMMdd")).Where(i => i.Contains(textBox1.Text)).ToList();
			listBox1.Items.Clear();
			progressBar1.Maximum = list.Count + 1;
			progressBar1.Value = 1;
			progressBar1.Minimum = 1;
			foreach (var item in list)
			{
				listBox1.Items.Add(item);
				progressBar1.Value = progressBar1.Value + 1;
			}
			label1.Text = "Kayıt sayısı : " + list.Count.ToString();
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			btnFind.Enabled = false;
			btnSendExcel.Enabled = false;
			button2.Visible = false;
		}

		private void btnSendExcel_Click(object sender, EventArgs e)
		{
			ReadingLog.SendToExcel(list, textBox1.Text);
			MessageBox.Show("Liste excele aktarılmıştır.");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string[] dosyaYolu = new string[1];
			dosyaYolu[0] = "C:/Users/mustafa.karamuklu/Desktop/deneme/sendtoexcel.xlsx";
			var soamail = new ServiceReference1.MailServiceClient();
			//List<string> mailList = new List<string>() { "mustafa.karamuklu@yildiz.com.tr" };
			//soamail.MailYollaAsync("konu", mailList, "mustafa.karamuklu@yildiz.com.tr", true, "test içerik", ServiceReference1.MailPriority.Normal);

			//mailService.MailYollaAsync("konu", mailList, "mustafa.karamuklu@yildiz.com.tr", true, "test içerik", ServiceReference.MailPriority.Normal);
			try
			{
				soamail.MailGonderAttachmentAsync("Promanage", ServiceReference1.SmtpDeliveryMethod.SpecifiedPickupDirectory, false, false, "PromanageLog", true,
						ServiceReference1.MailPriority.Normal, "Deneme İçerik", "mustafa.karamuklu@yildiz.com.tr", "mustafa.karamuklu@yildiz.com.tr", dosyaYolu, "mustafa.karamuklu@yildiz.com.tr");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}
	}
}
