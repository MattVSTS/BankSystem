namespace BankSystem.Common
{
    public static class GlobalConstants
    {
        public const string BankSystemEmail = "service@retailbank1.com";

        public const string AdministratorRoleName = "Administrator";

        public const string TempDataErrorMessageKey = "ErrorMessage";
        public const string TempDataSuccessMessageKey = "SuccessMessage";

        public const string TempDataNoTwoFactorKey = "2FANotEnabled";
        public const string IgnoreTwoFactorWarningCookie = "IgnoreTwoFactorWarning";

        public const string CardExpirationDateFormat = "MM/yy";
        public const int CardValidityInYears = 4;
    }
}