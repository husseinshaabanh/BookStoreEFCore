namespace OnlineBookStoreWithASPNETCore
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class category_name
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int categoryId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string name { get; set; }

        public virtual Category category { get; set; }
    }
}
