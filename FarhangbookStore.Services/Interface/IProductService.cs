using FarhangbookStore.DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarhangbookStore.Services.Interface
{
	public interface IProductService
	{
		#region TBLProductProperty متد های جدول 

		List<TBL_PropertyName> ShowAllProperty();
		int AddProprtyName(TBL_PropertyName tblPropertyName);

		#endregion
	}
}
