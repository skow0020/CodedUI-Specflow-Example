﻿Feature: Calc
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Scenario Outline: Add Two Numbers
    Given the calculator app is open
    And I have entered <SummandOne> into calculator
    And I press plus
    And I have entered <SummandTwo> into calculator
    When I press equal
    Then the result should be <Result> on the screen

	Scenarios:
        | SummandOne | SummandTwo | Result |
        | 50         | 70         | 120    |
        | 1          | 10         | 11     |
