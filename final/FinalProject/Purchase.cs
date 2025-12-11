class Purchase
{
    private Customer _customer;
    private Item _item;
    private Receipt _receipt;
    public Purchase(Customer customer, Item item, Receipt receipt)
    {
        _customer = customer;
        _item = item;
        _receipt = receipt;
    }
    public void DisplayPurchase()
    {
        Console.WriteLine($"\n===== PURCHASE =====\nCustomer: {_customer.GetName()}\nEmail:    {_customer.GetEmail()}\nItem:     {_item.GetItem()}\nPrice:    {_item.GetPrice()}\n");
        _receipt.DisplayReciept();
    }
}