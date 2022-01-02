using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HRProgram
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            
            RefreshData();
            ColumnNames();
            FiltrData();

        }


        private void FiltrData()
        {
            List<string> group = new List<string> {"Wszyscy", "Zatrudnieni", "Zwolnieni"};
            cmbEmployeeGroup.DataSource= group;
        }
        private void ColumnNames()
        {
            dgvEmpolyees.Columns[0].HeaderText="Numer pracownika";
            dgvEmpolyees.Columns[1].HeaderText = "Imię";
            dgvEmpolyees.Columns[2].HeaderText = "Nazwisko";
            dgvEmpolyees.Columns[3].HeaderText = "Data zatrudnienia";
            dgvEmpolyees.Columns[4].HeaderText = "Data zwolnienia";
            dgvEmpolyees.Columns[5].HeaderText = "Komenatrz";
            dgvEmpolyees.Columns[6].HeaderText = "Zarobki";
            dgvEmpolyees.Columns[7].HeaderText = "Czy zatrudniony";

        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            var addEditEmployee = new FrmAddEditEmpolyee();
            addEditEmployee.FormClosing+= AddEditEmployee_FormClosing;
            addEditEmployee.Show();
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            var index =int.Parse(dgvEmpolyees.SelectedRows[0].Cells[0].Value.ToString());
            var addEditEmployee = new FrmAddEditEmpolyee(index);
            addEditEmployee.FormClosing += AddEditEmployee_FormClosing;
            addEditEmployee.Show();
        }

        private void AddEditEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            RefreshData();
        }


        public void RefreshData()
        {
            var list = FileHelper.GetEmployeesFromJSON();

            if (cmbEmployeeGroup.SelectedIndex == 1)
                list = list.Where(x => x.IsEmployed == true).ToList();
            else if (cmbEmployeeGroup.SelectedIndex == 2)
                list = list.Where(x => x.IsEmployed == false).ToList();
            dgvEmpolyees.DataSource = list;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if
                (!int.TryParse(dgvEmpolyees.SelectedRows[0].Cells[0].Value.ToString(), out int index))
            {
                MessageBox.Show("Wybierz wiersz do usuniecia");
            }
            else
                index = int.Parse(dgvEmpolyees.SelectedRows[0].Cells[0].Value.ToString());
            
            var list = FileHelper.GetEmployeesFromJSON();

           var userAnswer= MessageBox.Show("Usunąć pracownika?","Usuń rekord z listy",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (userAnswer == DialogResult.Yes)
            {
                list.RemoveAll(x => x.Id == index);
                FileHelper.SerializeJSON(list);
                RefreshData();
            }
        }

        private void btnDismiss_Click(object sender, EventArgs e)
        {
            if
               (!int.TryParse(dgvEmpolyees.SelectedRows[0].Cells[0].Value.ToString(), out int index))
            {
                MessageBox.Show("Wybierz pracownika do zwolnienia");
            }
            else
                index = int.Parse(dgvEmpolyees.SelectedRows[0].Cells[0].Value.ToString());

            var list = FileHelper.GetEmployeesFromJSON();

            var userAnswer = MessageBox.Show("Zwolnić pracownika?", "Zwolnij pracownika", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (userAnswer == DialogResult.Yes)
            {
                list.Where(x => x.Id==index).FirstOrDefault().DateOfDismissal=DateTime.Now.Date;
                list.Where(x => x.Id == index).FirstOrDefault().IsEmployed = false;
                FileHelper.SerializeJSON(list);
                RefreshData();
            }

        }

 
    }
}
