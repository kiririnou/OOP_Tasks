using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkTask
{
    [Table("Humans")]
    public class Human
    {
        public int      Id          { get; set; }
        public string   Fullname    { get; set; }
        public string   Gender      { get; set; }
        public string   Birthday    { get; set; }
    }

    public class HumanityContext : DbContext
    {
        public HumanityContext() : base("DBConnection") { }

        public DbSet<Human> Humans  { get; set; }
    }
}
