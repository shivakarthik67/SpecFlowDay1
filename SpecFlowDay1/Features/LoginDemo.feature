Feature: LoginDemo
	In order to access my account
    As a user of the website
    I want to log into the website

@tag1
Scenario: Successful Login with Valid Credential
	Given Launch the page  
	When login with vaild username and password
	Then Verify the User is Logged in Page successfully

@tag2
Scenario: Admin page 
	Given Navigate to the admin page 
	When Add the entries 
	Then save the details and quit the browser 

@tag3
Scenario: Successful Login with Valid Credentialqwq
	Given Launch the pageqwq  
	When login with vaild username and passwordqw
	Then Verify the User is Logged in Page successfullyqwq

@tag4
Scenario: Admin page qwq
	Given Navigate to the admin page qwq
	When Add the entries q
	Then save the details and quit the browser qwq
	