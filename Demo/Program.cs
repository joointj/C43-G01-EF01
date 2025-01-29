using Demo.Data.Context;

namespace Demo;

class Program
{
    static void Main(string[] args)
    {
        #region Ways for mapping 1- by conviention
        //
        // using (MyCompanyDbContext dbContext = new MyCompanyDbContext())
        // {
        //        
        // } --> First way
        using MyCompanyDbContext dbContext = new MyCompanyDbContext(); // --> Second way
        // dbContext.Employees.Add(); // --> The way to add new employees 
        
        // 2 ways to apply difference to database 
        // 1- Code , ensure created , ensure deleted , ensure updated
        dbContext.Database.EnsureCreated(); // --> Create database if not exists also will drop the database and create new one 
        dbContext.Database.EnsureDeleted(); // --> Delete database if exists
        // 2- command [migrations]
        
        
    



        #endregion
    }
}