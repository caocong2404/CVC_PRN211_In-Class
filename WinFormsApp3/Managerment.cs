﻿using Services.Models;
using Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
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

        private int rowIndex { get; set; }

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
            if (int.TryParse(name, out int checkName))
            {
                MessageBox.Show("Account name can not be number", "Thong bao", MessageBoxButtons.OK);
                return;
            }

            if (int.TryParse(brand, out int checkBrand))
            {
                MessageBox.Show("Brand name can not be number", "Thong bao", MessageBoxButtons.OK);
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

        private void dgvListStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //chuột đang click ở dòng nào
            var accountID = dgvListStudent[0, e.RowIndex].Value;
            var account = _bankAccountRepository.GetAll().Where(entity => entity.AccountId.Equals(accountID)).FirstOrDefault();
            if (account == null)
                return;

            rowIndex = e.RowIndex;
            var typeID = account.TypeId;
            var accountType = _accountTypeRepository.GetAll().Where(entity => entity.TypeId.Equals(typeID)).FirstOrDefault();
            //_bankAccountRepository.Delete(account);
            cBTypeName.Text = accountType.TypeName;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Do you want do delete column?",
                "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }
            var accountID = dgvListStudent[0, rowIndex].Value;
            var account = _bankAccountRepository.GetAll().Where(entity => entity.AccountId.Equals(accountID)).FirstOrDefault();
            //var listAccount = _bankAccountRepository.GetAll();
            //var account = listAccount[rowIndex];
            _bankAccountRepository.Delete(account);
            MessageBox.Show("Delete successfull");
            var listAccount = _bankAccountRepository.GetAll();
            dgvListStudent.DataSource = new BindingSource()
            {
                DataSource = listAccount
            };
            txtBankAccountID.Text = "";
            txtAccountName.Text = "";
            txtBankAccountID.Text = "";
            txtBrandName.Text = "";
            txtOpenDate.Text = "";
            txtTypeID.Text = "";


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
            var listAccount = _bankAccountRepository.GetAll();
            var name = txtAccountName.Text;
            var brand = txtBrandName.Text;

            if (txtAccountName.Text.Length <= 0 || txtBrandName.Text.Length <= 0)
                if (name.Length <= 0 || brand.Length <= 0)
                {
                    MessageBox.Show("Textbox can not empty", "Thong bao", MessageBoxButtons.OK);
                    return;
                }
            if (int.TryParse(name, out int checkName))
            {
                MessageBox.Show("Account name can not be number", "Thong bao", MessageBoxButtons.OK);
                return;
            }

            if (int.TryParse(brand, out int checkBrand))
            {
                MessageBox.Show("Brand name can not be number", "Thong bao", MessageBoxButtons.OK);
                return;
            }

            listAccount[rowIndex].AccountName = txtAccountName.Text;
            listAccount[rowIndex].BranchName = txtBrandName.Text;

            //get type name to type ID
            AccountType accounType = cBTypeName.SelectedItem as AccountType;
            var accountType = _accountTypeRepository.GetAll().Where(entity => entity.TypeName.Equals(accounType.TypeName)).FirstOrDefault();
            listAccount[rowIndex].TypeId = accountType.TypeId;
            var bankAccountUpdate = listAccount[rowIndex];
            //update
            _bankAccountRepository.Update(bankAccountUpdate);

            dgvListStudent.DataSource = new BindingSource()
            {
                DataSource = listAccount
            };
            txtAccountName.Text = "";
            txtBrandName.Text = "";


            //var student = listStudent[rowIndex];
            //if (txtAge.Text.Length <= 0 || txtName.Text.Length <= 0)
            //{
            //    MessageBox.Show("Textbox can not empty", "Thong bao", MessageBoxButtons.OK);
            //    return;
            //}

            //try
            //{
            //    student.Age = int.Parse(txtAge.Text);
            //}
            //catch
            //{
            //    MessageBox.Show("Age must be a word", "Thong bao", MessageBoxButtons.OK);
            //    txtName.Text = "";
            //    txtAge.Text = "";
            //    return;
            //}
            //if (student.Age <= 0)
            //{
            //    MessageBox.Show("Age must be more than 0", "Thong bao", MessageBoxButtons.OK);
            //    return;
            //}
            ////chuột đang click ở dòng nào
            ////listStudent[rowIndex].Name = txtName.Text;
            ////listStudent[rowIndex].Age = int.Parse(txtAge.Text);
            //student.Name = txtName.Text;

            //dgvListStudent.DataSource = new BindingSource()
            //{
            //    DataSource = listStudent
            //};
            //txtName.Text = "";
            //txtAge.Text = "";

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

        }

        private void Managerment_ContextMenuStripChanged(object sender, EventArgs e)
        {
            
        }
    }
}
