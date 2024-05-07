Select Products.Name, ISNULL(Categories.Name, 'not category') as CategoryName from Products
LEFT JOIN CategoryProduct ON CategoryProduct.ProductsId = Products.Id
LEFT JOIN Categories ON CategoryProduct.CategoriesId = Categories.Id;