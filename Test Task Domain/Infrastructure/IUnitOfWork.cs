using System;
using Test_Task_Domain;
using Test_Task_Domain.Infrastructure;
using Test_Task_Domain.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace GoGreen.Domain.Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<User> User_Repository { get; }
      
        int Commit();
        ApplicationDbContext Init();
    }
}
