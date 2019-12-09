Feature: DealList
	As a fiscally responsible customer
    I want to be able to find current deals on coffee
    So I can enjoy my morning indulgence without breaking the bank

@mytag
Scenario: Querying the entire list returns a list of deals
	Given A deal list that contains deals
	When I request all the deals
	Then the list that is returned contains all the deals

Scenario: Querying for a deal that exists in the list by code returns the deal
	Given A deal in the list with a code of TenPercentOff
	When I request the deal by the code TenPercentOff
	Then I am returned only the TenPercentOff deal

Scenario: Querying for a deal that does not exist returns null
	Given A list that does not contain a deal called ItsAllFree
	When I request the deal by the code ItsAllFree
	Then null is returned