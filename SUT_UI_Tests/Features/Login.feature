@WI:2345
Feature: Login

A short summary of the feature

@WI:2224
Scenario: Login with valid credentials
	Given I am on the home page
	When I fill in login with valid credentials
	Then I should be logged in

Scenario: Login with invalid credentials
	Given I am on the home page
	When I fill in login with invalid credentials
	Then I should not be logged in
