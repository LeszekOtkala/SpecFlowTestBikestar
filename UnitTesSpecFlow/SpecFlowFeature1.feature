Feature: SpecFlowBikestarFeature1
	
	As a not registered user of bikestar.pl
	I want to open product list of Integral Helmets
	so that I can find my new Helmet

@Positive
Scenario: Open product list by clicking top menu 

Given Bikestar main page has opened

When user moves mouse over Helmets in menu
And user clicks on integral helmets menu item
Then product list of integral helmets is displayed
