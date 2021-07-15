using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsomniaWebApplication
{
    public class ProductQuery : ObjectGraphType
    {
        public ProductQuery(ProductRepository productRepository)
        {
            Field<ListGraphType<ProductType>>(name: "products", resolve: context =>
            {
                return productRepository.GetProducts();
            });
        }
    }
}
