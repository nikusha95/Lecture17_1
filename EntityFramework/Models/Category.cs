using EntityFramework.Configurations;

namespace EntityFramework.Models;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Account> Accounts { get; set; }
}