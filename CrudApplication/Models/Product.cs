using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudApplication.Models
{
    [Table("Produto")]
    public class Product
    {
        [Column("Id")]
        [Display(Name = "ProductID")]
        public int Id { get; set; }

        [Column("Name")]
        [Display(Name = "Name")]
        public string Name { get; set; }
    }
}
