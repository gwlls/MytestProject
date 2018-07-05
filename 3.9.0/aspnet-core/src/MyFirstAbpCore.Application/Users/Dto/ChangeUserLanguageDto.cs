using System.ComponentModel.DataAnnotations;

namespace MyFirstAbpCore.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}