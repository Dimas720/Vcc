using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vcc.Web.Data.Entities
{
    public class UserEntity : IdentityUser
    {
        public int IdUser { get; set; }

        [Display(Name = "Cédula")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} character")]
        [Required(ErrorMessage = "The field {0} is MANDATORY.")]
        public string Document { get; set; }

        [Display(Name ="First Name")]
        [MaxLength(50, ErrorMessage ="The {0} field can not have more than {1} character")]
        [Required(ErrorMessage ="The field {0} is MANDATORY.")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} character")]
        [Required(ErrorMessage = "The field {0} is MANDATORY.")]
        public string LastName { get; set; }

        [MaxLength(10, ErrorMessage = "The {0} field can not have more than {1} character")]
        [Required(ErrorMessage = "The field {0} is MANDATORY.")]
        public string Sex { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode =false)]
        [Required(ErrorMessage = "The field {0} is MANDATORY.")]
        public DateTime DateOfBirth { get; set; }

    }
}
