namespace ITCS_3112_Lab_1_Checkout.Contracts;

public interface ICheckoutService
{
    ICatalog GetCatalog();
    Receipt Checkout(string itemId, Borrower borrower, DateTime dueDate);
    Receipt ReturnItem(string itemId);
    void MarkLost(string itemId);
    List<CheckoutRecord> ListActiveLoans();
    List<CheckoutRecord> FindDueSoon(TimeSpan window);
    List<CheckoutRecord> FindOverdue();
}
