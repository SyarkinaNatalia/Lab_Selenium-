Feature: Test
	

@mytag
Scenario: Test

	Given I open "http://localhost:5000/" url
	And I enter login and password
	When the browser navigates to the HomePage
	When I Click on All Products
	When I Click on Create New 
	When I enter values ​​into fields
	When I click on the created product
	When I click on All Products
	When I delete new product
	When I logout
	Then end