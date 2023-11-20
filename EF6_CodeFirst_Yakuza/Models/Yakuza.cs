using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EF6_CodeFirst_Yakuza.Models
{
    public class Yakuza
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int YakuzaId { get; set; }
        public string Origin { get; set; }
        public string Creation { get; set; }
        public int Membership { get { return TotalMembers(); } }
        public string Activities { get; set; }

        //NAVIGATIONAL PROPERTIES
        public List<Yakuza_Hierarchy> Yakuza_Hierarchies { get; set; }
        public List<Principal_Clan> Principal_Clans { get; set; }
        //

        //method for counting members
        private int TotalMembers()
        {
            YakuzaDbContext db = new YakuzaDbContext();

            int members = db.Members.Count();
            return members;
        }
    }
}