﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarhangbookStore.DataModel.Entities
{
    public class TBL_ProductCategory
    {
        [Key]
        public int Categoryid { get; set; }

        [Display(Name = "عنوان دسته بندی به فارسی")]
        [Required(ErrorMessage = "وارد کردن {0} اجباری می باشد .")]
        [MinLength(3, ErrorMessage = "{0} نمیتواند کمتر از {1} باشد")]
        [MaxLength(100, ErrorMessage = "{0} نمیتواند بیشتر از {1} باید")]
        public string CategoryFaTitle { get; set; }


        [Display(Name = "عنوان دسته بندی به انگلیسی")]
        [Required(ErrorMessage = "وارد کردن {0} اجباری می باشد .")]
        [MinLength(3, ErrorMessage = "{0} نمیتواند کمتر از {1} باشد")]
        [MaxLength(100, ErrorMessage = "{0} نمیتواند بیشتر از {1} باید")]
        public string CategoryEnTitle { get; set; }

        public int? SubCategory { get; set; }

        public bool IsDelete { get; set; }

        #region Relation

        public List<TBL_Product> TBLProducts { get; set; }

        //public List<PropertyName_Category> propertyName_Categories { get; set; }

        //[ForeignKey("SubCategory")]
        //public ProductCategory Categori { get; set; }

        #endregion
    }
}
