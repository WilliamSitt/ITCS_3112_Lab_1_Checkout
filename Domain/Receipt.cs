namespace ITCS_3112_Lab_1_Checkout.Domain;

public enum ReceiptType { Checkout, Return }

public class Receipt
{
    public string RecordId { get; }
    public ReceiptType Type { get; }
    public string ItemId { get; }
    public string ItemName { get; }
    public string BorrowerName { get; }
    public string BorrowerEmail { get; }
    public DateTime TransactionDate { get; }
    public DateTime? DueDate { get; }
    public DateTime? ReturnDate { get; }

    public Receipt(string recordId, string itemId, string itemName,
                   string borrowerName, string borrowerEmail,
                   DateTime checkoutDate, DateTime dueDate)
    {
        RecordId = recordId;
        Type = ReceiptType.Checkout;
        ItemId = itemId;
        ItemName = itemName;
        BorrowerName = borrowerName;
        BorrowerEmail = borrowerEmail;
        TransactionDate = checkoutDate;
        DueDate = dueDate;
    }

    public Receipt(string recordId, string itemId, string itemName,
                   string borrowerName, string borrowerEmail,
                   DateTime returnDate)
    {
        RecordId = recordId;
        Type = ReceiptType.Return;
        ItemId = itemId;
        ItemName = itemName;
        BorrowerName = borrowerName;
        BorrowerEmail = borrowerEmail;
        TransactionDate = returnDate;
        ReturnDate = returnDate;
    }

    public override string ToString() => Type == ReceiptType.Checkout
        ? $"CHECKOUT | {ItemId} | {BorrowerName} | Due: {DueDate:yyyy-MM-dd}"
        : $"RETURN   | {ItemId} | {BorrowerName} | Returned: {ReturnDate:yyyy-MM-dd}";
}
