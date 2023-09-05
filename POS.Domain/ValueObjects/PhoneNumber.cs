using System.Data;
using System.Text.RegularExpressions;

namespace POS.Domain.ValueObjects
{
    public partial record PhoneNumber
    {
        private const int DefaultLenght = 10;
        private const string Pattern = @"^(3[0-9]{9})$";

        private PhoneNumber(string value) => value = value.Trim();

        public static PhoneNumber? Create(string value)
        {
            if (string.IsNullOrEmpty(value) ||
                !PhoneNumberRegex().IsMatch(value) ||
                value.Length != DefaultLenght) return null;

            return new PhoneNumber(value);
        }
        public string Value { get; init; }

        [GeneratedRegex(Pattern)]
        private static partial Regex PhoneNumberRegex();
    }
}
