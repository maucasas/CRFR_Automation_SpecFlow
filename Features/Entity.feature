Feature: Entity
	
Background: pre-condition
	Given  that the test user has 'metadata' permission user
	And that the test user has logged into MDM
@mytag

Scenario: Add new entity in a model 
	And that the test user has selected 'Global' model
	And that the test users clicks on add entity button
	And that the test user has entered 'Master MC test Automation' text on entity name free form input
	When the test user clicks on save new entity button
	Then the new 'Master MC test Automation' entity is added in the list entities

Scenario: Delete a entity in a model 
	And that the test user has selected 'Global' model
	And that the test user has selected 'Master MC test Automation' entity
	And that the delete button is enabled
	And that the test user clicks on delete entity button
	And that the test user has entered 'confirm' text in confirm delete entity input
	And that the test user has clicked confirm delete entity button
	Then the 'Master MC test Automation' entity is removed of the list entities

Scenario: the Attribute column field should se enabled depending of the type selection
	And that the test user has selected 'Global' model
	And that the test user has selected 'Master MC test Automation' entity
	And that the test user has clicked on edit entity button
	And that the test user has clicked on Add New Attribute button
	When the test user selects '<attributeType>' on dropdown attribute type
	Then the '<columnField>' column field is displayed
	And that the test user has entered 'confirm' text in confirm delete entity input
	And that the test user has clicked confirm delete entity button
	Then the 'Master MC test Automation' entity is removed of the list entities

	Examples: 
	| attributeType       | columnField    |
	| Datetime            | Date           |
	| Number              | Number         |
	| Text                | Text           |
	| Currency            | Currency       |
	| Mapping Column      | Mapping Column |
	| Multi Value Mapping | Mapping Column |


	Scenario: Test user gives permissions to user to model
	And that the test user has navigated to 'Permissions' view
	And that the test user has selected '<user>' user
	And that the test user has selected '<model>' model in assigning permission
	And that the test user has selected '<permission>'
	
	Examples:
	| User              | model  | permission |
	| ZOAppDevTest2-tst | Global | Metadata   |
	| ZOAppDevTest3-tst | Global | Write      |
	| ZOAppDevTest4-tst |