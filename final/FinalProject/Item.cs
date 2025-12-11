class Item
{
    private string _item;
    private float _price;
    public Item(string item, float price)
    {
        _item = item;
        _price = price;
    }
    public string GetItem()
    {
        return _item;
    }
    public float GetPrice()
    {
        return _price;
    }
}