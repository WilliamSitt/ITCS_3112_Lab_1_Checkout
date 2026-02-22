using ITCS_3112_Lab_1_Checkout.Domain;

namespace ITCS_3112_Lab_1_Checkout.Contracts;

public interface IPolicy
{
    bool CanCheckOut(Item item);
    int GetMaxLoanDays(Item item);
    bool IsDueDateValid(Item item, DateTime requestedDueDate);
}
