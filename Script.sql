SELECT Products.[Name],Categories.Title
	FROM Products 
	LEFT JOIN Categories ON Products.CategoryId = Categories.Id
GO