﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.2.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Yol.Punla.UnitTest.Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("WikiPage")]
    public partial class WikiPageFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "WikiPage.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "WikiPage", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 3
#line 4
 testRunner.Given("I am not authenticated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 5
  testRunner.And("I am on the page \"WikiPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 6
  testRunner.And("the menu detail is closed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 7
 testRunner.When("I tap the hamburger icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 8
 testRunner.Then("I should see the menu detail is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 9
 testRunner.When("I tap the Useful Stuff item from the menu detail", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.Then("I am redirected to the page \"WikiPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 11
  testRunner.And("I should see a list of Wikis and the wiki with title \"Depression in Philippines\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Navigating to WikiDetailsPage and Back")]
        [NUnit.Framework.TestCaseAttribute("Depression in Philippines", "<h3>Depression in Philippines</h3>", "<html><body style=\'background-color:#F5F5F5\'><h3>Depression in Philippines</h3><p" +
            ">We are top 1 in Asia in terms of depression</p></body></html>", null)]
        [NUnit.Framework.TestCaseAttribute("Mental health law to help fight illegal drugs", "<h3>Mental health law to help fight illegal drugs</h3>", "<html><body style=\'background-color:#F5F5F5\'><h3>Mental health law to help fight " +
            "illegal drugs</h3><p>Senator Risa Hontiveros believes passing a Mental Health La" +
            "w would also help the country fight illegal drugs.</p><p>Hontiveros said illegal" +
            " drugs, which also deals with addiction, is not only a law enforcement issue but" +
            " also a public health issue. &quot;<i>We should look at it also as a public heal" +
            "th problem, hindi lang law enforcement. At sa ilalim niyan, mental health proble" +
            "m nga,&quot;</i> she told ANC on Monday.</p><p>The senator said the <i>Mental He" +
            "alth Bill</i>, which was recently passed on third reading at the Senate, will he" +
            "lp patients become fully-functioning members of the society again. According to " +
            "Hontiveros, mental health remains a concern as data show 7 Filipinos commit suic" +
            "ide everyday. She added that people with mental health concerns also suffer stig" +
            "ma from society.</p><p>Under the <i>Philippine Mental Health Act of 2017</i>, sh" +
            "e said, mental health will be integrated into the school curriculum to reduce di" +
            "scrimination of patients. Hontiveros added that the Department of Health is mand" +
            "ated to increase mental health professionals in the country under the proposed m" +
            "easure.<i>&quot;May isang pag-aaral na half of all adult Filipinos consulting he" +
            "alth professionals in rural areas, kalahati, may nade-detect na mental health pr" +
            "oblem dahil sa kakulangan ng pagkakataon para magpa-checkup,&quot;</i> she said." +
            "</p><p>Hontiveros hopes the House of Representatives will be able to pass its ve" +
            "rsion of the Mental Health Bill this year.</p></body></html>", null)]
        public virtual void NavigatingToWikiDetailsPageAndBack(string title, string wikiTitle, string content, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Navigating to WikiDetailsPage and Back", exampleTags);
#line 13
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 14
 testRunner.Given("I am on the page \"WikiPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 15
  testRunner.And("I can see a list of Wikis and the wiki with title \"Depression in Philippines\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
 testRunner.When(string.Format("I tap the item with title \"{0}\"", title), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 17
 testRunner.Then("I am redirected to the page \"WikiDetailsPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 18
  testRunner.And(string.Format("I can see the title of the wiki \"{0}\" with content \"{1}\"", wikiTitle, content), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.When("I tap the back icon from WikiDetailsPage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
 testRunner.Then("I am redirected to the page \"WikiPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 21
  testRunner.And("I should see a list of Wikis and the wiki with title \"Depression in Philippines\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Tapping the Sort Modal")]
        public virtual void TappingTheSortModal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Tapping the Sort Modal", ((string[])(null)));
#line 28
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 29
 testRunner.Given("I am on the page \"WikiPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 30
  testRunner.And("I can see a list of Wikis and the wiki with title \"Depression in Philippines\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.When("I tap the Sort tab above the wiki list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
 testRunner.Then("I should see the wiki sort modal appear", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 33
 testRunner.When("I tap the close icon of the wiki sort modal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
 testRunner.Then("the wiki sort modal should disappear", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Tapping the Filter Modal")]
        public virtual void TappingTheFilterModal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Tapping the Filter Modal", ((string[])(null)));
#line 36
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 37
 testRunner.Given("I am on the page \"WikiPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 38
  testRunner.And("I can see a list of Wikis and the wiki with title \"Depression in Philippines\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.When("I tap the Filter tab above the wiki list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
 testRunner.Then("I should see the wiki filter modal appear", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 41
 testRunner.When("I tap the close icon of the wiki filter modal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 42
 testRunner.Then("the wiki filter modal should disappear", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Sorting the wiki page alphabetically")]
        public virtual void SortingTheWikiPageAlphabetically()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sorting the wiki page alphabetically", ((string[])(null)));
#line 44
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 45
 testRunner.Given("I am on the page \"WikiPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 46
  testRunner.And("I could see the first item title \"Depression in Philippines\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
  testRunner.And("I could see that the wiki sort dialog is not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
 testRunner.When("I tap the sort button at the top in the wiki page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 49
 testRunner.Then("I should see the wiki sort dialog is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 50
 testRunner.When("I choose the option alphabetically and tap the sort button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 51
 testRunner.Then("I should see the first item title \"1 out of 5 Filipinos suffer from depression\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Sorting the wiki page alphabetically but didnt select the alphabetical input")]
        public virtual void SortingTheWikiPageAlphabeticallyButDidntSelectTheAlphabeticalInput()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sorting the wiki page alphabetically but didnt select the alphabetical input", ((string[])(null)));
#line 53
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 54
 testRunner.Given("I am on the page \"WikiPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 55
  testRunner.And("I could see the first item title \"Depression in Philippines\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
  testRunner.And("I could see that the wiki sort dialog is not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
 testRunner.When("I tap the sort button at the top in the wiki page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 58
 testRunner.Then("I should see the wiki sort dialog is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 59
 testRunner.When("I choose the tap the sort button without choosing alphabetical input", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 60
 testRunner.Then("I should see the wiki page alert error \"Please select a sort item.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Forcing a user to download a new version of the app")]
        [NUnit.Framework.TestCaseAttribute("Depression in Philippines", "<h3>Depression in Philippines</h3>", "<html><body style=\'background-color:#F5F5F5\'><h3>Depression in Philippines</h3><p" +
            ">We are top 1 in Asia in terms of depression</p></body></html>", "Welcome to HopePH.", "Sorry for the inconvenience but please download the latest version now.", null)]
        public virtual void ForcingAUserToDownloadANewVersionOfTheApp(string title, string wikiTitle, string content, string defaultAddMessage, string newAddMessage, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Forcing a user to download a new version of the app", exampleTags);
#line 69
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 70
 testRunner.Given("I am on the page \"WikiPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 71
  testRunner.And("I can see a list of Wikis and the wiki with title \"Depression in Philippines\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
  testRunner.And(string.Format("I could see the ad message \"{0}\"", defaultAddMessage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
  testRunner.And("I could see the current app version no \"1.9\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 74
 testRunner.When(string.Format("I tap the item with title \"{0}\"", title), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 75
 testRunner.Then("I am redirected to the page \"WikiDetailsPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 76
  testRunner.And(string.Format("I can see the title of the wiki \"{0}\" with content \"{1}\"", wikiTitle, content), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 77
 testRunner.When("I tap the back icon from WikiDetailsPage and the app force to download to version" +
                    " no was updated to \"1.10\" from server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 78
 testRunner.Then("I am redirected to the page \"WikiPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 79
  testRunner.And(string.Format("I should see the pop message \"{0}\"", newAddMessage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion