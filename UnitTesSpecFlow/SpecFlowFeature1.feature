Feature: SpecFlowBikestarFeature1
	
	As a not registered user of bikestar.pl
	I want to open product list of Integral Helmets
	and I want to add Helmet to cart
	so that I can buy my new Helmet, 
	


@Positive
Scenario: Open product list by clicking top menu and add helmet to cart

Given Bikestar main page has opened

When user moves mouse over Helmets in menu
And user clicks on integral helmets menu item
Then product list of integral helmets is displayed

When user clicks on link Rihno Racer helmet
And user select helmet size XL
And user click add to cart button

Then selected helmet has been added to cart

