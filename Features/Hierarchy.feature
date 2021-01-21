Feature: Derived Hierarchies
	
Background: pre-condition
	Given  that the test user has 'metadata' permission user
	And that the test user has logged into MDM

@mytag
Scenario: Create a new hierarchy with two levels inside a model
	And that the test user has selected 'Global' model
	And that the test user has clicked on hieararchy button
	And that the test users has selected 'Create New...' option in dropdown hierarchies
	And  that the test user has entered 'Automation Two levels Test00' in hierarchy name field
	And that the test user has selected 'Link Master Advertiser Master Agency' entity in the first level
	And that the test user has selected 'Master Agency' entity in the second level
	When the test user clicks on save button
	Then a confirmation messagge to prevent changes is rendered
	When the test user clicks on 'YES' button
	Then a message notification is rendered with 'The hierarchy was saved' text when 'create' hierarchy
	
Scenario: Can not Create a Hierarchy with the same name 
	And that the test user has selected 'Global' model
	And that the test user has clicked on hieararchy button
	And that the test users has selected 'Create New...' option in dropdown hierarchies
	And  that the test user has entered 'Hierarchy Test Name' in hierarchy name field
	And that the test user has selected 'Link Master Advertiser Master Agency' entity in the first level
	And that the test user has selected 'Master Agency' entity in the second level
	When the test user clicks on save button
	Then a confirmation messagge to prevent changes is rendered
	When the test user clicks on 'YES' button
	Then a message notification is rendered with 'Can't create the Hierarchy. An Hierarchy with the name «Hierarchy Test Name» already exists' text when 're-create' hierarchy

Scenario: Create a new hierarchy with three levels inside a model
	And that the test user has selected 'Global' model
	And that the test user has clicked on hieararchy button
	And that the test users has selected 'Create New...' option in dropdown hierarchies
	And  that the test user has entered 'Automation Three Levels Test01' in hierarchy name field
	And that the test user has selected 'Raw Buying System Advertiser' entity in the first level
	And that the test user has selected 'Master Business Unit' entity in the second level
	And that the test user has selected 'Master Advertiser' entity in the third level
	When the test user clicks on save button
	Then a confirmation messagge to prevent changes is rendered
	When the test user clicks on 'YES' button
	Then a message notification is rendered with 'The hierarchy was saved' text when 'create' hierarchy

Scenario: Create a new hierarchy with fourth levels inside a model
	And that the test user has selected 'Global' model
	And that the test user has clicked on hieararchy button
	And that the test users has selected 'Create New...' option in dropdown hierarchies
	And  that the test user has entered 'Automation Fourth Levels Test00' in hierarchy name field
	And that the test user has selected 'Raw Buying System Advertiser' entity in the first level
	And that the test user has selected 'Master Business Unit' entity in the second level
	And that the test user has selected 'Master Advertiser' entity in the third level
	And that the test user has selected 'Master Advertiser Owner' entity in the fourth level
	When the test user clicks on save button
	Then a confirmation messagge to prevent changes is rendered
	When the test user clicks on 'YES' button
	Then a message notification is rendered with 'The hierarchy was saved' text when 'create' hierarchy

Scenario: Delete a existent hierarchy 
	And that the test user has selected 'Global' model
	And that the test user has clicked on hieararchy button
	And that the test users has selected 'Automation Two levels Test00' option in dropdown hierarchies
	When the test user clicks on delete hierarchy button
	Then a confirmation messagge to prevent changes is rendered
	When the test user clicks on 'YES' button
	Then a message notification is rendered with 'The hierarchy was deleted' text when 'delete' hierarchy


