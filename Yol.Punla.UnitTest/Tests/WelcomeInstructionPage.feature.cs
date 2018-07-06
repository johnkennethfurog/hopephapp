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
    [NUnit.Framework.DescriptionAttribute("WelcomeInstructionPage")]
    public partial class WelcomeInstructionPageFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "WelcomeInstructionPage.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "WelcomeInstructionPage", "\tThis is the first page the user will be \r\n\tnavigated to when he / she run the ap" +
                    "p\r\n\tfor the first time.\r\n\r\n\tRunning again the app after that will not\r\n\tnavigate" +
                    " the user to the WelcomeInstructionPage\r\n\tagain.", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Running the app for the first time")]
        [NUnit.Framework.CategoryAttribute("tag")]
        [NUnit.Framework.CategoryAttribute("WelcomeInstructionIsNotLoadedYet")]
        public virtual void RunningTheAppForTheFirstTime()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Running the app for the first time", new string[] {
                        "tag",
                        "WelcomeInstructionIsNotLoadedYet"});
#line 11
this.ScenarioSetup(scenarioInfo);
#line 12
 testRunner.Given("I am not authenticated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 13
  testRunner.And("I am on the page \"WelcomeInstructionsPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.Then("I should see the back arrow of the page grayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 15
  testRunner.And("I should see the instruction text \"You could post your feelings anonymously. When" +
                    " you post only your alias is shown.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Navigating to the second page of the instructions page")]
        [NUnit.Framework.CategoryAttribute("tag")]
        [NUnit.Framework.CategoryAttribute("WelcomeInstructionIsNotLoadedYet")]
        public virtual void NavigatingToTheSecondPageOfTheInstructionsPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Navigating to the second page of the instructions page", new string[] {
                        "tag",
                        "WelcomeInstructionIsNotLoadedYet"});
#line 18
this.ScenarioSetup(scenarioInfo);
#line 19
 testRunner.Given("I am on the page \"WelcomeInstructionsPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 20
  testRunner.And("I could see the instruction text \"You could post your feelings anonymously. When " +
                    "you post only your alias is shown.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
  testRunner.And("the back button is grayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.When("I tap the forward arrow", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
 testRunner.Then("I should see the instruction text \"If you wish to see a local psychologist or psy" +
                    "chiatrist, you could browse the mental care facilities section. You could sort t" +
                    "hem by location and, you could also call their tel nos straight away.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 24
  testRunner.And("I should see the back button is enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Navigating back to the previous instruction page from last instruction")]
        [NUnit.Framework.CategoryAttribute("tag")]
        [NUnit.Framework.CategoryAttribute("WelcomeInstructionIsNotLoadedYet")]
        public virtual void NavigatingBackToThePreviousInstructionPageFromLastInstruction()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Navigating back to the previous instruction page from last instruction", new string[] {
                        "tag",
                        "WelcomeInstructionIsNotLoadedYet"});
#line 27
this.ScenarioSetup(scenarioInfo);
#line 28
 testRunner.Given("I am on the page \"WelcomeInstructionsPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 29
  testRunner.And("I could see the instruction text \"You could post your feelings anonymously. When " +
                    "you post only your alias is shown.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
  testRunner.And("I should see the back arrow of the page grayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.When("I tap the forward arrow three times", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
 testRunner.Then("I should see the instruction text \"Signing up with facebook or signing up with al" +
                    "iasname only are provided. Your privacy and data security is our top priority.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 33
 testRunner.When("I tap the back arrow", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
 testRunner.Then("I should see the instruction text \"If you are in crisis or your family or friends" +
                    ", you can browse to the directory of crisis providers section. You could easily " +
                    "tap and call their tel nos.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 35
  testRunner.And("I should see the back button is enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Navigating back to the previous instruction page from third instruction")]
        [NUnit.Framework.CategoryAttribute("tag")]
        [NUnit.Framework.CategoryAttribute("WelcomeInstructionIsNotLoadedYet")]
        public virtual void NavigatingBackToThePreviousInstructionPageFromThirdInstruction()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Navigating back to the previous instruction page from third instruction", new string[] {
                        "tag",
                        "WelcomeInstructionIsNotLoadedYet"});
#line 38
this.ScenarioSetup(scenarioInfo);
#line 39
 testRunner.Given("I am on the page \"WelcomeInstructionsPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 40
  testRunner.And("I could see the instruction text \"You could post your feelings anonymously. When " +
                    "you post only your alias is shown.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
  testRunner.And("I should see the back arrow of the page grayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
 testRunner.When("I tap the forward arrow two times", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 43
 testRunner.Then("I should see the instruction text \"If you are in crisis or your family or friends" +
                    ", you can browse to the directory of crisis providers section. You could easily " +
                    "tap and call their tel nos.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 44
 testRunner.When("I tap the back arrow", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 45
 testRunner.Then("I should see the instruction text \"If you wish to see a local psychologist or psy" +
                    "chiatrist, you could browse the mental care facilities section. You could sort t" +
                    "hem by location and, you could also call their tel nos straight away.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 46
  testRunner.And("I should see the back button is enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Navigating back to the previous instruction page from second instruction")]
        [NUnit.Framework.CategoryAttribute("tag")]
        [NUnit.Framework.CategoryAttribute("WelcomeInstructionIsNotLoadedYet")]
        public virtual void NavigatingBackToThePreviousInstructionPageFromSecondInstruction()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Navigating back to the previous instruction page from second instruction", new string[] {
                        "tag",
                        "WelcomeInstructionIsNotLoadedYet"});
#line 49
this.ScenarioSetup(scenarioInfo);
#line 50
 testRunner.Given("I am on the page \"WelcomeInstructionsPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 51
  testRunner.And("I could see the instruction text \"You could post your feelings anonymously. When " +
                    "you post only your alias is shown.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
  testRunner.And("I should see the back arrow of the page grayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
 testRunner.When("I tap the forward arrow", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 54
 testRunner.Then("I should see the instruction text \"If you wish to see a local psychologist or psy" +
                    "chiatrist, you could browse the mental care facilities section. You could sort t" +
                    "hem by location and, you could also call their tel nos straight away.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 55
 testRunner.When("I tap the back arrow", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 56
 testRunner.Then("I should see the instruction text \"You could post your feelings anonymously. When" +
                    " you post only your alias is shown.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 57
  testRunner.And("I should see the back arrow of the page grayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Navigating to WikiPage via tapping the forward arrow in the last instruction text" +
            "")]
        [NUnit.Framework.CategoryAttribute("tag")]
        [NUnit.Framework.CategoryAttribute("WelcomeInstructionIsNotLoadedYet")]
        public virtual void NavigatingToWikiPageViaTappingTheForwardArrowInTheLastInstructionText()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Navigating to WikiPage via tapping the forward arrow in the last instruction text" +
                    "", new string[] {
                        "tag",
                        "WelcomeInstructionIsNotLoadedYet"});
#line 60
this.ScenarioSetup(scenarioInfo);
#line 61
 testRunner.Given("I am on the page \"WelcomeInstructionsPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 62
  testRunner.And("I could see the instruction text \"You could post your feelings anonymously. When " +
                    "you post only your alias is shown.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 63
  testRunner.And("I should see the back arrow of the page grayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
 testRunner.When("I tap the forward arrow three times", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 65
 testRunner.Then("I should see the instruction text \"Signing up with facebook or signing up with al" +
                    "iasname only are provided. Your privacy and data security is our top priority.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 66
  testRunner.And("I should see the back button is enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
 testRunner.When("I tap the forward arrow", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 68
 testRunner.Then("I am redirected to the page \"WikiPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion