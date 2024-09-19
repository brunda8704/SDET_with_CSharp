Feature: SearchAndAddToCart

Search a product from the store and adding it to the cart

Background: User will be on the home page

@End_To_End_Testing
Scenario Outline: Search for a product and Add to cart
	When User will type the '<searchtext>' in the search box
	Then List of available products will appear
	When User will click on product '<productId>'
	Then Product page will appear
	When User will click on add to cart button of item '<itemId>'
	Then Shopping Cart page will appear

Examples: 
	| searchtext | productId | itemId |
	| Fish       | FI-FW-02  | EST-20 |
	
