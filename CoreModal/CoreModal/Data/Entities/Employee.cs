using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreModal.Data.Entities
{
    public class Employee
    {
        public int EmployeeID { get; set; }

        [Column(TypeName = "VARCHAR(30)")]
        [MaxLength(30, ErrorMessage = "The field {0} can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is required.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(30)")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(15)")]
        public string Title { get; set; }

        [Column(TypeName = "VARCHAR(70)")]
        [Required, DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string ContactEmail { get; set; }

        [Display(Name = "Hire Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime? HireDate { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(50)")]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(20)")]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(2)")]
        [Display(Name = "State")]
        public string State { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(6)")]
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }


        [Required]
        [Column(TypeName = "VARCHAR(15)")]
        [Display(Name = "Phone")]
        public string Phone { get; set; }

        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }

        [Display(Name = "Is Deleted?")]
        public bool IsDeleted { get; set; }

        [Column(TypeName = "VARCHAR(70)")]
        public string InputBy { get; set; }
        public DateTime? InputDate { get; set; }

        [Column(TypeName = "VARCHAR(70)")]
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        [Display(Name = "Name")]
        public string FullName => $"{LastName} {FirstName}";

       
    }
}
