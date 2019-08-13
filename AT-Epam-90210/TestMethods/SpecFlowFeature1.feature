Feature: SpecFlowFeature1
	In order to interact with GetInTouchForm
	As a User
	I want to fill all the fields and take a screenshot or leave some fields empty and try to submit

@mytag
Scenario: Fill the form and take a screenshot
	Given I go to https://www.lipsum.com page
	And I get the sample of Lorem Ipsum text of the length <length> bytes
	And I go to https://www.bbc.com page
	When I navigate to Do You Have a Question Page
	And I put my Lorem Ipsum text in a question field 
	And I sign up for BBC News Daily
	And I provide all required fields with my personal information 	
	Then I get the screenshot

	Examples:
		| length |
		| 140    |
		| 141    |


Scenario: Fill the form with empty Name field and try to submit
	Given I go to https://www.lipsum.com page
	And I get the sample of Lorem Ipsum text of the length <length> bytes
	And I go to https://www.bbc.com page	
	When I navigate to Do You Have a Question Page
	And I put my Lorem Ipsum text in a question field 
	And I sign up for BBC News Daily
	And I provide required fields with my personal information except of my Name	
	And I try to submit
	Then I get a name error message

	Examples:
		| length |
		| 140    |			


Scenario: Fill the form with empty Email field and try to submit
	Given I go to https://www.lipsum.com page
	And I get the sample of Lorem Ipsum text of the length <length> bytes
	And I go to https://www.bbc.com page	
	When I navigate to Do You Have a Question Page
	And I put my Lorem Ipsum text in a question field 
	And I sign up for BBC News Daily
	And I provide required fields with my personal information except of my email		
	And I try to submit
	Then I get an email error message

	Examples:
		| length |
		| 140    |

	
