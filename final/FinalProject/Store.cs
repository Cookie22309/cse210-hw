class Store: Receipt
{
    private float _tax;
    public Store(string item, float price, float tax): base(item, price)
    {
        _tax = tax;
    }
    public float FindTax()
    {
        return GetPrice() * _tax;
    }
    public override float FindTotal()
    {
        float taxTotal = FindTax();
        return GetPrice() + taxTotal;
    }
    public override void DisplayReciept()
    {
        Console.WriteLine($"===== ONLINE RECEIPT =====\n\nItem: {GetItem()}\nPrice: {GetPrice()}\nTax: {FindTax()}\nTotal: {FindTotal()}\nPurchased At: {GetTime()}\n==========================");
    }
}