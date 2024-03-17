using UFAR.Classwork.Data.Entities;

namespace UFAR.Classwork.Core.Services
{
    public interface IBalanceManagementService
    {
        void AddTransaction(TransactionEntity transaction);
        void UpdateTransaction(TransactionEntity transaction);
        void DeleteTransaction(int transactionId);

        TransactionEntity GetTransactionById(int transactionId);
        List<TransactionEntity> GetAllTransactions();

        List<TransactionEntity> GetTransactionsByLibraryId(int libraryId);




    }
}
