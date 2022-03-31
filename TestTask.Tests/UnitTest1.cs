using System.Collections.Generic;
using Test_Task_DTO.UserMaster;
using Test_Task_Service.Repository;
using Xunit;

namespace TestTask.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string status = "active";

            UserRepository userRepository = new UserRepository();

          List<UserMasterViewModel> viewModel = new List<UserMasterViewModel>();
            viewModel.Add(new UserMasterViewModel { Id = 3313, Name = "Rev. Lai Nehru", Email = "lai_rev_nehru@becker-pacocha.name", Gender = "female", Status = "active" });
            viewModel.Add(new UserMasterViewModel
            {
                Id = 3308,
                Name = "Dr. Dinkar Kaul",
                Email = "kaul_dinkar_dr@schmidt.info",
                Gender = "female",
                Status = "active"
            });
            viewModel.Add(new UserMasterViewModel {
                Id = 3307,
                Name = "Udit Kapoor",
                Email = "udit_kapoor@lemke-haley.co",
                Gender = "male",
                Status = "active"
            });
            viewModel.Add(new UserMasterViewModel {
                Id = 3306,
                Name = "Gov. Pushti Nayar",
                Email = "nayar_pushti_gov@marquardt.org",
                Gender = "female",
                Status = "active"
            });
            viewModel.Add(new UserMasterViewModel {
                Id = 3304,
                Name = "Aanandinii Nambeesan",
                Email = "nambeesan_aanandinii@nicolas.io",
                Gender = "male",
                Status = "active"
            });
            viewModel.Add(new UserMasterViewModel {
                Id = 3302,
                Name = "Garud Khatri",
                Email = "garud_khatri@mccullough-mayert.org",
                Gender = "male",
                Status = "active"
            });
            viewModel.Add(new UserMasterViewModel {
                Id = 3300,
                Name = "Kanishka Nehru",
                Email = "nehru_kanishka@schultz-spencer.name",
                Gender = "male",
                Status = "active"
            });
            viewModel.Add(new UserMasterViewModel {
                Id = 3299,
                Name = "Sunita Chattopadhyay DVM",
                Email = "chattopadhyay_dvm_sunita@hartmann-hane.net",
                Gender = "female",
                Status = "active"
            });
            viewModel.Add(new UserMasterViewModel {
                Id = 3298,
                Name = "Devesh Shah",
                Email = "devesh_shah@hane.io",
                Gender = "male",
                Status = "active"
            });
            viewModel.Add(new UserMasterViewModel {

                Id = 3297,
                Name = "Pres. Devika Varrier",
                Email = "pres_devika_varrier@lowe-botsford.biz",
                Gender= "male",
                Status = "active"
            });
            viewModel.Add(new UserMasterViewModel {
                Id = 3296,
                Name = "Eshita Nambeesan",
                Email = "nambeesan_eshita@schowalter.info",
                Gender = "male",
                Status = "active"
            });
            viewModel.Add(new UserMasterViewModel {
                Id = 3295,
                Name = "Rajiv Achari",
                Email = "rajiv_achari@ledner-barton.co",
                Gender = "male",
                Status = "active"
            });
            viewModel.Add(new UserMasterViewModel {
                Id = 3294,
                Name = "Himani Achari",
                Email = "himani_achari@schaefer.biz",
                Gender = "female",
                Status = "active"
            });
            viewModel.Add(new UserMasterViewModel
            {
                Id = 3292,
                Name = "Nimit Talwar",
                Email = "nimit_talwar@stokes.com",
                Gender = "male",
                Status = "active"
            });



            var a = userRepository.GetByStatus(status);
            Assert.NotEqual(viewModel, a);
        }

        [Fact]
        public void Test2()
        {
            string email = "nimit_talwar@stokes.com";
            List<UserMasterViewModel> viewModel = new List<UserMasterViewModel>();
            viewModel.Add(new UserMasterViewModel
            {
                Id = 3292,
                Name = "Nimit Talwar",
                Email = "nimit_talwar@stokes.com",
                Gender = "male",
                Status = "active"
            });

            UserRepository userRepository = new UserRepository();

            var a = userRepository.GetByEmail(email);

            Assert.NotEqual(viewModel, a);

        }
    }
}