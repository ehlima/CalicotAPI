using Calicot.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calicot.Data.Mock
{
    public static class MockProducts
    {
        public static List<ProductModel> mocklistProducts = new List<ProductModel>()
            {
                new ProductModel
                {
                    ProductId = 1,
                    Nom = "Maillot de Soccer Équipe Nationale Brésil",
                    Description = "Conçu en tissu doux et soyeux qui évacue la transpiration, " +
                    "ce maillot t'offre un confort supérieur sur le terrain ou dans les tribunes. " +
                    "L'inscription 'Bréesil' au dos et le blason brodé sur la poitrine " +
                    "te permettent d'afficher clairement ta loyauté.",
                    Prix = 19199,
                    PhotoUrl = "https://i.pinimg.com/originals/d5/c6/98/d5c6981723dbdbe75c04f05d7a2d3a81.jpg"
                },
                new ProductModel
                {
                    ProductId = 2,
                    Nom = "Burton junior chopper snowboard - 130 cm",
                    Description = "The ultimate tot-friendly deck makes learning to link turns easier than finishing your lima beans.",
                    Prix = 23999,
                    PhotoUrl = "https://cdn.shopify.com/s/files/1/0155/0629/products/burton-junior-toddler-chopper-snowboard-130-cm-multi_800x.jpg?v=1597196007"
                }
            };
    }
}
