using System.ComponentModel.DataAnnotations;

namespace ClubRegistration.Models
{
    #region -- Entities --
    public class Club
    {
        public int ID { get; set; } // Primary Keyng ina mo!
        public long StudentID { get; set; }
        public string? Program { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public int Age { get; set; }
        public string? Gender { get; set; }
    }
    #endregion
}
