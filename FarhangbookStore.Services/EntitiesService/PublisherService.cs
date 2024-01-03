using FarhangbookStore.DataModel;
using FarhangbookStore.DataModel.Entities;
using FarhangbookStore.Services.Interface;
using Microsoft.CodeAnalysis.Elfie.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarhangbookStore.Services.EntitiesService
{
    public class PublisherService : IPublisherService
    {
        private readonly ApplicationDbContext _Context;
        public PublisherService(ApplicationDbContext Context)
        {
            _Context = Context;
        }
        public int AddPublisher(TBL_ProductPublisher productpublisher)
        {
            try
            {
                _Context.TBLProductPublishers.Add(productpublisher);
                _Context.SaveChanges();
                return productpublisher.Publisherid;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public bool UpdatePublisher(TBL_ProductPublisher productpublisher)
        {
            try
            {
                productpublisher.IsDelete = true;
                _Context.TBLProductPublishers.Update(productpublisher);
                _Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeletePublisher(TBL_ProductPublisher productpublisher)
        {
            try
            {
                _Context.TBLProductPublishers.Update(productpublisher);
                _Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool ExistPublisher(string publisherFaname, string publisherEnname, int productpublisherid)
        {
            return _Context.TBLProductPublishers.Any(p => p.PublisherFaTitle== publisherFaname && p.PublisherEnTitle== publisherEnname && p.Publisherid != productpublisherid && !p.IsDelete);
        }

        public TBL_ProductPublisher FindPublisherById(int productpublisherid)
        {
            return _Context.TBLProductPublishers.Find(productpublisherid);
        }

        public List<TBL_ProductPublisher> GetAllProductPublisherForMenu()
        {
            return _Context.TBLProductPublishers.Where(w => !w.IsDelete).ToList();

        }

        public List<TBL_ProductPublisher> ShowAllPublisher()
        {
            return _Context.TBLProductPublishers.Where(w => !w.IsDelete).ToList();
        }

    }
}
