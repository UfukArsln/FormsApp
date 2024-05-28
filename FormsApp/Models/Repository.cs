using System.Resources;

namespace FormsApp.Models
{
    public class Repository
    {
        private static readonly List<Product> _products = new();

        private static readonly List<Category> _categories = new();

        static Repository()
        {
            _categories.Add(new Category { CategoryId = 1, Name = "Telefon" });

            _categories.Add(new Category { CategoryId = 2, Name = "Bilgisayar" });

            _products.Add(new Product { ProductId = 1, Name = "Iphone 14", Price = 40000, IsActive = true, Image = "1.jpg", CategoryId = 1 });
            _products.Add(new Product { ProductId = 2, Name = "Iphone 15", Price = 50000, IsActive = true, Image = "2.jpg", CategoryId = 1 });
            _products.Add(new Product { ProductId = 3, Name = "Iphone 13", Price = 30000, IsActive = false, Image = "3.jpg", CategoryId = 1 });
            _products.Add(new Product { ProductId = 4, Name = "Iphone 12", Price = 25000, IsActive = true, Image = "4.jpg", CategoryId = 1 });
            _products.Add(new Product { ProductId = 5, Name = "Iphone 11", Price = 20000, IsActive = false, Image = "1.jpg", CategoryId = 1 });

            _products.Add(new Product { ProductId = 6, Name = "MacBook Air", Price = 70000, IsActive = true, Image = "5.jpg", CategoryId = 2 });
            _products.Add(new Product { ProductId = 7, Name = "Macbook Pro", Price = 80000, IsActive = true, Image = "6.jpg", CategoryId = 2 });
        }

        public static List<Product> Products
        {
            get
            {
                return _products;
            }
        }

        public static void CreateProduct(Product entity)
        {

            _products.Add(entity);
        }

        public static void EditProduct(Product updatedProduct)
        {
            var entity = _products.FirstOrDefault(p => p.ProductId == updatedProduct.ProductId);

            if (entity != null)
            {
                if (!string.IsNullOrEmpty(updatedProduct.Name))
                {
                    entity.Name = updatedProduct.Name;
                }
                if (updatedProduct.Price != null)
                {
                    entity.Price = updatedProduct.Price;
                }
                if (!string.IsNullOrEmpty(updatedProduct.Image))
                {
                    entity.Image = updatedProduct.Image;
                }

                if (updatedProduct.CategoryId != null)
                {
                    entity.CategoryId = updatedProduct.CategoryId;
                }

                entity.IsActive = updatedProduct.IsActive;

            }
        }

        public static void DeleteProduct(Product selectedProduct)
        {
            var entity = _products.FirstOrDefault(p => p.ProductId == selectedProduct.ProductId);

            if (entity != null)
            {
                _products.Remove(entity);
            }
        }

        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }




    }
}