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

        public List<Products> Getid(int id, string name)
        {
            List<Products> ls = new List<Products>();
            if (id == null)
            {
                var listid = context.SEMD_SearchByName(name);
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
            }
            else if (name == null || name == "")
            {
                var listName = context.SEMD_SearchById(id);
                foreach (var item in listName)
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

            }
            return ls;

        }
    }
}
