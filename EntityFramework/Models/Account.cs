namespace EntityFramework.Models;

public class Account
{
    public int Id { get; set; }
    public string Iban { get; set; }
    public decimal Balance { get; set; }
    public DateTime ExpirationDate { get; set; }
    public int CurrencyId { get; set; }
    public Currency Currency { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public int ClientId { get; set; }
    public Client Client { get; set; }
}