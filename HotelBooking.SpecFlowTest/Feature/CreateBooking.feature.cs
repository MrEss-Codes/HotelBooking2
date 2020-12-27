﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.4.0.0
//      SpecFlow Generator Version:3.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace HotelBooking.SpecFlowTest.Feature
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class CreateBookingFeature : object, Xunit.IClassFixture<CreateBookingFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "CreateBooking.feature"
#line hidden
        
        public CreateBookingFeature(CreateBookingFeature.FixtureData fixtureData, HotelBooking_SpecFlowTest_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Feature", "CreateBooking", "\tIn order to rest pecefully on my holidays\r\n\tAs a hotel customer\r\n\tI want to know" +
                    " if booking my room was successful", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableTheoryAttribute(DisplayName="Book a room for period of time")]
        [Xunit.TraitAttribute("FeatureTitle", "CreateBooking")]
        [Xunit.TraitAttribute("Description", "Book a room for period of time")]
        [Xunit.TraitAttribute("Category", "mytag")]
        [Xunit.InlineDataAttribute("11/9/2020", "11/9/2020", "true", new string[0])]
        [Xunit.InlineDataAttribute("11/16/2020", "11/16/2020", "true", new string[0])]
        [Xunit.InlineDataAttribute("11/9/2020", "11/16/2020", "false", new string[0])]
        [Xunit.InlineDataAttribute("11/9/2020", "11/10/2020", "false", new string[0])]
        [Xunit.InlineDataAttribute("11/9/2020", "11/15/2020", "false", new string[0])]
        [Xunit.InlineDataAttribute("11/10/2020", "11/16/2020", "false", new string[0])]
        [Xunit.InlineDataAttribute("11/15/2020", "11/16/2020", "false", new string[0])]
        [Xunit.InlineDataAttribute("11/10/2020", "11/10/2020", "false", new string[0])]
        [Xunit.InlineDataAttribute("11/10/2020", "11/15/2020", "false", new string[0])]
        [Xunit.InlineDataAttribute("11/15/2020", "11/15/2020", "false", new string[0])]
        public virtual void BookARoomForPeriodOfTime(string startDate, string endDate, string result, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "mytag"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("startDate", startDate);
            argumentsOfScenario.Add("endDate", endDate);
            argumentsOfScenario.Add("result", result);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Book a room for period of time", null, tagsOfScenario, argumentsOfScenario);
#line 7
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 8
 testRunner.Given(string.Format("I have entered a start date {0}", startDate), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 9
 testRunner.And(string.Format("I have entered an end date {0}", endDate), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 10
 testRunner.When("I book a room", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
 testRunner.Then(string.Format("I want to know if there are available rooms {0}", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.4.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                CreateBookingFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                CreateBookingFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion