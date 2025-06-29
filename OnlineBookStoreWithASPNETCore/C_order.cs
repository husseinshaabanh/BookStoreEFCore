namespace OnlineBookStoreWithASPNETCore
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("_order")]
    public partial class C_order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_order()
        {
            books = new HashSet<book>();
        }

        [Key]
        public int orderId { get; set; }

        public int? quantity { get; set; }

        public int? customerId { get; set; }

        public virtual Customer customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<book> books { get; set; }
    }
}
