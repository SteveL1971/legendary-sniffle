SELECT * FROM Products

SELECT Products.Name, Products.ShortDescription, ProductDetails.LongDescription, ProductDetails.Price 
FROM ProductDetails INNER JOIN Products ON ProductDetails.Id=Products.Id

 
SELECT Category.Name, SubCategory.Name, Products.Name, Products.ShortDescription, ProductDetails.LongDescription, ProductDetails.Price  
FROM ProductDetails 
INNER JOIN Products ON ProductDetails.Id=Products.Id 
INNER JOIN SubCategory ON ProductDetails.SubCategoryId = SubCategory.Id
INNER JOIN Category ON SubCategory.CategoryId = Category.Id

SELECT Category.Name, SubCategory.Name, Products.Name, Products.ShortDescription, ProductDetails.LongDescription, ProductDetails.Price  
FROM ProductDetails 
LEFT JOIN Products ON ProductDetails.Id=Products.Id 
INNER JOIN SubCategory ON ProductDetails.SubCategoryId = SubCategory.Id
INNER JOIN Category ON SubCategory.CategoryId = Category.Id

SELECT Users.FirstName, Users.LastName, UserAddresses.UserId, Addresses.AddressLine, Addresses.HouseNr, Addresses.ZipCode, Addresses.City  
FROM UserAddresses 
LEFT JOIN Users ON UserAddresses.UserId=Users.Id 
INNER JOIN Addresses ON UserAddresses.AddressId = Addresses.Id
