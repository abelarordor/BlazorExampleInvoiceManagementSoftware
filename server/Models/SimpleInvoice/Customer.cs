using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleInvoiceManagementSoftware.Models.SimpleInvoice
{
  [Table("Customer", Schema = "dbo")]
  public partial class Customer
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CustomerId
    {
      get;
      set;
    }

    public ICollection<Invoice> Invoices { get; set; }
    public string Name
    {
      get;
      set;
    }
    public string Description
    {
      get;
      set;
    }
    public string Address
    {
      get;
      set;
    }
    public string City
    {
      get;
      set;
    }
  }
}
