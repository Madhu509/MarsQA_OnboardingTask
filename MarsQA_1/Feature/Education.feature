﻿Feature: SpecFlowFeature1
	User Should be able to Add,Update and Delete Education Details

@mytag
Scenario: Add Education
	Given The User Clicks on Education Tab
	When the user Adds the New Education details and Clicks on Add button
	And  the user Clicks on Add button then education details should be added
	


Scenario: Edit Certificate
	Given The User is on Education Tab
	When the user  Edits the Education details and click on update button
	Then the Education Details should be Updated and should be seen by User


Scenario: Delete Certificate
	Given The User is on Education Tab
	When the user deletes the Education
	Then the Education details should be deleted.