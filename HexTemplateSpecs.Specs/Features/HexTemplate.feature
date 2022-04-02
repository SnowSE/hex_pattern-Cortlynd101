Feature: HexTemplate
!This is a map of hexagons next to each other. We are supposed to transverse the map.

@mytag
Scenario: Parsed Line
	Given the line: "neenesew"
	When the text is parsed
	Then it can be parsed

	Given the line: "nenenesess"
	When the text is parsed
	Then it can't be parsed

	Given the line: "nenez"
	When the text is parsed
	Then it can't be parsed


Scenario: Movement
	Given you are at the origin
	When you go E
	Then it moves to (2,0)

	Given you are at the origin
	When you go W
	Then it moves to (-2,0)

	Given you are at the origin
	When you go NE
	Then it moves to (1,1)

	Given you are at the origin
	When you go NW
	Then it moves to (-1,1)

	Given you are at the origin
	When you go SE
	Then it moves to (1,-1)

	Given you are at the origin
	When you go SW
	Then it moves to (-1,-1)


Scenario: Final Destinations
	Given the line: neseew
	When you read the line
	Then you end up at (2,0)

	Given the line: wwwweee
	When you read the line
	Then you end up at (-2,0)

	Given the line: nesesesw
	When you read the line
	Then you end up at (2,-2)