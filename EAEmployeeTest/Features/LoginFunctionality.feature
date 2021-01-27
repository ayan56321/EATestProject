Feature: LoginFunctionality
	Check if the required user is able to login into the Application

Background: 
	#Given I Delete employee 'AutoUser' before I start running test

@mytag
Scenario: Check Login with correct username and password
	Given I have navigated to the application Login Page for Create Offer	
	When I validate Forgot Password
	And I validate Terms and condition
	And I validate private policy
	When I enter UserName and Password for User
	| UserName  | Password  |
	| devsm2017 | Password1 |
	And I have provided input for "userNameLogin" as dataInput "UserName"
	And I validate Login functionality
	Then I can verify the user Logged In is perfect
	#And I validate Add Vehicle in instance offer page
	#And I validate Options in instance offer page
	#Then Create offer functionality should be completed
