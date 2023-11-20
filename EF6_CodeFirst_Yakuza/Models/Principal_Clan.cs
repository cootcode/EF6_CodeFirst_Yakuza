using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EF6_CodeFirst_Yakuza.Models
{
    public class Principal_Clan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClanNumber { get; set; }

        [Display(Name = "Clan Name")]
        public string ClanName { get; set; }

        [Display(Name = "Founding Location")]
        public string FoundingLocation { get; set; }

        [Display(Name = "Year Founded")]
        public string YearFounded { get; set; }

        [Display(Name = "Years Active")]
        public int? YearsActive { get { return this.Years_Active(this.YearFounded); } }

        public string Territory { get; set; }

        public string Ethnicity { get; set; }

        [Display(Name = "Members")]
        public int? Membership { get { return Members.Where(x => x.ClanNumber == this.ClanNumber).Count(); } } //members

        [Display(Name = "Activities")]
        public string CriminalActivities { get; set; }

        //NAVIGATIONAL PROPERTIES
        [ForeignKey("Yakuza")]
        public int YakuzaId { get; set; }
        public Yakuza Yakuza { get; set; }
        //

        public ICollection<Member>  Members { get; set; }

        //
        private int Years_Active(string date)
        {
            string founded = date;
            DateTime start = DateTime.Parse(founded);
            DateTime now = DateTime.Now;
            TimeSpan elapsed = now.Subtract(start);
            double daysAgo = elapsed.TotalDays;
            int yearsAgo = Convert.ToInt32(daysAgo) / 365;
            return yearsAgo;
        }
    }
}