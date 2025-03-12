


@Calculator
Feature: Calculator

Simple calculator for adding two numbers

@DataSourceScenarioTag
@DataSource:..\TestData\testdata.csv
Scenario: Add two numbers
	Given the first number is 50

@ScenarioOutlineTag
Scenario Outline: Add two numbers outline
	Given the first number is 50	
	Examples: 
			|testdata|
			| firstData  |
			| secondData |
			| thirdData  |

@ScenarioTag
Scenario: Add two numbers firstData
	Given the first number is 50

@ScenarioTag	
Scenario: Add two numbers secondData
	Given the first number is 50

@ScenarioTag	
Scenario: Add two numbers thirdData
	Given the first number is 50