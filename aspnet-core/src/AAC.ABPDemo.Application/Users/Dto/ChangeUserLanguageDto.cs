using System.ComponentModel.DataAnnotations;

namespace AAC.ABPDemo.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}