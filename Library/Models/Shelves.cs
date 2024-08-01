using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TorahLibrary.Models
{
    public class Shelves
    {
        //public Shelves()
        //{
        //    Book = new Books();
        //}

        [Key]
        public int Id { get; set; }

        [Display(Name = "גובה")]
        public int Height { get; set; }

        [NotMapped]
        public int LiberyId { get; set; }


        public List<Shelves> shelves { get; set; }
    }
}