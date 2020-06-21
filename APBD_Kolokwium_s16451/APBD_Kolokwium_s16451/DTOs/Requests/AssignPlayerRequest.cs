using System;
using System.ComponentModel.DataAnnotations;

namespace APBD_Kolokwium_s16451.DTOs.Requests
{
    public class AssignPlayerRequest
    {
        [MaxLength(30)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        public string DateOfBirth { get; set; }

        public int NumOnShirt { get; set; }

        [MaxLength(300)]
        public string comment { get; set; }

        public DateTime GetBirthDate()
        {
            var split = DateOfBirth.Split('.');
            return new DateTime(int.Parse(split[2]), int.Parse(split[1]), int.Parse(split[0]));
        }
    }
}
