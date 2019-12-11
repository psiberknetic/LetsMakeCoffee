Feature: DealOfTheDay
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Deal of the Day has to be a weekday
	Given It is Monday
	When I add the deal to the menu items
	Then I apply the deal to the menu items