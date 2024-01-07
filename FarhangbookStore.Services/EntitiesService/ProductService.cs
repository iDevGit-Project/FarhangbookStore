﻿using FarhangbookStore.DataModel;
using FarhangbookStore.DataModel.Entities;
using FarhangbookStore.DataModel.EntityViewModels;
using FarhangbookStore.Services.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarhangbookStore.Services.EntitiesService
{
	public class ProductService : IProductService
	{
		private readonly ApplicationDbContext _Context;
		public ProductService(ApplicationDbContext Context) 
		{ 
			_Context = Context;
		}
        
        #region سرویس خصوصیات و ویژه گی ها

        public bool ExistPropertyname(string name, int id)
        {
            return _Context.TBLPropertyNames.Any(p => p.PropertyTitle == name && p.PropertyNameId != id);
        }

        public TBL_PropertyName FindPropertyBuyeid(int id)
        {
            return _Context.TBLPropertyNames.Find(id);
        }
        public bool ExistPropertyName(string name, int id)
        {
            return _Context.TBLPropertyNames.Any(p => p.PropertyTitle == name && p.PropertyNameId != id);
        }
        public List<TBL_PropertyName> ShowAllProperty()
		{
			return _Context.TBLPropertyNames.ToList();
		}

        #endregion

        #region متد ثبت خصوصیات و ویژه گی ها برای دسته بندی ها
        public bool AddPropertyForCategory(List<TBL_PropertyName_Category> categories)
        {
            try
            {
                _Context.TBLPropertyNameCategories.AddRange(categories);
                _Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region متد حذف خصوصیات و ویژه گی ها برای دسته بندی ها
        public bool DeleteProperyForCategory(int propid)
        {
            try
            {
                List<TBL_PropertyName_Category> categories = _Context.TBLPropertyNameCategories.Where(c => c.PropertyNameId == propid).ToList();
                _Context.TBLPropertyNameCategories.RemoveRange(categories);
                _Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return true;
            }
        }
        #endregion

        #region  متد ویرایش خصوصیات و ویژه گی ها موجود در دسته بندی ها
        public List<ViewModel_UpdatePropertyName> ShowPropertyNameForUpdate(int propertynameid)
        {
            // ترکیب دو جدول به صورت همزمان با استفاده از ویو مدل
            List<ViewModel_UpdatePropertyName> updates = (from pc in _Context.TBLPropertyNameCategories
                                                          join p in _Context.TBLPropertyNames on pc.PropertyNameId equals p.PropertyNameId
                                                          where (pc.PropertyNameId == propertynameid)
                                                          select new ViewModel_UpdatePropertyName
                                                          {
                                                              pncId = pc.pncId,
                                                              Categoryid = pc.Categoryid,
                                                              PropertyNameId = p.PropertyNameId,
                                                              PropertyTitle = p.PropertyTitle,

                                                          }).ToList();
            return updates;
        }
        #endregion

        #region متد بروزرسانی خصوصیات و ویژه گی ها

        public bool UpdatePropertyName(TBL_PropertyName propertyName)
        {
            try
            {
                _Context.TBLPropertyNames.Update(propertyName);
                _Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region متد ثبت خصوصیات و ویژه گی ها
        public int AddProprtyName(TBL_PropertyName tblPropertyName)
        {
            try
            {
                _Context.TBLPropertyNames.Add(tblPropertyName);
                _Context.SaveChanges();
                return tblPropertyName.PropertyNameId;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        #endregion

    }
}
