Feature: Login
	Simple calculator for adding two numbers

@mytag
Scenario: Login

	Given I open http://localhost:5000/ url
	And I enter login and password
	When I click send button
	Then the browser navigates to the HomePage