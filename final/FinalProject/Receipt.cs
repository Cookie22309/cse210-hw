abstract class Receipt
{
    private string _item;
    private float _price;
    private string _time;
    public string GetTime()
    {
        return _time;
    }
    public Receipt(string item, float price)
    {
        _item = item;
        _price = price;
        _time = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
    }
    public string GetItem()
    {
        return _item;
    }
    public float GetPrice()
    {
        return _price;
    }
    public abstract float FindTotal();
    public abstract void DisplayReciept();
}