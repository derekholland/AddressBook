using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AddressBook.Models
{
    public class Contact
    {
        //get and set gives the properties the ability to set their values and have their values retrieved
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        [DataType(DataType.PostalCode)]
        public int Zip { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        public DateTime Created { get; set; }

        //represents file a user has selected when creating a new contact
        [NotMapped]
        [Display(Name = "Image")]
        [DataType(DataType.Upload)]
        public IFormFile ImageFile { get; set; }
        //byte array data type 
        public byte[] ImageData { get; set; }

        public string ImageType { get; set; }

        //used for database primary key
        public int Id { get; set; }

        //data annotation, so it wont turn into a column like all the other properties
        [NotMapped]
        public string FullName { get { return $"{FirstName} {LastName}"; } }

    }
}
