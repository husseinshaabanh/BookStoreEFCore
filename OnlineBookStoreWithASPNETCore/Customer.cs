namespace OnlineBookStoreWithASPNETCore
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("customer")]
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            C_order = new HashSet<C_order>();
        }

        public int customerId { get; set; }

        [Required]
        [StringLength(50)]
        public string fName { get; set; }

        [StringLength(50)]
        public string lName { get; set; }

        [Required]
        [StringLength(100)]
        public string eMail { get; set; }

        [Required]
        [StringLength(100)]
        public string pass { get; set; }

        [Required]
        [StringLength(15)]
        public string phone { get; set; }

        [Required]
        [StringLength(20)]
        public string city { get; set; }

        [Required]
        [StringLength(5)]
        public string zipCode { get; set; }

        [Required]
        [StringLength(20)]
        public string street { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_order> C_order { get; set; }
    }
}
