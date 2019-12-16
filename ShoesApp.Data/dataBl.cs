using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesApp.Data
{
    public class dataBl
    {
        DataProductsEntities context = new DataProductsEntities();

        public List<Products> Getid(int id)
        {
            List<Products> ls = new List<Products>();
           
                var listid = context.SEMD_SearchById(id);
                foreach (var item in listid)
                {
                    ls.Add(new Products
                    {
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
            return ls;
        }

        public List<Products> GetName(string name)
        {
            List<Products> lsname = new List<Products>();
            
                var listName = context.SEMD_SearchByName(name);
                foreach (var item in listName)
                {
                    lsname.Add(new Products
                    {
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
            return lsname;
        }

        public void InsertShoes(int? idType, int? idColor, int? idBrand, int?idProvider, int?idCatalog, string title, string nombre, string description, string observations, decimal? priceDistributor, decimal? priceClient, decimal? priceMember, bool? isEnabled, string keywords, DateTime? dateUpdate)
        {
            context.SEMD_AddShoes(idType, idColor, idBrand, idProvider, idCatalog, title, nombre, description, observations, priceDistributor, priceClient, priceMember, isEnabled, keywords, dateUpdate);
        }
    }
}
