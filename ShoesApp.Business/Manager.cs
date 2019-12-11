using ShoesApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoesApp.Data;

namespace ShoesApp.Business
{
    public class Manager
    {
        public List<SearchShoes> SearchS(int id, string name)
        {
            var capData = new ShoesApp.Data.dataBl();
            List<SearchShoes> lp = new List<SearchShoes>();
            
                var listProduct =  capData.Getid(id, name);
                foreach (var item in listProduct)
                {
                    lp.Add(new SearchShoes {
                        IdType = item.IdType,
                        Id = item.Id,
                        IdColor = item.IdColor,
                        IdBrand = item.IdBrand,
                        IdProvider = item.IdProvider,
                        IdCatalog = item.IdCatalog,
                        Title = item.Title,
                        Nombre = item.Nombre,
                        Description = item.Description,
                        Observations = item.Observations,
                        PriceClient = item.PriceClient,
                        PriceDistributor = item.PriceDistributor,
                        PriceMember = item.PriceMember,
                        IsEnabled = item.IsEnabled,
                        Keywords = item.Keywords,
                        DateUpdate = item.DateUpdate
                    });
                }

            return lp;
        }

       
    }
}
