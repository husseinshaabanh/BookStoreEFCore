namespace OnlineBookStoreWithASPNETCore
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public book()
        {
            C_order = new HashSet<C_order>();
        }

        public int bookId { get; set; }

        [Required]
        [StringLength(50)]
        public string title { get; set; }

        [Required]
        [StringLength(50)]
        public string authorName { get; set; }

        [Column(TypeName = "money")]
        public decimal? price { get; set; }

        public int quantity { get; set; }

        public int? categoryId { get; set; }

        public virtual Category category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_order> C_order { get; set; }
    }
}
