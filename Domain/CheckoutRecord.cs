namespace ITCS_3112_Lab_1_Checkout.Domain;

public class CheckoutRecord
{
    public string RecordId { get; }
    public Item Item { get; }
    public Borrower Borrower { get; }
    public DateTime CheckoutDate { get; }
    public DateTime DueDate { get; }
    public DateTime? ReturnDate { get; private set; }
    public bool IsActive => ReturnDate == null;

    public CheckoutRecord(string recordId, Item item, Borrower borrower, DateTime checkoutDate, DateTime dueDate)
    {
        RecordId = recordId;
        Item = item;
        Borrower = borrower;
        CheckoutDate = checkoutDate;
        DueDate = dueDate;
    }

    public void RecordReturn(DateTime returnDate)
    {
        if (!IsActive)
            throw new InvalidOperationException($"Record {RecordId} is already closed.");
        ReturnDate = returnDate;
    }

    public override string ToString() =>
        $"[{RecordId}] {Item.Id} → {Borrower.Name} | Due: {DueDate:yyyy-MM-dd}" +
        (IsActive ? "" : $" | Returned: {ReturnDate:yyyy-MM-dd}");
}
