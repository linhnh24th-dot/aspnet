using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Database.Interfaces;

namespace Core.Database.Models
{
    [Table("Category")]
    public class Category : IAuditable 
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(150)]
        public string? Name { get; set; }
        [ForeignKey("ParenId")]
        public Guid? ParenId { get; set; }
        public Category? Parent {  get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public ICollection<Product> Products { get; set; } = new HashSet<Product>();
        public ICollection<Category> ChildCategories { get; set; } = new HashSet<Category>();
        public ICollection<Role> Roles { get; set; } = new HashSet<Role>();
    }
}
