using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HRProgram
{
    public partial class FrmAddEditEmpolyee : Form
    {
        private int _employeeId;
        
        public FrmAddEditEmpolyee()
        {
            InitializeComponent();
            Text = "Dodaj Pracownika";
            _employeeId= 0;            
        }

        public FrmAddEditEmpolyee(int id)
        {
            InitializeComponent();
            Text = "Edytuj Pracownika";
            _employeeId =id ;
            tbIdEmployee.ReadOnly = true;
            GetDataToControles(_employeeId);
        }

        private void GetDataToControles(int employeeId)
        {
            var employees = FileHelper.GetEmployeesFromJSON();
            var empoloyee =  employees.Where(x=> x.Id==employeeId);
            tbIdEmployee.Text=empoloyee.FirstOrDefault().Id.ToString();
            tbEmployeeFirstName.Text=empoloyee.FirstOrDefault().FirstName;
            tbEmployeeLastName.Text = empoloyee.FirstOrDefault().LastName;
            tbWages.Text = empoloyee.FirstOrDefault().Wages.ToString();
            rtbComments.Text = empoloyee.FirstOrDefault().Comments;
            dtpDateOfEmployment.Value = empoloyee.FirstOrDefault().DateOfEmployment.Date;
            cbIsEmployed.Checked=empoloyee.FirstOrDefault().IsEmployed;
            if (empoloyee.FirstOrDefault().IsEmployed)
                dtpDateOfFired.Visible = false;
            else
                dtpDateOfFired.Visible = true;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            var employees = FileHelper.GetEmployeesFromJSON();

            if (employees is null ) { employees = new List<Employee>(); }

            if (_employeeId == 0)
                AddNewEmployee(employees);
            else
            {
                EditEmployee(employees, _employeeId);
            }

            FileHelper.SerializeJSON(employees);
            Close();
        }

        private  void  AddNewEmployee(List<Employee> employees)
        {
            var employee = new Employee
            {
                Id = int.Parse(tbIdEmployee.Text),
                FirstName = tbEmployeeFirstName.Text,
                LastName = tbEmployeeLastName.Text,
                Comments = rtbComments.Text,
                Wages = decimal.Parse(tbWages.Text),
                DateOfEmployment = dtpDateOfEmployment.Value,
                IsEmployed = cbIsEmployed.Checked
            };
                        employees.Add(employee);
        }

   

        public void EditEmployee(List<Employee> employees, int id)
        {
            var employeeToEdit = employees.FirstOrDefault(x => x.Id==id);

            employeeToEdit.FirstName = tbEmployeeFirstName.Text;
            employeeToEdit.LastName = tbEmployeeLastName.Text;
            employeeToEdit.Comments = rtbComments.Text;
            employeeToEdit.Wages = decimal.Parse(tbWages.Text);
            employeeToEdit.DateOfEmployment = dtpDateOfEmployment.Value;
            employeeToEdit.IsEmployed = cbIsEmployed.Checked;
        }

    }
}
