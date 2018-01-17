using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace VoicemailApp
{
    public partial class Admin : Form
    {

        private Voicemail form;
        private DataTable detailTable;

        public Admin()
        {
            InitializeComponent();
            form = new Voicemail();
            form.Show();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            form.VBVFrame.StartSystem(true);
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            form.VBVFrame.StopSystem(false);
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'subscriberDataSet.Subscriber_Information' table. You can move, or remove it, as needed.
            this.subscriber_InformationTableAdapter.Fill(this.subscriberDataSet.Subscriber_Information);
            // TODO: This line of code loads data into the 'subscriberDataSet1.Subscriber_Information' table. You can move, or remove it, as needed.
        //    this.subscriber_InformationTableAdapter.Fill(this.subscriberDataSet1.Subscriber_Information);
            // TODO: This line of code loads data into the 'subscriberDataSet.Subscriber_Information' table. You can move, or remove it, as needed.
      //      this.subscriber_InformationTableAdapter.Fill(this.subscriberDataSet.Subscriber_Information);
            // TODO: This line of code loads data into the 'subscriberDataSet.Subscriber_Information' table. You can move, or remove it, as needed.
            //  this.subscriber_InformationTableAdapter.Fill(this.subscriberDataSet.Subscriber_Information);

        }

        private void initializeMBBtn_Click(object sender, EventArgs e)
        {
            try
            {

                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.SubscriberConnectionString.ToString()))
                {
                    conn.Open();

                    string strQuery = @"INSERT INTO Subscriber_Information ([Username], [Mailbox], [Password], [Extension]) VALUES ("
                            + "'" + mbGrid.CurrentRow.Cells[0].Value + "', "
                            + "'" + mbGrid.CurrentRow.Cells[1].Value + "', "
                            + "'" + mbGrid.CurrentRow.Cells[2].Value + "', "
                            + "'" + mbGrid.CurrentRow.Cells[3].Value + "');";
                    OleDbCommand command = new OleDbCommand(strQuery, conn);
                    command.ExecuteNonQuery();
                    string path =@"C:\Program Files(x86)\Pronexus\VBVoice\BOX" + mbGrid.CurrentRow.Cells[1].Value.ToString();
                    Directory.CreateDirectory(path);
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void deleteMBBtn_Click(object sender, EventArgs e)
        {
            try
            {

                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.SubscriberConnectionString.ToString()))
                {
                    conn.Open();
                    detailTable = new DataTable();
                    string strQuery = @"DELETE FROM Subscriber_Information WHERE ("
                            + "Username='" + mbGrid.CurrentRow.Cells[0].Value + "' AND "
                            + "Mailbox='" + mbGrid.CurrentRow.Cells[1].Value + "' AND "
                            + "Password='" + mbGrid.CurrentRow.Cells[2].Value + "' AND "
                            + "Extension='" + mbGrid.CurrentRow.Cells[3].Value + "');";
                    OleDbCommand command = new OleDbCommand(strQuery, conn);
                    
                    command.ExecuteNonQuery();
                    conn.Close();

                    mbGrid.DataSource = subscriber_InformationTableAdapter.GetData();
                    mbGrid.Update();               
                }
            }
            catch (Exception ex)
            {
            }
        }

       
        private void showLineStatusBtn_Click(object sender, EventArgs e)
        {
            form.VBVFrame.ShowLineStatus(true);
        }

        private void hideLinestatusBtn_Click(object sender, EventArgs e)
        {
            form.VBVFrame.ShowLineStatus(false);
        }

        private void showDesignBtn_Click(object sender, EventArgs e)
        {
            form.Show();
        }

        private void hideDesignBtn_Click(object sender, EventArgs e)
        {
            form.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)            
                form.VBVFrame.ShowLogWindow(1, true);           
            else
                form.VBVFrame.ShowLogWindow(1, false);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                form.VBVFrame.ShowLogWindow(2, true);
            else
                form.VBVFrame.ShowLogWindow(2, false);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                form.VBVFrame.ShowLogWindow(3, true);
            else
                form.VBVFrame.ShowLogWindow(3, false);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
                form.VBVFrame.ShowLogWindow(4, true);
            else
                form.VBVFrame.ShowLogWindow(4, false);
        }

        private void removeDelMessagesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string mailbox = mbGrid.SelectedRows[0].Cells[1].Value.ToString();
                string path = @"C:\Program Files (x86)\Pronexus\VBVoice\BOX" + mailbox;
                string[] fileList = Directory.GetFiles(path, "*.vdm");
                foreach (string file in fileList)
                {
                    File.Delete(file);
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
