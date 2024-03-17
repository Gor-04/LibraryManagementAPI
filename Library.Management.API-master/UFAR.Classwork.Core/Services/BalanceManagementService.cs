using System;
using System.Collections.Generic;
using System.Linq;
using UFAR.Classwork.Data.DAO;
using UFAR.Classwork.Data.Entities;

namespace UFAR.Classwork.Core.Services
{
    public class BalanceManagementService : IBalanceManagementService
    {
        private readonly ApplicationDbContext _context;

        public BalanceManagementService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddTransaction(TransactionEntity transaction)
        {
            _context.Transactions.Add(transaction);
            _context.SaveChanges();
        }

        public void UpdateTransaction(TransactionEntity transaction)
        {
            _context.Transactions.Update(transaction);
            _context.SaveChanges();
        }

        public void DeleteTransaction(int transactionId)
        {
            var transaction = _context.Transactions.Find(transactionId);
            if (transaction != null)
            {
                _context.Transactions.Remove(transaction);
                _context.SaveChanges();
            }
        }

        public TransactionEntity GetTransactionById(int transactionId)
        {
            return _context.Transactions.Find(transactionId);
        }

        public List<TransactionEntity> GetAllTransactions()
        {
            return _context.Transactions.ToList();
        }

        public List<TransactionEntity> GetTransactionsByLibraryId(int libraryId)
        {
            return _context.Transactions.Where(t => t.LibraryId == libraryId).ToList();
        }
    }
}
