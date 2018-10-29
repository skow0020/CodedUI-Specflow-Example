Feature: Example

@ExampleTag
Scenario Outline: Example scenario outline
	Given I am logged in
	When I do something cool with '<Property>'
	Then something exciting is verified
	Examples: 
	| Property         |
	| example_property |