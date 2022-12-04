namespace Assassin_sCreedWikiSked.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Serie")]
    public partial class Serie
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        public string Description { get; set; }

        public double? Rating { get; set; }

        public string ImgURI { get; set; }

        public string VideoPath { get; set; }
    }
}
