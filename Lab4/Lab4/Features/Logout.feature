Feature: Logout
	Simple calculator for adding two numbers

@mytag
Scenario: Logout
	Given I open http://localhost:5000/ url
	And I logging in
	When I logout
	Then Check elem login