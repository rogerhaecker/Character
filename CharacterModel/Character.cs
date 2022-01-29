using System.ComponentModel.DataAnnotations;

namespace CharacterModel
{
    public class Character
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Character Name")]
        [Required(ErrorMessage = "You character must be named")]
        [StringLength(CharacterConstants.MAX_CHARACTER_NAME_LENGTH)]
        public string Name { get; set; }

        public int Str { get; set; }
        public int Con { get; set; }
        public int Dex { get; set; }
        public int Int { get; set; }
        public int Wis { get; set; }
        public int Cha { get; set; }
        public int PlayerID { get; set; }
        public virtual Player Player { get; set; }

        public string UserId { get; set; }
    }
}