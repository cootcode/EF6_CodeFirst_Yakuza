using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace EF6_CodeFirst_Yakuza.Models
{
    public class Member
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MemberId { get; set; }
        [Display(Name = "Family Name")]
        public string FamilyName { get; set; }
        [Display(Name = "Personal Name")]
        public string PersonalName { get; set; }

        [UIHint("Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Date Joined")]
        public DateTime DateJoinedClan { get; set; }

        [UIHint("Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "DOB")]
        public DateTime DateOfBirth { get; set; }

        [UIHint("Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Date Deceased")]
        public DateTime? DateDeceased { get; set; }

        [EnumDataType(typeof(Skill))]
        public Skill Skill { get; set; }

        //NAVIGATIONAL PROPERTIES
        [ForeignKey("Principal_Clan")]
        public int ClanNumber { get; set; }
        public Principal_Clan Principal_Clan { get; set; }
    }

    public enum Skill { Karate, Meditator, Singer, Musician, Chef, Bodyguard, Driver, Trainer}
}