using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankTransactions.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        [Column(TypeName = "int(12)")]
        [DisplayName("Account Number")]
        [Required(ErrorMessage ="This field is required")]
        [MaxLength(12,ErrorMessage ="Maximun 12 characters only.")]
        public int AccountNumber { get; set; }

        [Column(TypeName = "varchar(100)")]
        [DisplayName("BeneficiaryName ")]
        [Required(ErrorMessage = "This field is required")]
        public string BeneficiaryName { get; set; }

        [Column(TypeName = "varchar(100)")]
        [DisplayName("BankName ")]
        [Required(ErrorMessage = "This field is required")]

        public string BankName { get; set; }
        [Column(TypeName = "varchar(11)")]
        [DisplayName("SWIFTCode ")]
        [Required(ErrorMessage = "This field is required")]
        [MaxLength(11, ErrorMessage = "Maximun 12 characters only.")]
        public string SWIFTCode { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }
    }
}

