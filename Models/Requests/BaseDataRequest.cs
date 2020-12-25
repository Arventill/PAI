using System.Text.RegularExpressions;
using ProgramowanieAplikacjiInternetowych.Utils;

namespace ProgramowanieAplikacjiInternetowych.Models.Requests
{
    public class BaseDataRequest
    {
        public string Email { get; set; }

        public virtual bool IsValid =>
            !string.IsNullOrWhiteSpace(Email) && Regex.IsMatch(Email, AppSettings.EmailExpression);
    }
}
