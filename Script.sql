SELECT Products.[Name], Categories.[Title] FROM PRODUCTS 
	LEFT JOIN (SELECT * FROM Categories 
		JOIN Categories_Products ON Categories.Id = Categories_Products.CategoryID) AS PC ON Products.ID = PC.ProductId
