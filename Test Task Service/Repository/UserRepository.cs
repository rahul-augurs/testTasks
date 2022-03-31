using GoGreen.Domain.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Task_Domain;
using Test_Task_DTO.UserMaster;
using Test_Task_Service.IRepository;

namespace Test_Task_Service.Repository
{
    public class UserRepository : IUserRepository
    {
        // private readonly IMapper mapper;
        

        public List<UserMasterViewModel> GetByStatus(string status)
        {
            List<UserMasterViewModel> users = APICall.Get();
            users = users.Where(a => a.Status == status).ToList();
            return users;
        }

        public List<UserMasterViewModel> GetByStatusandGender(string status, string gender)
        {
            List<UserMasterViewModel> users = APICall.Get();
            users = users.Where(a => a.Status == status && a.Gender == gender).ToList();
            return users;
        }

        public List<UserMasterViewModel> GetByEmail(string email)
        {
            List<UserMasterViewModel> users = APICall.Get();
            users = users.Where(a => a.Email == email).ToList();
            return users;
        }

    }
}
