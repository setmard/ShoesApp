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
        
        public List<SearchShoes> searchByName(string name)
        {
            var capData2 = new ShoesApp.Data.dataBl();
            List<SearchShoes> ln = new List<SearchShoes>();

            var listname = capData2.GetName(name);
            foreach (var item in listname)
            {
                ln.Add(new SearchShoes
                {
                    IdType = item.IdType,
                    Id =item.Id,
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
                    DateUpdate =item.DateUpdate
                });
            }
            return ln;
        }
        public List<SearchShoes> SearchS(int id)
        {
            var capData = new ShoesApp.Data.dataBl();
            List<SearchShoes> lp = new List<SearchShoes>();
            
                var listProduct =  capData.Getid(id);
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

        public void AddShoes(SearchShoes insert)
        {
            var insrt = new ShoesApp.Data.dataBl();
            insrt.InsertShoes(insert.IdType, insert.IdColor, insert.IdBrand, insert.IdProvider, insert.IdCatalog, insert.Title, insert.Nombre, insert.Description, insert.Observations, insert.PriceDistributor, insert.PriceClient, insert.PriceMember, insert.IsEnabled, insert.Keywords, insert.DateUpdate);
        }
       
    }
}
