class Donation: Receipt
{
    public Donation(string item, float price): base(item, price)
    {
        
    }
    public override float FindTotal()
    {
        return GetPrice();
    }
    public override void DisplayReciept()
    {
        Console.WriteLine($"===== DONATION RECEIPT =====\n\nItem: {GetItem()}\nPrice: {GetPrice()}\nTotal: {FindTotal()}\nPurchased At: {GetTime()}\n==========================");
    }
}