Feature: HexTemplate
!This is a map of hexagons next to each other. We are supposed to transverse the map.

@mytag
Scenario: Parsable Line
	Given the line: neenesew
	Then it can be parsed

Scenario: Un-parsable Line due to incorrect order
	Given the line: nenenesess
	Then it can't be parsed

Scenario: Un-parsable Line due to incorrect letter
	Given the line: nenez
	Then it can't be parsed


Scenario: MovementEast
	Given you are at the origin
	When you go E
	Then it moves to (2,0)

Scenario: MovementWest
	Given you are at the origin
	When you go W
	Then it moves to (-2,0)

Scenario: MovementNorthEast
	Given you are at the origin
	When you go NE
	Then it moves to (1,1)

Scenario: MovementNorthWest
	Given you are at the origin
	When you go NW
	Then it moves to (-1,1)

Scenario: MovementSouthEast
	Given you are at the origin
	When you go SE
	Then it moves to (1,-1)

Scenario: MovementSouthWest
	Given you are at the origin
	When you go SW
	Then it moves to (-1,-1)


Scenario: Final Destination 1
	Given the line: neseew
	When you read the line
	Then you end up at (2,0)

Scenario: Final Destination 2
	Given the line: wwwweee
	When you read the line
	Then you end up at (-2,0)

Scenario: Final Destination 3
	Given the line: nesesesw
	When you read the line
	Then you end up at (2,-2)