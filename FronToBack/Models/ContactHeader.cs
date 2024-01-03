using System.ComponentModel.DataAnnotations;

namespace FronToBack.Models
{
    public class ContactHeader
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Daxil edilmeli olan saheni bos buraxmayin")]
        public string WorkTitle { get; set; }
        [Required(ErrorMessage = "Daxil edilmeli olan saheni bos buraxmayin")]
        public string Name { get; set; }
        [Required,DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
    }
}
