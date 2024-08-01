using System.ComponentModel.DataAnnotations;

namespace TorahLibrary.Models
{
    public class Books
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="שם הספר")]
        public int name { get; set; }

        [Display(Name = "גובה")]
        public int Height { get; set; }
 
        public Shelves Shelve { get; set; }
    }
}
