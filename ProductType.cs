using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsomniaWebApplication
{
    public class ProductType : ObjectGraphType<Product>
    {
        public ProductType()
        {
            Name = "Product";
            Field(_ => _.Id).Description("Product ID.");
            Field(_ => _.Name).Description("Product Name");
            Field(_ => _.Description).Description("Product Description");
        }
    }
}
