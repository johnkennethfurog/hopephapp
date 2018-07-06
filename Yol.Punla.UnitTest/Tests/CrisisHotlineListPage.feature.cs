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
    [NUnit.Framework.DescriptionAttribute("CrisisHotlineListPage")]
    public partial class CrisisHotlineListPageFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CrisisHotlineListPage.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CrisisHotlineListPage", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Navigating to the Crisis Page not yet authenticated")]
        public virtual void NavigatingToTheCrisisPageNotYetAuthenticated()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Navigating to the Crisis Page not yet authenticated", ((string[])(null)));
#line 3
this.ScenarioSetup(scenarioInfo);
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
 testRunner.When("I tap the Crisis icon from the menu detail", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.Then("I should see a message saying the user to sign up \"When logging in your profile w" +
                    "ill still remain anonymous to the other users.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 11
  testRunner.And("I am redirected to the page \"LogonPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Dialing the phone number from the Crisis Page not yet authenticated")]
        public virtual void DialingThePhoneNumberFromTheCrisisPageNotYetAuthenticated()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Dialing the phone number from the Crisis Page not yet authenticated", ((string[])(null)));
#line 13
this.ScenarioSetup(scenarioInfo);
#line 14
 testRunner.Given("I am not authenticated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 15
  testRunner.And("I am on the page \"WikiPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
  testRunner.And("the menu detail is closed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
 testRunner.When("I tap the hamburger icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
 testRunner.Then("I should see the menu detail is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 19
 testRunner.When("I tap the Crisis icon from the menu detail", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
 testRunner.Then("I should see a message saying the user to sign up \"When logging in your profile w" +
                    "ill still remain anonymous to the other users.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 21
  testRunner.And("I am redirected to the page \"LogonPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Navigating to the Crisis Page authenticated")]
        [NUnit.Framework.CategoryAttribute("tag")]
        [NUnit.Framework.CategoryAttribute("FacebookLogonViaCrisisMenu")]
        public virtual void NavigatingToTheCrisisPageAuthenticated()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Navigating to the Crisis Page authenticated", new string[] {
                        "tag",
                        "FacebookLogonViaCrisisMenu"});
#line 24
this.ScenarioSetup(scenarioInfo);
#line 25
 testRunner.Given("I am authenticated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 26
  testRunner.And("I am on the page \"CrisisHotlineListPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
 testRunner.Then("I should see \"028044673\" as one of the crisis hotline", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Dialing the phone number from the Crisis Page authenticated")]
        [NUnit.Framework.CategoryAttribute("tag")]
        [NUnit.Framework.CategoryAttribute("FacebookLogonViaCrisisMenu")]
        public virtual void DialingThePhoneNumberFromTheCrisisPageAuthenticated()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Dialing the phone number from the Crisis Page authenticated", new string[] {
                        "tag",
                        "FacebookLogonViaCrisisMenu"});
#line 30
this.ScenarioSetup(scenarioInfo);
#line 31
 testRunner.Given("I am authenticated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 32
  testRunner.And("I am on the page \"CrisisHotlineListPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
  testRunner.And("I should see \"028044673\" as one of the crisis hotline", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
 testRunner.When("I dial the hotline no \"028044673\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 35
 testRunner.Then("I should see the number \"028044673\" was added to the dialer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
