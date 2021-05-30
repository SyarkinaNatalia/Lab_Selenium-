Feature: Check the created product
	Simple calculator for adding two numbers

@mytag
Scenario: Check the created product
	Given I open http://localhost:5000/ url
	And I logging in
	And I Click on All Products
	When I click on the created product
	Then Check product elements