namespace ITCS_3112_Lab_1_Checkout.Domain;

public enum ItemStatus { AVAILABLE, CHECKED_OUT, LOST }
public enum ItemCategory { Laptop, VRHeadset, Sensor, Other }
public enum ItemCondition { Excellent, Good, Fair, Poor }

public class Item
{
    public string Id { get; }
    public string Name { get; set; }
    public string Category { get; set; }
    public string Condition { get; set; }
    public ItemStatus Status { get; private set; }

    public Item(string id, string name, string category, string condition, ItemStatus status = ItemStatus.AVAILABLE)
    {
        Id = id;
        Name = name;
        Category = category;
        Condition = condition;
        Status = status;
    }

    public void CheckOut()
    {
        if (Status != ItemStatus.AVAILABLE)
            throw new InvalidOperationException($"Item {Id} cannot be checked out. Current status: {Status}");
        Status = ItemStatus.CHECKED_OUT;
    }

    public void Return()
    {
        if (Status != ItemStatus.CHECKED_OUT)
            throw new InvalidOperationException($"Item {Id} cannot be returned. Current status: {Status}");
        Status = ItemStatus.AVAILABLE;
    }

    public void MarkAsLost() => Status = ItemStatus.LOST;

    public override string ToString() => $"{Id} | {Name} | {Category} | {Status}";
}
