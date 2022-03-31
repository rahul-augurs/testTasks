using Test_Task_DTO.UserMaster;

namespace Test_Task_Service.IRepository
{
    public interface IUserRepository
    {
        
        public List<UserMasterViewModel> GetByStatus(string status);
        public List<UserMasterViewModel> GetByStatusandGender(string status,string gender);

        public List<UserMasterViewModel> GetByEmail(string email);
        
    }
}
