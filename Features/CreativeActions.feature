Feature: CreativeActions
	
Background: pre-condition
	Given  that the test user is as global-admin level user
	And that the test user has logged into CCF
	And that the test user has selected 'Starcom' agency
	And that the test user has selected 'Samsung Group' client
	And that the test user has selected 'Europe,the Middle East, and Africa' region
	And that the test user has selected 'Hungary' country
	And that the test user has selected a campaign
	And that the test user has selected new creative button

@mytag
Scenario: Add new creative with the  free-forms, dropdowns list, datepickers in campaign
	And that the test user has selects the dropdowns options
	And  that the test user has populate freeforms text
	And that the test user has selected datepicker
	When the test user clicks on save button
	Then the creative taxonomy string is displayed