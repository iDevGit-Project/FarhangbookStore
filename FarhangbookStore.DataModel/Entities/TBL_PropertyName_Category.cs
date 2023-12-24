using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarhangbookStore.DataModel.Entities
{
    public class TBL_PropertyName_Category
    {
        [Key]
        public int pncId { get; set; }

        public int PropertyNameId { get; set; }

        public int Categoryid { get; set; }

        #region Relation
        [ForeignKey("Categoryid")]
        public TBL_ProductCategory TBLProductCategory { get; set; }

        [ForeignKey("PropertyNameId")]
        public TBL_PropertyName TBLPropertyName { get; set; }
        #endregion
    }
}
