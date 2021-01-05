Feature: CreativeActions
	
Background: pre-condition
	Given  that the test user has 'metadata' permission user
	And that the test user has logged into MDM

@mytag
Scenario: Add new creative with the  free-forms, dropdowns list, datepickers in campaign
	And that the test user has selected a model
	And  that the test user has populate freeforms text
	And that the test user has selected datepicker
	When the test user clicks on save button
	Then the creative taxonomy string is displayed