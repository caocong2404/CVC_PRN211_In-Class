using Microsoft.EntityFrameworkCore;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp3;

namespace Services.Services
{
    public class BankAccountRepository : RepositoryBase<BankAccount>
    {
        BankAccountTypeContext _context;
        DbSet<BankAccount> _dbSet;
        public BankAccountRepository() {
            _context = new BankAccountTypeContext();
            _dbSet = _context.Set<BankAccount>();
        }

        public List<BankAccount> getAccountByBrand(string brandName)
        {
            var records = _dbSet.Where(entity => entity.BranchName.Contains(brandName)).ToList();
            return records;
        }

        public void Add(BankAccount bankAccount)
        {
            var lastRecord = _dbSet.OrderByDescending(record => record.AccountId).FirstOrDefault();
            if (lastRecord != null)
            {
                bankAccount.AccountId = autoGenerateID(lastRecord.AccountId);
            } else
            {
                bankAccount.AccountId = autoGenerateID("ACCT0000");
            }
            _dbSet.Add(bankAccount);
            _context.SaveChanges();
        }

        public string autoGenerateID(string id)
        {
            //ACCT0001
            string result = "";
            int cutID = int.Parse(id.Substring(4, 4));
            cutID++;
            int digits = 4;
            string prefix = "ACCT";
            
            // Convert the current ID to string with leading zeros
            string idString = cutID.ToString().PadLeft(digits, '0');
            result = prefix + idString;

            // Combine the prefix and the formatted ID
            return result;
        }

    }
}
