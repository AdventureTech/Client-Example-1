Feature: When creating an invoice
	In order add open freight items to an invoice
	As a user
	I want a list of open freight items to show up when I enter the carrier information

@UxSession
Scenario: Blank Form
	Given I have not entered anything in carrier name
	Then it should not display any open freight items

@UxSession
Scenario: Entered carrier information
	Given I have entered Tiny into carrier name
	Then it should display open freight items on the screen
