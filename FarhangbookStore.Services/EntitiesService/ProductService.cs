using FarhangbookStore.DataModel;
using FarhangbookStore.DataModel.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarhangbookStore.Services.EntitiesService
{
	public class ProductService
	{
		private readonly ApplicationDbContext _Context;
		public ProductService(ApplicationDbContext Context) 
		{ 
			_Context = Context;
		}
		#region سرویس ثبت خصوصیات و ویژه گی ها
		public List<TBL_PropertyName> ShowAllProperty()
		{
			return _Context.TBLPropertyNames.ToList();
		}
		#endregion
	}
}
