namespace CMS.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.Description = "Assorted Set of 4 Sunflower Seed Packets";
                product.CurrentPrice = 15.96M;
            }

            return product;
        }

        public bool Save(Product product)
        {
            var success = true;

            if (product.Validate())
            {
                if (product.ProductId == 0)
                {
                 
                }
                else
                {
                 
                }
            }
            else
            {
                success = false;
            }

            return success;
        }
    }
}