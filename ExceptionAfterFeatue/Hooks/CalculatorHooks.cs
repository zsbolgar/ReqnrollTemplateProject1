using NUnit.Framework;
using Reqnroll;

namespace ReqnrollTemplateProject1.Hooks
{
    [Binding]
    public class CalculatorHooks : Steps
    {
        // For additional details on Reqnroll hooks see https://go.reqnroll.net/doc-hooks

        private static ScenarioContext _scenarioContext;

        public CalculatorHooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }


        [AfterFeature("HereHaveException")]
        public static void AfterFeatureException()
        {
            throw new ArgumentException("throw just an exception in AfterFeature method");
        }
    }
}