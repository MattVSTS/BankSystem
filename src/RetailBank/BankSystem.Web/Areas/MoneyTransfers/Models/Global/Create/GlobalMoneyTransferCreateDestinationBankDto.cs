namespace BankSystem.Web.Areas.MoneyTransfers.Models.Global.Create
{
    using System.ComponentModel.DataAnnotations;
    using Common;

    public class GlobalMoneyTransferCreateDestinationBankDto
    {
        [MaxLength(ModelConstants.BankAccount.SwiftCodeMaxLength)]
        [Display(Name = "Swift code")]
        public string SwiftCode { get; set; }
        
        [MaxLength(ModelConstants.BankAccount.SortCodeMaxLength)]
        [Display(Name = "Sort code")]
        public string SortCode { get; set; }

        [Required]
        [MaxLength(ModelConstants.BankAccount.NameMaxLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(ModelConstants.BankAccount.CountryMaxLength)]
        public string Country { get; set; }

        [Required]
        public GlobalMoneyTransferCreateDestinationAccountDto Account { get; set; }
    }
}