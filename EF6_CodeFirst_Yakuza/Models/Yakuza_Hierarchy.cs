using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EF6_CodeFirst_Yakuza.Models
{
    public class Yakuza_Hierarchy
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EntryId { get; set; }
        [Display(Name = "Level")]
        public int LevelNumber { get; set; }
        [Display(Name = "English Name")]
        public string EnglishEntryName { get; set; }
        [Display(Name = "Japanese Name")]
        public string JapaneseEntryName { get; set; }

        //NAVIGATIONAL PROPERTIES
        [ForeignKey("Yakuza")]
        [Column(Order = 1)]
        public int YakuzaId { get; set; }
        public Yakuza Yakuza { get; set; }

        //RECURSIVE RELATIONSHIP PROPERTIES
        [ForeignKey("Parent_Yakuza_Hierarchy")]
        [Column(Order = 2)]
        public int? ParentEntryId { get; set; }//is nullable
        public Yakuza_Hierarchy Parent_Yakuza_Hierarchy { get; set; }
        public List<Yakuza_Hierarchy> YakuzaChildrenHierarchies { get; set; }
    }
}