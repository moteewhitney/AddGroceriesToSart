Feature: If i shop online @ AbelAndCole
	I should be able to place my order successfully 

@mytag
Scenario: Add Groceries to cart
	Given i navigate to the website "https://www.abelandcole.co.uk/"
	And i click on start shopping
	And i search groceries "Chocolate Brownie Tray organic Daylesford (570g)"
	And i click the search glass
	#And i accept cookies
	And i click on add 
	And i search groceries2 "Hummus chips organic, Eat Real (100g)"
	And i click the search glass
	And i click on add 
	And i click on plussshummus 
	And i search groceries "Simply salted popcorn organic, Nom (20g)"
	And i click the search glass
	And i click on add
	And i click on plusspopcorn
	When i click on my basket
	#Then all 6 items are in basket
	
	
	



	