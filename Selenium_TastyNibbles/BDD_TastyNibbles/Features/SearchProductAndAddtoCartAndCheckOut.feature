Feature: SearchProductAndAddtoCartAndCheckOut


@E2DSearchProductAndAddtoCartAndCheckOut
Scenario Outline: Search for a product and Add to cart and CheckOut
	Given User will be on the home page
	When User will type the '<searchtext>' in the search box
	Then The Title should have '<searchtext>'
	When User will click on product
	When User will click on size
	When User will click on Add to Cart
	When User will click on CheckOut button
	When User will type the '<email>' in the input
	When User will type the '<firstname>' in the input box
	When User will type the '<lastname>' inside input
	When User will type the '<address>' inside inputbox
	When User will enter the '<city>' 
	When User will click on State dropdown
	When User will select a State
	When User will enter the '<pincode>' in the input
	When User will enter the '<phonenumber>' in the input box
	Then The User will be on the Check out page
Examples: 
	| searchtext | email          | firstname | lastname | address | city   | pincode | phonenumber |
	| Ghee rice  | abhi@gmail.com | abhi      | reddy    | Mysore  | Mysore | 57001   | 9878765674  |
