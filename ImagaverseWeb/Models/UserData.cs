using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ImagaverseWeb.Models
{
    public class UserData
    {
        public int UserID { get; set; }
        public UserLevel UserLevel { get; set; }

        public string Username { get; set; }
        [DataType(DataType.Password)]
        public string psd { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }



        public Gender Gender { get; set; }
        
        public DateTime CreatedDate { get; set; }
    }

    public enum Gender
    {
        Male,
        Female,
        NonBinary
    }
    public enum UserLevel
    {
        Owner,
        Admin,
        Dev,
        Mod,
        Verified,
        Unverified,
        Disabled,
        Deleted,
        Banned
    }
}
