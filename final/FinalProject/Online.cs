class Online: Receipt
{
    private float _shipping;
    private float _tax;
    public int FindTax()
    {
        return 1;
    }
    public override float FindTotal()
    {
        return 1;
    }
    public override void DisplayReciept()
    {
        
    }
}