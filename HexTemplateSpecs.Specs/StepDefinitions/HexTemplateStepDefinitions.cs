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
            context.Add("line", line); //Probably something like this.
        }

        [When(@"the text is parsed")]
        public void WhenTheTextIsParsed()
        {
            throw new PendingStepException();
        }

        [Then(@"it can be parsed")]
        public void ThenItCanBeParsed()
        {
            throw new PendingStepException();
        }

        [Then(@"it can't be parsed")]
        public void ThenItCantBeParsed()
        {
            throw new PendingStepException();
        }

        [Given(@"you are at the origin")]
        public void GivenYouAreAtTheOrigin()
        {
            throw new PendingStepException();
        }

        [When(@"you go E")]
        public void WhenYouGoE()
        {
            throw new PendingStepException();
        }

        [When(@"you go W")]
        public void WhenYouGoW()
        {
            throw new PendingStepException();
        }

        [When(@"you go NE")]
        public void WhenYouGoNE()
        {
            throw new PendingStepException();
        }

        [When(@"you go NW")]
        public void WhenYouGoNW()
        {
            throw new PendingStepException();
        }

        [When(@"you go SE")]
        public void WhenYouGoSE()
        {
            throw new PendingStepException();
        }

        [When(@"you go SW")]
        public void WhenYouGoSW()
        {
            throw new PendingStepException();
        }

        [Then(@"it moves to \((.*)\)")]
        public void ThenItMovesTo((int, int) coordinate)
        {
            throw new PendingStepException();
        }

        //[Then(@"it moves to \((.*),(.*)\)")] //This could end up being a useful step definition so I left it commented out for now.
        //public void ThenItMovesTo(int p0, int p1)
        //{
        //    throw new PendingStepException();
        //}

        [Then(@"you end up at \((.*)\)")]
        public void ThenYouEndUpAt((int, int) coordinate)
        {
            throw new PendingStepException();
        }

        //[Then(@"you end up at \((.*),(.*)\)")] //This could end up being a useful step definition so I left it commented out for now.
        //public void ThenYouEndUpAt(int p0, int p1)
        //{
        //    throw new PendingStepException();
        //}

        [When(@"you read the line")]
        public void WhenYouReadTheLine()
        {
            throw new PendingStepException();
        }
    }
}