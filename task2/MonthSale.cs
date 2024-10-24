namespace task2;

public class MonthSale
{
    public MonthSale(int sales, string date)
    {
        Sales = sales;
        Date = date;
    }

    public int Sales {  get; set; }
    public string Date { get; set; }    
}
