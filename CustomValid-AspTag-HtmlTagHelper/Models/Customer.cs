using CustomValid_AspTag_HtmlTagHelper.CustomValidations;
using System.ComponentModel.DataAnnotations;

namespace CustomValid_AspTag_HtmlTagHelper.Models
{
    public class Customer
    {
        
        [Display(Name="ID")]
        public int CustomerID { get; set; }

        [Display(Name = "Company Name")]
        [Required(ErrorMessage ="Company name is mandatory.")]
        [StringLength(50,ErrorMessage ="Company Name should be less than or equal to fifty characters.")]
        public string CompanyName { get; set; }


        //[EmailAddress]
        [Display(Name = "E-Mail")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please enter a valid e-mail adress")]
        //regex ile mail kontrolü.
        [Required]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]
        [JoinDateValidation(ErrorMessage= "Join Date cannot be greater than current date")]
       
        public DateTime JoinDate { get; set; }

        [Required]
        [Range(20,40,ErrorMessage ="Customer age should be in 20 to 40 range")]
        [AgeValidation]
        public int Age { get; set; }

        [EnumDataType(typeof(CustomerType),ErrorMessage ="Customer type is not valid.")]
        public CustomerType CustomerType { get; set; }

    }
    public enum CustomerType
    {
        New=0,
        Regular,
        Elite
    }
}
