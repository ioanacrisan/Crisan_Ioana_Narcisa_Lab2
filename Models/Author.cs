using System.ComponentModel.DataAnnotations;

namespace Crisan_Ioana_Narcisa_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }

        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }

        [Display(Name = "Full Name")]
        public string AuthorFullName
        {
            get
            {
                return AuthorFirstName + " " + AuthorLastName;
            }
        }
        public ICollection<Book>? Books { get; set; } //navigation property

    }
}
