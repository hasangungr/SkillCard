using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CF_Skill_Card.Models.Class
{
    public class Skill
        
    {
        [Key]
        public int skillID { get; set; }
        public string skillDescription { get; set; }
        public byte skillValue { get; set; }
    }
}