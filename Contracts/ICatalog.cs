using ITCS_3112_Lab_1_Checkout.Domain;

namespace ITCS_3112_Lab_1_Checkout.Contracts;

public interface ICatalog
{
    List<Item> ListAvailable();
    List<Item> ListUnavailable();
    List<Item> ListAll();
    List<Item> SearchById(string itemId);
    List<Item> SearchByName(string keyword);
    List<Item> SearchByCategory(string category);
}
