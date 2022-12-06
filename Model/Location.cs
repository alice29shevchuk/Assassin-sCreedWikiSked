namespace Assassin_sCreedWikiSked.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Location")]
    public partial class Location
    {
        public int ID { get; set; }

        [StringLength(300)]
        public string Title { get; set; }

        public string Description { get; set; }

        [StringLength(4000)]
        public string ImageUri { get; set; }

        [StringLength(255)]
        public string Status { get; set; }

        [StringLength(1000)]
        public string Ruler { get; set; }

        [StringLength(1000)]
        public string Factions { get; set; }

        [StringLength(1000)]
        public string Founder { get; set; }

        public string Places { get; set; }

        public string AssassinGoals { get; set; }

        public string ArticleInTheDatabase { get; set; }
    }
}
