using System.ComponentModel.DataAnnotations;

namespace FronToBack.Models
{
    public class ContactInfo
    { public int id { get; set; }
        [Required (ErrorMessage ="Daxil edilecek melumat bos burxilmamlidir.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Daxil edilecek melumat bos burxilmamlidir.")]
        public string Content { get; set; }
        [Required(ErrorMessage = "Daxil edilecek melumat bos burxilmamlidir.")]
        public string Description { get; set; }




    }
}
