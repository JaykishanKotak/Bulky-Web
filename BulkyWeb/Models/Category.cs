using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        // Mapped with db tables - use "prop" shortcut
        // Key annotation is use to give PK for table
        // Id or CategoryId Auto considered as PK
        [Key]
        public int Id { get; set; }
        // Required data annotation to give field required property
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }

        //PM> add-migration AddCategoryTableToDB
        // update-database

    }
}
