Feature: CreateProduct
	Simple calculator for adding two numbers

@mytag
Scenario: Create new product
	Given I open http://localhost:5000/ url
	And I logging in
	And I Click on All Products
	And I Click on Create New 
	When I enter values ​​into fields
	Then I click on button
