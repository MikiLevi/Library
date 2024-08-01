using System.ComponentModel.DataAnnotations;

namespace TorahLibrary.Models
{
    public class Libraries
    {
        //public Libraries()
        //{
        //    Shelv = new Shelves(); 
        //}

        [Key]   
        public int Id { get; set; }

        [Display(Name = "ז'אנר")]
        public string Name { get; set; }

        List<Shelves> shelves { get; set; }
    }
}
