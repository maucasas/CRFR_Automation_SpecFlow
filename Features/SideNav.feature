Feature: SideNavFeature


@SideNav
Scenario Outline: Elements visibles in SideNav based in user role
	Given that the test user is as <role> level user
		And that the test user has logged into CCF
		When the SideNav has loaded
		Then the Creative LinkText should be visible
		And the Campaign LinkText should be <campaignStatus>
		And the Config LinkText should be <configStatus>

	Examples: 
	| role         | creativeIconStatus | campaignIconStatus | configStatus |
	| global-admin | visible            | visible            | visible      |
	| regular-user | visible            | not-visible        | visible      |

