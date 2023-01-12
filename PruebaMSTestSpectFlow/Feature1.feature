Feature: Feature1

A short summary of the feature

@tag1
Scenario: Sacar Dinero Teniendo 0 Balance
	Given cuenta bancaria con balance 0 
	When cuando saco 5 pavos
	Then obtener un error
