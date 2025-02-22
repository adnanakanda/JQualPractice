Feature: Data Table Test
	As a user
	I want to verify data in the sortable data table
	So that I can confirm the data is correct

Scenario: Verify data in the sortable data table
	Given The main page is open

	When I Click on 'Sortable Data Tables'
	Then Data Tables page is open

	When I find 'jsmith@gmail.com' in the second table 
		And I remember emails Web Site value
	Then The value is found and saved

	When I sort the table by First Name
	Then The table is sorted

	When Check that Web Site value saved on step 2 is still present in the table
	Then The saved value is still present

	When Check that Last Name are present on the column:
		| LastName |
		| Smith    |
		| Bach     |
		| Doe      |
		| Conway   |
	Then Values are present