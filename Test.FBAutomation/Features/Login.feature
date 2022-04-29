Feature: Login
	
Scenario: Verify that a user can login successfully
	Given that utest application is loaded
	When a user clicks on Log In link
	And a user fills-in email address field with ibitoyeazeez@yahoo.com
	And a user fills-in password Field with Delny_1234
	When a user click on Sign in button
	Then user profile Ayo Ibitoye must be displayed