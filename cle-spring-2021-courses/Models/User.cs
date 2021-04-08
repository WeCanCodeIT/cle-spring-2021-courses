using cle_spring_2021_courses.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cle_spring_2021_courses.Models
{
    public class User
    {
        private string _password;
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        [MinLength(6)]
        public string Password
        {
            get { return _password; }
            set
            {
                _password = Helper.EncryptPassword(value);
            }
        }

        public string Hometown { get; set; }

        [RegularExpression("([^\\s]+(\\.(?i)(jpg|png|gif|bmp))$)")]
        public string ProfilePic { get; set; }

    }

    
}
