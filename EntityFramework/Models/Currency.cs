namespace EntityFramework.Models;

public class Currency
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Account> Accounts { get; set; }
}