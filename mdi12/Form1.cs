using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdi12
{
    public partial class MDIParent : Form
    {
        public MDIParent()
        {
            
            this.IsMdiContainer = true;
        }

        private void ShowChildForm(Form childForm)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close(); // Close any open children
            }

            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void btnContacts_Click(object sender, EventArgs e)
        {
            ShowChildForm(new ContactsForm());
        }

        private void btnSMS_Click(object sender, EventArgs e)
        {
            ShowChildForm(new SMSForm());
        }

        private void btnCalls_Click(object sender, EventArgs e)
        {
            ShowChildForm(new CallLogsForm());
        }

        private void btnDeviceInfo_Click(object sender, EventArgs e)
        {
            ShowChildForm(new DeviceInfoForm());
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


    }
    public partial class ContactsForm : Form
    {
        private DataGridView dataGridView1;

        public ContactsForm()
        {
            InitializeComponent();
            SetupGrid();
        }
        private void InitializeComponent()
        {
            this.Text = "Contacts";
            this.Size = new Size(600, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void SetupGrid()
        {
            dataGridView1 = new DataGridView();
            dataGridView1.Dock = DockStyle.Fill;
            this.Controls.Add(dataGridView1);
        }

        public void LoadData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Phone Number");

            dt.Rows.Add("Alice", "+1234567890");
            dt.Rows.Add("Bob", "+9876543210");

            dataGridView1.DataSource = dt;
        }

        public void SaveToDatabase()
        {
            MessageBox.Show("Contacts saved to database (mock).");
        }

        public void ViewReport()
        {
            MessageBox.Show("Contacts report generated (mock).");
        }
    }

    public partial class SMSForm : Form
    {
        private DataGridView dataGridView1;

        public SMSForm()
        {
            InitializeComponent();
            SetupGrid();
        }
        private void InitializeComponent()
        {
            this.Text = "SMS Messages";
            this.Size = new Size(600, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void SetupGrid()
        {
            dataGridView1 = new DataGridView();
            dataGridView1.Dock = DockStyle.Fill;
            this.Controls.Add(dataGridView1);
        }

        public void LoadData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Sender");
            dt.Columns.Add("Message");

            dt.Rows.Add("John", "Hi, how are you?");
            dt.Rows.Add("Bank", "Your OTP is 123456");

            dataGridView1.DataSource = dt;
        }

        public void SaveToDatabase()
        {
            MessageBox.Show("SMS messages saved to database (mock).");
        }

        public void ViewReport()
        {
            MessageBox.Show("SMS report generated (mock).");
        }
    }


    public partial class CallLogsForm : Form
    {
        private DataGridView dataGridView1;

        public CallLogsForm()
        {
            InitializeComponent();
            SetupGrid();
        }
        private void InitializeComponent()
        {
            this.Text = "Call Logs";
            this.Size = new Size(600, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void SetupGrid()
        {
            dataGridView1 = new DataGridView();
            dataGridView1.Dock = DockStyle.Fill;
            this.Controls.Add(dataGridView1);
        }

        public void LoadData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Caller");
            dt.Columns.Add("Type");
            dt.Columns.Add("Time");

            dt.Rows.Add("Alice", "Missed", "10:30 AM");
            dt.Rows.Add("Bob", "Received", "11:45 AM");

            dataGridView1.DataSource = dt;
        }

        public void SaveToDatabase()
        {
            MessageBox.Show("Call logs saved to database (mock).");
        }

        public void ViewReport()
        {
            MessageBox.Show("Call logs report generated (mock).");
        }
    }

    public partial class DeviceInfoForm : Form
    {
        private DataGridView dataGridView1; // Declare the DataGridView



        private void InitializeComponent()
        {
            this.Text = "Device Info";
            this.Size = new Size(600, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
        }



        private void SetupGrid()
        {
            dataGridView1 = new DataGridView();
            dataGridView1.Dock = DockStyle.Fill;
            this.Controls.Add(dataGridView1);
        }

        public void LoadData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Property");
            dt.Columns.Add("Value");

            dt.Rows.Add("Model", "Samsung Galaxy S21");
            dt.Rows.Add("OS", "Android 13");
            dt.Rows.Add("Battery", "80%");

            dataGridView1.DataSource = dt;
        }
       
        
            
    }


}
