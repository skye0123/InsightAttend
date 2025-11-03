using System;
using System.Windows.Forms;

namespace InsightAttend
{
    public class MainForm : Form
    {
        private Button btnEmployees, btnRecord, btnReports, btnExit;
        private ListView lvEmployees;

        public MainForm()
        {
            Text = "InsightAttend - Dashboard";
            Width = 800;
            Height = 600;
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            btnEmployees = new Button(){ Left = 20, Top = 20, Width = 150, Text = "Manage Employees" };
            btnRecord = new Button(){ Left = 190, Top = 20, Width = 150, Text = "Record Attendance" };
            btnReports = new Button(){ Left = 360, Top = 20, Width = 150, Text = "Reports" };
            btnExit = new Button(){ Left = 530, Top = 20, Width = 100, Text = "Exit" };
            btnExit.Click += (s,e) => Close();

            lvEmployees = new ListView(){ Left = 20, Top = 70, Width = 740, Height = 460, View = View.Details, FullRowSelect = true };
            lvEmployees.Columns.Add("ID", 50);
            lvEmployees.Columns.Add("Employee No", 120);
            lvEmployees.Columns.Add("First Name", 150);
            lvEmployees.Columns.Add("Last Name", 150);
            lvEmployees.Columns.Add("Department", 150);
            lvEmployees.Columns.Add("Role", 120);

            Controls.Add(btnEmployees);
            Controls.Add(btnRecord);
            Controls.Add(btnReports);
            Controls.Add(btnExit);
            Controls.Add(lvEmployees);
        }
    }
}
