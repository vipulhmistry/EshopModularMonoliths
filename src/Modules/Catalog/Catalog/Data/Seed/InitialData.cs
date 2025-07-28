
namespace Catalog.Data.Seed;

public static class InitialData
{
    public static IEnumerable<Product> Products =>
        new List<Product>
        {
            Product.Create(new Guid("8c4fb2c4-eede-44d4-8bf9-41a489bde189"), "IPhone X", ["category1"], "Long Description", "imageFile", 500),
            Product.Create(new Guid("b847640f-56c1-4871-b037-17df8beb2905"), "Samsung 10", ["category1"], "Long Description", "imageFile", 400),
            Product.Create(new Guid("963ab595-02d5-4b8c-9ae2-4c575ea62e14"), "Huawei Plus", ["category2"], "Long Description", "imageFile", 650),
            Product.Create(new Guid("998b18c5-9553-4986-a9ef-4c5c9ae11b4e"), "Xiaomi Mi", ["category2"], "Long Description", "imageFile", 450)
        };

}
