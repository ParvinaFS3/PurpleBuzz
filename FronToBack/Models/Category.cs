using System.ComponentModel.DataAnnotations;

namespace FronToBack.Models
{
    public class Category



    { public int Id { get; set; }
        [Required(ErrorMessage ="Ad mutleq yazilmalidir"),MinLength(3,ErrorMessage ="Uzunluq 3-den az olmamaldir")]
        public string Title { get; set; }
        public List<CategoryComponent>? CategoryComponents { get; set; }
    }
}
