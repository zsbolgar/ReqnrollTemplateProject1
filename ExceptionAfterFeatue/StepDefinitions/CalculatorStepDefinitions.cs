namespace ExceptionAfterFeature.StepDefinitions
{
    [Binding]
    public class CalculatorStepDefinitions : Steps
    {
        // For additional details on Reqnroll step definitions see https://go.reqnroll.net/doc-stepdef

        [Given("the first number is {int}")]
        public void GivenTheFirstNumberIs(int number)
        {
            Console.WriteLine($"The first number is {number}");
        }

    }
}
