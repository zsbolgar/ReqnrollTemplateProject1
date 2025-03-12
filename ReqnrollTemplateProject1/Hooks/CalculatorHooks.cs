using NUnit.Framework;
using Reqnroll;

namespace ReqnrollTemplateProject1.Hooks
{
    [Binding]
    public class CalculatorHooks : Steps
    {
        // For additional details on Reqnroll hooks see https://go.reqnroll.net/doc-hooks

        private static ScenarioContext _scenarioContext;
        private static FeatureContext _featureContext;

        public CalculatorHooks(ScenarioContext scenarioContext, FeatureContext featureContext)
        {
            _scenarioContext = scenarioContext;
            _featureContext = featureContext;
        }


        
        [AfterScenario("DataSourceScenarioTag")]
        public void AfterDataSourceScenario()
        {
            Assert.Fail($"throw assert exception of {_scenarioContext.ScenarioInfo.Arguments["testdata"].ToString()}");
        }

        [AfterScenario("ScenarioOutlineTag")]
        public void AfterScenarioOutline()
        {
            Assert.Fail($"throw assert exception of {_scenarioContext.ScenarioInfo.Arguments["testdata"].ToString()}");
        }

        [AfterScenario("ScenarioTag")]
        public void AfterScenario()
        {
            Assert.Fail($"throw assert exception");
        }


        [AfterFeature("Calculator")]
        public static void AfterFeature(FeatureContext featureContext)
        {
            Console.WriteLine("AfterFeature is called");
        }
    }
}