class Online: Receipt
{
    private float _shipping;
    private float _tax;
    public Online(string item, float price, float shipping, float tax): base(item, price)
    {
        _shipping = shipping;
        _tax = tax;
    }
    public float FindTax()
    {
        return GetPrice() * _tax;
    }
    public override float FindTotal()
    {
        float taxTotal = FindTax();
        return GetPrice() + taxTotal + _shipping;
    }
    public override void DisplayReciept()
    {
        Console.WriteLine($"===== ONLINE RECEIPT =====\n\nItem: {GetItem()}\nPrice: {GetPrice()}\nTax: {FindTax()}\nShipping: {_shipping}\nTotal: {FindTotal()}\nPurchased At: {GetTime()}\n==========================");
    }
}