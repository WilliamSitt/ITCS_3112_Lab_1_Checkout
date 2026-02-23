using ITCS_3112_Lab_1_Checkout.Contracts;
using ITCS_3112_Lab_1_Checkout.Domain;
namespace ITCS_3112_Lab_1_Checkout.Repositories;

public class InMemoryRepository : IRepository
{
    private List<Item> _items;
    private List<CheckoutRecord> _records;
    
    public InMemoryRepository()
    {
        _items = new List<Item>();
    }
    public void AddItem(Item item)
    {
        _items.Add(item);
    }

    public Item? GetItem(string itemId)
    {
        Item result = null;
        foreach (Item item in _items)
        {
            if (item.Id == itemId)
            {
                result = item;
                break;
            }
        }
        return result;
    }

    public List<Item> GetAllItems()
    {
        return _items;
    }

    public void SaveRecord(CheckoutRecord record)
    {
        _records.Add(record);
    }

    public List<CheckoutRecord> GetRecordsByBorrower(string borrowerId)
    {
        CheckoutRecord result = null;
        foreach (CheckoutRecord record in _records)
        {
            if (record.Borrower.Id == borrowerId)
            {
                result = record;
                break;
            }
        }

        return result;
    }
    
    public List<CheckoutRecord> GetRecordsByItem(string itemId)
    {
        CheckoutRecord result = null;
        foreach (CheckoutRecord record in _records)
        {
            if (record.Item.Id == itemId)
            {
                result = record;
                break;
            }
        }
        return result;
    }

    public List<CheckoutRecord> GetAllRecords()
    {
        return _records;
    }
}