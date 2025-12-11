using System.Numerics;

class Subscription: Receipt
{
    private int _months;
    private float _rate;
    private bool _paymentPlan;
    private string _plan;
    public Subscription(string item, float rate, int months, bool paymentPlan): base(item, rate)
    {
        _rate = rate;
        _months = months;
        _paymentPlan = paymentPlan;
    }
    public override float FindTotal()
    {
        if (_paymentPlan == true)
        {
            return _rate;
        }
        else
        {
            return _rate * _months;
        }
    }
    public string ReturnPlan()
    {
        if (_paymentPlan == true)
        {
            _plan = "Monthly";
            return _plan;
        }
        else
        {
            
            _plan = "Yearly";
            return _plan;
        }
    }
    public void SetMonths(int m)
    {
        _months = m; 
    }
    public void SetPaymentPlan(bool plan)
    {
        _paymentPlan = plan; 
    }
    public override void DisplayReciept()
    {
        Console.WriteLine($"===== SUBSCRIPTION RECEIPT =====\n\nSubscription: {GetItem()}\nRate:         ${_rate}\nMonths:       {_months}\nPlan:         {ReturnPlan()}\nTotal:        ${FindTotal()}\nPurchased At: {GetTime()}\n================================");
    }
}