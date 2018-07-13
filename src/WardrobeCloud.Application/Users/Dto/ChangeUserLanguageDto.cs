using System.ComponentModel.DataAnnotations;

namespace WardrobeCloud.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}