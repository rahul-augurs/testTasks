using System;
using System.IO;
using Test_Task_Domain;
using Test_Task_Domain.Infrastructure;
using Test_Task_Domain.Models;

namespace GoGreen.Domain.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _dbContext;

        public UnitOfWork(ApplicationDbContext _dbContext)
        {

            this._dbContext = _dbContext;
            //this._dbContext.Database.Log = logInfo => FileLogger.Log(logInfo);
        }

        public IRepository<User> User_Repository
        {
            get
            {
                return (new BaseRepository<User>(_dbContext));
            }
        }
   

        public int Commit()
        {
            return _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            //_dbContext.Database.Log = Console.Write;
            if (_dbContext != null)
                _dbContext.Dispose();
        }
        public ApplicationDbContext Init()
        {
            return _dbContext;
        }
       
    }

    //public class FileLogger
    //{
    //    public static void Log(string logInfo)
    //    {
    //        try
    //        {
    //            File.AppendAllText(@"C:\Users\Rohan\Desktop\Logger.txt", HttpContextExtensions.GetIpAddress());
    //            File.AppendAllText(@"C:\Users\Rohan\Desktop\Logger.txt", logInfo);
    //        }
    //        catch (Exception ex)
    //        {

    //        }
    //    }
    //}
}
