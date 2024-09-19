Feature: AddToCart

Background: User will be on the home page

@E2E_AddToCart
Scenario Outline: Search for a product and Add to cart
	#Given User will be on the home page
	When User will type the '<searchtext>' in the search box
	Then The Title should have '<searchtext>'
	When User will click on product
Examples: 
	| searchtext |
	| Ghee rice  |