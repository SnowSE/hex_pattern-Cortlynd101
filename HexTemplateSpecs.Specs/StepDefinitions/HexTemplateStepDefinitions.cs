using hex_template;

namespace HexTemplateSpecs.Specs.StepDefinitions
{
    [Binding]
    public sealed class HexTemplateStepDefinitions
    {
        private readonly ScenarioContext context;
        public HexTemplateStepDefinitions(ScenarioContext context)
        {
            this.context = context;
        }

        [Given(@"the line: (.*)")]
        public void GivenTheLine(string line)
        {
            (int, int) coordinate = (0, 0);
            context.Add("coordinate", coordinate); //It needs to add coordinate to the dictionary for future tests.

            context.Remove("line");
            context.Add("line", line);
        }

        [Then(@"it can be parsed")]
        public void ThenItCanBeParsed()
        {
            bool parsedOrNot = MovementMethods.canParseLine(context.Get<string>("line"));
            parsedOrNot.Should().BeTrue();
        }

        [Then(@"it can't be parsed")]
        public void ThenItCantBeParsed()
        {
            bool parsedOrNot = MovementMethods.canParseLine(context.Get<string>("line"));
            parsedOrNot.Should().BeFalse();
        }

        [Given(@"you are at the origin")]
        public void GivenYouAreAtTheOrigin()
        {
            (int, int) coordinate = (0, 0);
            context.Add("coordinate", coordinate);
        }

        [When(@"you go E")]
        public void WhenYouGoE()
        {
            (int, int) coordinate = context.Get<(int, int)>("coordinate");
            coordinate = MovementMethods.moveEast(coordinate);

            context.Remove("coordinate");
            context.Add("coordinate", coordinate);
        }

        [When(@"you go W")]
        public void WhenYouGoW()
        {
            (int, int) coordinate = context.Get<(int, int)>("coordinate");
            coordinate = MovementMethods.moveWest(coordinate);

            context.Remove("coordinate");
            context.Add("coordinate", coordinate);
        }

        [When(@"you go NE")]
        public void WhenYouGoNE()
        {
            (int, int) coordinate = context.Get<(int, int)>("coordinate");
            coordinate = MovementMethods.moveNorthEast(coordinate);

            context.Remove("coordinate");
            context.Add("coordinate", coordinate);
        }

        [When(@"you go NW")]
        public void WhenYouGoNW()
        {
            (int, int) coordinate = context.Get<(int, int)>("coordinate");
            coordinate = MovementMethods.moveNorthWest(coordinate);

            context.Remove("coordinate");
            context.Add("coordinate", coordinate);
        }

        [When(@"you go SE")]
        public void WhenYouGoSE()
        {
            (int, int) coordinate = context.Get<(int, int)>("coordinate");
            coordinate = MovementMethods.moveSouthEast(coordinate);

            context.Remove("coordinate");
            context.Add("coordinate", coordinate);
        }

        [When(@"you go SW")]
        public void WhenYouGoSW()
        {
            (int, int) coordinate = context.Get<(int, int)>("coordinate");
            coordinate = MovementMethods.moveSouthWest(coordinate);

            context.Remove("coordinate");
            context.Add("coordinate", coordinate);
        }

        [Then(@"it moves to \((.*),(.*)\)")] 
        public void ThenItMovesTo(int p0, int p1)
        {
            context.Get<(int, int)>("coordinate").Item1.Should().Be(p0);
            context.Get<(int, int)>("coordinate").Item2.Should().Be(p1);
        }

        [Then(@"you end up at \((.*),(.*)\)")] 
        public void ThenYouEndUpAt(int p0, int p1)
        {
            context.Get<(int, int)>("coordinate").Item1.Should().Be(p0);
            context.Get<(int, int)>("coordinate").Item2.Should().Be(p1);
        }

        [When(@"you read the line")]
        public void WhenYouReadTheLine()
        {
            (int, int) coordinate = context.Get<(int, int)>("coordinate");
            coordinate = MovementMethods.moveThroughLine(coordinate, context.Get<string>("line"));

            context.Remove("coordinate");
            context.Add("coordinate", coordinate);
        }
    }
}