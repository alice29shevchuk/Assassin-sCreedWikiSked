namespace Assassin_sCreedWikiSked.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Character")]
    public partial class Character
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public string Description { get; set; }

        [StringLength(255)]
        public string Statement { get; set; }

        [StringLength(2000)]
        public string Audio { get; set; }

        [StringLength(2000)]
        public string ImageUri { get; set; }

        [StringLength(200)]
        public string DateOfBirth { get; set; }

        [StringLength(200)]
        public string MotherLand { get; set; }

        [StringLength(200)]
        public string DateOfDeath { get; set; }

        [StringLength(200)]
        public string Killer { get; set; }

        [StringLength(200)]
        public string APlaceOfDeath { get; set; }

        [StringLength(1000)]
        public string Affiliation { get; set; }

        [StringLength(2000)]
        public string Appearances { get; set; }
    }
}
