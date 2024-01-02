using FarhangbookStore.DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarhangbookStore.Services.Interface
{
    public interface IPublisherService
    {
        List<TBL_ProductPublisher> ShowAllSizeBook();
        List<TBL_ProductPublisher> GetAllProductPublisherForMenu();
        int AddPublisher(TBL_ProductPublisher productpublisher);
        bool UpdatePublisher(TBL_ProductPublisher productpublisher);
        bool DeletePublisher(TBL_ProductPublisher productpublisher);
        bool ExistPublisher(string publisherFaname, string publisherEnname, int productpublisherid);
        //==============================================
        TBL_ProductPublisher FindPublisherById(int productpublisherid);
    }
}
