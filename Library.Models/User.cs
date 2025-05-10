using System.ComponentModel.DataAnnotations.Schema;

namespace IceLibrary.Library.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? NationalCode { get; set; }

        [ForeignKey("Id")]
        public Admin? Admin { get; set; }

    }
}
