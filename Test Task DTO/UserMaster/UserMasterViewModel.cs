using System.ComponentModel.DataAnnotations;

namespace Test_Task_DTO.UserMaster
{
    public class UserMasterViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Required Field.")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Required Field.")]
        public string? Email { get; set; }
        public string? Gender { get; set; }
        public string? Status { get; set; }

    }
}
