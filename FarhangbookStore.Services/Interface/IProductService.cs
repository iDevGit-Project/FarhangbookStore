using FarhangbookStore.DataModel.Entities;
using FarhangbookStore.DataModel.EntityViewModels;
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
		bool ExistPropertyname(string name, int id);
		bool AddPropertyForCategory(List<TBL_PropertyName_Category> categories);
		List<ViewModel_UpdatePropertyName> ShowPropertyNameForUpdate(int propertynameid);
		bool UpdatePropertyname(TBL_PropertyName propertyName);
		bool DeleteProperyForCategory(int propid);
		TBL_PropertyName FindPropertyBuyeid(int id);

		#endregion
	}
}
