using System;
using System.Collections.Generic;

#nullable disable

namespace EcommerceAPI.Models
{
    public partial class TblCategory
    {
        public int Id { get; set; }
        public int CatId { get; set; }
        public string CatName { get; set; }
    }
}
