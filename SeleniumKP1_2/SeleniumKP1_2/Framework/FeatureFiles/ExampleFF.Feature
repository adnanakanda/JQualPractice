
Feature: Data Table Test
    As a user
    I want to verify data in the sortable data table
    So that I can confirm the data is correct

  Scenario: Verify data in the sortable data table
	Given Herokuapp website is open
    Then the main page is displayed
    When I find the 'fbach@yahoo.com' email
    Then The 'fbach@yahoo.com' is on the table
        And the table has the following first names:
        | FirstName |
        | John      |
        | Frank     |
        | Jason     |
        | Tim       |
