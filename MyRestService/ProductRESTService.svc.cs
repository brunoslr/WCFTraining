
using System.Collections.Generic;

namespace MyRESTService
{
    public class ProductRESTService : IProductRESTService
    {

        public List<Product> GetProductList()
        {
            return Products.Instance.ProductList;
        }
    }
}
