Feature: Delete
	Simple calculator for adding two numbers

@mytag
Scenario: Delete new product
	Given I open http://localhost:5000/ url
	And I logging in
	When I click on All Products
	Then I delete new product