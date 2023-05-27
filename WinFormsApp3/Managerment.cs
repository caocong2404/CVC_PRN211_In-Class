using Services.Models;
using Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp3
{
    public partial class Managerment : Form
    {
        BankAccountRepository _bankAccountRepository;
        UserRepository _userRepository;
        AccountTypeRepository _accountTypeRepository;

        List<Student> listStudent = new List<Student>();
        int pre_ID;
        public Managerment()
        {
            _bankAccountRepository = new BankAccountRepository();
            _userRepository = new UserRepository();
            _accountTypeRepository = new AccountTypeRepository();
            InitializeComponent();
            var bankAccountList = _bankAccountRepository.GetAll();

            /*
            for (int i = 0; i < 10; i++)
            {
                var student = new Student();
                //student.Id = Guid.NewGuid();
                student.Name = "Nguyen Van " + i.ToString();
                student.Age = 15 + i;
                //student.Date = DateTime.Now;

                listStudent.Add(student);
            }
            */
            //gọi grid view để show ra
            dgvListStudent.DataSource = new BindingSource()
            {
                DataSource = bankAccountList
            };

            var listAccountType = _accountTypeRepository.GetAll();
            cBTypeName.DataSource = listAccountType;
            cBTypeName.DisplayMember = "TypeName";
        }

        private void txtManagerment_Click(object sender, EventArgs e)
        {

        }

        private void dgvListStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string name = txtAccountName.Text;
            string brand = txtBrandName.Text;
            if (name.Length <= 0 || brand.Length <= 0)
            {
                MessageBox.Show("Textbox can not empty", "Thong bao", MessageBoxButtons.OK);
                return;
            }
            var bankAccount = new BankAccount();
            bankAccount.AccountName = name;
            bankAccount.BranchName = brand;
            bankAccount.OpenDate = DateTime.Now;
            //get account type name
            AccountType accountType = cBTypeName.SelectedItem as AccountType;
            
                bankAccount.TypeId = accountType.TypeId;
       
            _bankAccountRepository.Add(bankAccount);
            var bankAccountList = _bankAccountRepository.GetAll();

            dgvListStudent.DataSource = new BindingSource()
            {
                DataSource = bankAccountList
            };
            /*
            string name = txtName.Text;
            int age = 0;
            if (txtAge.Text.Length <= 0 || txtName.Text.Length <= 0)
            {
                MessageBox.Show("Textbox can not empty", "Thong bao", MessageBoxButtons.OK);
                return;
            }
            try
            {
                age = int.Parse(txtAge.Text);
            }
            catch
            {
                MessageBox.Show("Age must be a word", "Thong bao", MessageBoxButtons.OK);
                txtName.Text = "";
                txtAge.Text = "";
                return;
            }
            if (age <= 0)
            {
                MessageBox.Show("Age must be more than 0", "Thong bao", MessageBoxButtons.OK);
                return;
            }

            var student = new Student();
            //student.Id = listStudent.Count;
            student.Name = name;
            student.Age = age;
            //student.Date = DateTime.Now;

            listStudent.Add(student);

            dgvListStudent.DataSource = new BindingSource()
            {
                DataSource = listStudent
            };
            */

        }

        private int rowIndex { get; set; }
        private void dgvListStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //chuột đang click ở dòng nào
            rowIndex = e.RowIndex;
            var student = listStudent[e.RowIndex];
            txtID.Text = student.Id.ToString();
            txtName.Text = student.Name.ToString();
            txtAge.Text = student.Age + "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Do you want do delete column?",
                "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }
            var listAccount = _bankAccountRepository.GetAll();
            var account = listAccount[rowIndex];
            _bankAccountRepository.Delete(account);
            MessageBox.Show("Delete successfull");
            listAccount = _bankAccountRepository.GetAll();
            dgvListStudent.DataSource = new BindingSource()
            {
                DataSource = listAccount
            };
            /*
            listStudent.Remove(listStudent[rowIndex]);

            dgvListStudent.DataSource = new BindingSource()
            {
                DataSource = listStudent
            };
            txtName.Text = "";
            txtAge.Text = "";
            */
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //chuột đang click ở dòng nào
            //listStudent[rowIndex].Name = txtName.Text;
            //listStudent[rowIndex].Age = int.Parse(txtAge.Text);
            var student = listStudent[rowIndex];
            if (txtAge.Text.Length <= 0 || txtName.Text.Length <= 0)
            {
                MessageBox.Show("Textbox can not empty", "Thong bao", MessageBoxButtons.OK);
                return;
            }

            try
            {
                student.Age = int.Parse(txtAge.Text);
            }
            catch
            {
                MessageBox.Show("Age must be a word", "Thong bao", MessageBoxButtons.OK);
                txtName.Text = "";
                txtAge.Text = "";
                return;
            }
            if (student.Age <= 0)
            {
                MessageBox.Show("Age must be more than 0", "Thong bao", MessageBoxButtons.OK);
                return;
            }
            student.Name = txtName.Text;

            dgvListStudent.DataSource = new BindingSource()
            {
                DataSource = listStudent
            };
            txtName.Text = "";
            txtAge.Text = "";

        }

        private Boolean isEmpty()
        {
            Boolean result = false;
            string name = txtName.Text;
            string age = txtAge.Text;
            if (String.IsNullOrEmpty(name) && String.IsNullOrEmpty(age))
            {
                MessageBox.Show("Textbox can not empty", "Thong bao", MessageBoxButtons.OK);
                return true;
            }
            return result;
        }

        private Boolean checkAge()
        {
            int age = 0;
            try
            {
                age = int.Parse(txtAge.Text);
            }
            catch
            {
                MessageBox.Show("Age must be a word", "Thong bao", MessageBoxButtons.OK);
                txtName.Text = "";
                txtAge.Text = "";
                return false;
            }
            if (age <= 0)
            {
                MessageBox.Show("Age must be more than 0", "Thong bao", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private Boolean checkDuplicatedName()
        {
            Boolean result = false;
            string name = txtName.Text;
            int age = int.Parse(txtAge.Text);
            if (name.Equals(listStudent[rowIndex].Name) && age == listStudent[rowIndex].Age)
                return result;
            result = true;
            return result;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchBrand = txtSearchBrand.Text;
            if (searchBrand.Length > 0)
            {
                var bankAccountList = _bankAccountRepository.getAccountByBrand(searchBrand);

                dgvListStudent.DataSource = new BindingSource()
                {
                    DataSource = bankAccountList
                };
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            var listAccount = _bankAccountRepository.GetAll();
            dgvListStudent.DataSource = new BindingSource()
            {
                DataSource = listAccount
            };
        }

        private void dgvListStudent_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //chuột đang click ở dòng nào
            rowIndex = e.RowIndex;
            var account = _bankAccountRepository.GetAll()[e.RowIndex];
            var typeID = account.TypeId;
            var accountType = _accountTypeRepository.GetAll().Where(entity => entity.TypeId.Equals(typeID)).FirstOrDefault();
            //_bankAccountRepository.Delete(account);

            txtBankAccountID.Text = account.AccountId.ToString();
            txtAccountName.Text = account.AccountName.ToString();
            txtBrandName.Text = account.BranchName.ToString();
            txtOpenDate.Text = account.OpenDate.ToString();
            if (accountType != null)
            {
                txtTypeID.Text = accountType.TypeDesc.ToString();
            }
            else
            {
                txtTypeID.Text = "None";
            }
        }

        private void cBTypeName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
