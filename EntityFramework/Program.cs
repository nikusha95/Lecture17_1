// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices.ComTypes;
using EntityFramework;
using EntityFramework.Models;

BankDbContext dbContext = new BankDbContext();

//var list =  dbContext.Accounts.Where(x => x.Balance > 10).ToList();
// await dbContext.Categories.AddAsync(new Category
// {
//     Name = "Credit"
// });
// await dbContext.SaveChangesAsync();

//add currency
// await dbContext.Currencies.AddAsync(new Currency
// {
//     Name = "GEL"
// });

//add multiple currency
// await dbContext.AddRangeAsync(new List<Currency>
// {
//     new()
//     {
//         Name = "USD"
//     },
//     new()
//     {
//         Name = "EUR"
//     }
// });
//
// await dbContext.SaveChangesAsync();
try
{
   //  await dbContext.Clients.AddAsync(new Client
   //  {
   //      FirstName = "name",
   //      LastName = "lastname",
   //      PersonalId = "123456789"
   //  });
   // await dbContext.SaveChangesAsync();
   var client  = dbContext.Clients.FirstOrDefault(x => x.Id == 2);
    await dbContext.Accounts.AddAsync(new Account
    {
        Balance = 100,
        CategoryId = 1,
        CurrencyId = 1,
        Client = client,
        ExpirationDate = DateTime.Now.AddYears(4),
        Iban = "GETB000124343"
    });

    await dbContext.SaveChangesAsync();
}
catch (Exception e)
{
    Console.WriteLine(e);
    throw;
}