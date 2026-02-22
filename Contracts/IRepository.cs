namespace ITCS_3112_Lab_1_Checkout.Contracts;

public interface IRepository
{
    void AddItem(Item item);
    Item? GetItem(string itemId);
    List<Item> GetAllItems();
    void SaveRecord(CheckoutRecord record);
    List<CheckoutRecord> GetRecordsByBorrower(string borrowerId);
    List<CheckoutRecord> GetRecordsByItem(string itemId);
    List<CheckoutRecord> GetAllRecords();
}
