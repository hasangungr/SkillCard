using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace CF_Skill_Card.Models.Class
{
    public class Context :DbContext

    
    {
        public DbSet<Skill> Skills { get; set; }
    }

}