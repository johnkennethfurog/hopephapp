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
    [NUnit.Framework.DescriptionAttribute("PostFeedPage")]
    public partial class PostFeedPageFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "PostFeedPage.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "PostFeedPage", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Navigating to the PostFeedPage")]
        [NUnit.Framework.CategoryAttribute("tag")]
        [NUnit.Framework.CategoryAttribute("FacebookLogonViaWriteYourThoughtsMenu")]
        public virtual void NavigatingToThePostFeedPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Navigating to the PostFeedPage", new string[] {
                        "tag",
                        "FacebookLogonViaWriteYourThoughtsMenu"});
#line 4
this.ScenarioSetup(scenarioInfo);
#line 5
 testRunner.Given("I am authenticated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
  testRunner.And("I am on the page \"PostFeedPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 7
 testRunner.Then("I should see a Post posted by \"Peter Smith\", with title \"Depression is something " +
                    "everyone should be aware of.\", and content \"According to @Glassdoor, these signs" +
                    " mean you\'re overthinking things at work:\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Navigating to PostFeedDetailsPage")]
        [NUnit.Framework.CategoryAttribute("tag")]
        [NUnit.Framework.CategoryAttribute("FacebookLogonViaWriteYourThoughtsMenu")]
        [NUnit.Framework.TestCaseAttribute("Peter Smith", "According to @Glassdoor, these signs mean you\'re overthinking things at work:", "1111", null)]
        [NUnit.Framework.TestCaseAttribute("Peter Smith", "Mental health is now on the final reading in the Congress. Sen. Riza Hotiveros pu" +
            "shes the bill.", "1112", null)]
        public virtual void NavigatingToPostFeedDetailsPage(string posterName, string content, string postFeedId, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "tag",
                    "FacebookLogonViaWriteYourThoughtsMenu"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Navigating to PostFeedDetailsPage", @__tags);
#line 10
this.ScenarioSetup(scenarioInfo);
#line 11
 testRunner.Given("I am authenticated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 12
  testRunner.And("I am on the page \"PostFeedPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
 testRunner.When(string.Format("I tap the comment icon of the post of \"{0}\" with content \"{1}\" and postFeedId \"{2" +
                        "}\"", posterName, content, postFeedId), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
 testRunner.Then("I am redirected to the page \"PostFeedDetailPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 15
  testRunner.And(string.Format("I can see the details of the post with author \"{0}\" and content \"{1}\"", posterName, content), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Opening and closing the PostOptionsModal")]
        [NUnit.Framework.CategoryAttribute("tag")]
        [NUnit.Framework.CategoryAttribute("FacebookLogonViaWriteYourThoughtsMenu")]
        [NUnit.Framework.TestCaseAttribute("Peter Smith", "1111", null)]
        public virtual void OpeningAndClosingThePostOptionsModal(string author, string postFeedId, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "tag",
                    "FacebookLogonViaWriteYourThoughtsMenu"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Opening and closing the PostOptionsModal", @__tags);
#line 23
this.ScenarioSetup(scenarioInfo);
#line 24
 testRunner.Given("I am authenticated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 25
  testRunner.And("I am on the page \"PostFeedPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.Then("I should see a Post posted by \"Peter Smith\", with title \"Depression is something " +
                    "everyone should be aware of.\", and content \"According to @Glassdoor, these signs" +
                    " mean you\'re overthinking things at work:\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 27
 testRunner.When(string.Format("I tap the ellipsis icon to show the post option modal at the left of the post of " +
                        "\"{0}\" with postFeedId \"{1}\"", author, postFeedId), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
 testRunner.Then("the PostOptions modal will appear", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 29
 testRunner.When("I tap the close icon of the PostOptions Modal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
 testRunner.Then("I should see the PostOptions modal disappear", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Editing a self post")]
        [NUnit.Framework.CategoryAttribute("tag")]
        [NUnit.Framework.CategoryAttribute("FacebookLogonViaWriteYourThoughtsMenu")]
        [NUnit.Framework.TestCaseAttribute("Haiyan Rbf", "New Post", "Newly added Post", "1120", "This is a edited post myself", null)]
        public virtual void EditingASelfPost(string author, string title, string content, string postFeedId, string message, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "tag",
                    "FacebookLogonViaWriteYourThoughtsMenu"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Editing a self post", @__tags);
#line 37
this.ScenarioSetup(scenarioInfo);
#line 38
 testRunner.Given("I am authenticated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 39
  testRunner.And("I am on the page \"PostFeedPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
 testRunner.Then(string.Format("I should see a Post posted by \"{0}\", with title \"{1}\", and content \"{2}\"", author, title, content), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 41
 testRunner.When(string.Format("I tap the ellipsis icon to show the post option modal at the left of the post of " +
                        "\"{0}\" with postFeedId \"{1}\"", author, postFeedId), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 42
 testRunner.Then("the PostOptions modal will appear", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 43
 testRunner.When("I tap the Edit menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 44
 testRunner.Then("I am redirected to the page \"PostFeedAddEditPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 45
  testRunner.And("I can see that the button text is \"Update\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
 testRunner.When(string.Format("I type edit the message to \"{0}\" and tap the update button", message), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 47
 testRunner.Then("I am redirected to the page \"PostFeedPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 48
  testRunner.And(string.Format("I should see my updated post with content \"{0}\", and author \"{1}\" and post id \"{2" +
                        "}\"", message, author, postFeedId), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Deleting a self post")]
        [NUnit.Framework.CategoryAttribute("tag")]
        [NUnit.Framework.CategoryAttribute("FacebookLogonViaWriteYourThoughtsMenu")]
        [NUnit.Framework.TestCaseAttribute("Haiyan Rbf", "New Post", "Newly added Post", "1120", null)]
        public virtual void DeletingASelfPost(string author, string title, string content, string postFeedId, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "tag",
                    "FacebookLogonViaWriteYourThoughtsMenu"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deleting a self post", @__tags);
#line 55
this.ScenarioSetup(scenarioInfo);
#line 56
 testRunner.Given("I am authenticated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 57
  testRunner.And("I am on the page \"PostFeedPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
 testRunner.Then(string.Format("I should see a Post posted by \"{0}\", with title \"{1}\", and content \"{2}\"", author, title, content), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 59
 testRunner.When(string.Format("I tap the ellipsis icon to show the post option modal at the left of the post of " +
                        "\"{0}\" with postFeedId \"{1}\"", author, postFeedId), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 60
 testRunner.Then("the PostOptions modal will appear", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 61
 testRunner.When("I tap the Delete menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 62
 testRunner.Then("The delete post feed request should be sent to the hub", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 63
  testRunner.And("I should stay on the same page \"PostFeedPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Navigating to PostFeedAddPage")]
        [NUnit.Framework.CategoryAttribute("tag")]
        [NUnit.Framework.CategoryAttribute("FacebookLogonViaWriteYourThoughtsMenu")]
        [NUnit.Framework.TestCaseAttribute("https://graph.facebook.com/168866520312631/picture?height=220&width=220&migration" +
            "_overrides=%7Boctober_2012%3Atrue%7D", null)]
        public virtual void NavigatingToPostFeedAddPage(string photoUrl, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "tag",
                    "FacebookLogonViaWriteYourThoughtsMenu"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Navigating to PostFeedAddPage", @__tags);
#line 70
this.ScenarioSetup(scenarioInfo);
#line 71
 testRunner.Given("I am authenticated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 72
  testRunner.And("I am on the page \"PostFeedPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
 testRunner.When("I tap the text Share an article, photo, video or idea", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 74
 testRunner.Then("I am redirected to the page \"PostFeedAddEditPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 75
  testRunner.And(string.Format("I can see the photo Url of the current user is \"{0}\"", photoUrl), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Tapping the close button at the left side of the navigation bar")]
        [NUnit.Framework.CategoryAttribute("tag")]
        [NUnit.Framework.CategoryAttribute("FacebookLogonViaWriteYourThoughtsMenu")]
        public virtual void TappingTheCloseButtonAtTheLeftSideOfTheNavigationBar()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Tapping the close button at the left side of the navigation bar", new string[] {
                        "tag",
                        "FacebookLogonViaWriteYourThoughtsMenu"});
#line 82
this.ScenarioSetup(scenarioInfo);
#line 83
 testRunner.Given("I am authenticated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 84
  testRunner.And("I am on the page \"PostFeedPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 85
 testRunner.When("I tap the text Share an article, photo, video or idea", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 86
 testRunner.Then("I am redirected to the page \"PostFeedAddEditPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 87
 testRunner.When("I tap the close icon at the top left corner of the screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 88
 testRunner.Then("I am redirected to the page \"PostFeedPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Posting a new post")]
        [NUnit.Framework.CategoryAttribute("tag")]
        [NUnit.Framework.CategoryAttribute("FacebookLogonViaWriteYourThoughtsMenu")]
        [NUnit.Framework.TestCaseAttribute("I added this post", "New Post from @Worde5", "Worde Salinas", null)]
        public virtual void PostingANewPost(string postMessage, string title, string fullName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "tag",
                    "FacebookLogonViaWriteYourThoughtsMenu"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Posting a new post", @__tags);
#line 91
this.ScenarioSetup(scenarioInfo);
#line 92
 testRunner.Given("I am authenticated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 93
  testRunner.And("I am on the page \"PostFeedPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
 testRunner.When("I tap the text Share an article, photo, video or idea", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 95
 testRunner.Then("I am redirected to the page \"PostFeedAddEditPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 96
  testRunner.And("I can see that the button text is \"Post\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
 testRunner.When(string.Format("I type \"{0}\" and tap the Post button", postMessage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 98
 testRunner.Then("I am redirected to the page \"PostFeedPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 99
  testRunner.And(string.Format("I can see my newly posted postfeed with title \"{0}\", post message \"{1}\" and my fu" +
                        "llname \"{2}\"", title, postMessage, fullName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Posting a new post but with empty content")]
        [NUnit.Framework.CategoryAttribute("tag")]
        [NUnit.Framework.CategoryAttribute("FacebookLogonViaWriteYourThoughtsMenu")]
        [NUnit.Framework.TestCaseAttribute("", "New Post", "hyn rbf", "Posting with empty content is not allowed.", null)]
        public virtual void PostingANewPostButWithEmptyContent(string postMessage, string title, string fullName, string errorMessage, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "tag",
                    "FacebookLogonViaWriteYourThoughtsMenu"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Posting a new post but with empty content", @__tags);
#line 106
this.ScenarioSetup(scenarioInfo);
#line 107
 testRunner.Given("I am authenticated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 108
  testRunner.And("I am on the page \"PostFeedPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 109
 testRunner.When("I tap the text Share an article, photo, video or idea", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 110
 testRunner.Then("I am redirected to the page \"PostFeedAddEditPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 111
  testRunner.And("I can see that the button text is \"Post\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 112
 testRunner.When(string.Format("I type \"{0}\" and tap the Post button", postMessage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 113
 testRunner.Then(string.Format("I should see an empty post errror message \"{0}\"", errorMessage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Showing the Pull Down to Refresh Instruction")]
        [NUnit.Framework.CategoryAttribute("tag")]
        [NUnit.Framework.CategoryAttribute("FacebookLogonViaWriteYourThoughtsMenu")]
        public virtual void ShowingThePullDownToRefreshInstruction()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Showing the Pull Down to Refresh Instruction", new string[] {
                        "tag",
                        "FacebookLogonViaWriteYourThoughtsMenu"});
#line 120
this.ScenarioSetup(scenarioInfo);
#line 121
 testRunner.Given("I am authenticated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 122
  testRunner.And("I am on the page \"PostFeedPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 123
  testRunner.And("I could see the pull down to refresh instruction is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 124
 testRunner.When("I tap on the pull down to refresh instruction", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 125
 testRunner.Then("I should see that the instruction is not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 126
 testRunner.When("I tap the text Share an article, photo, video or idea", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 127
 testRunner.Then("I am redirected to the page \"PostFeedAddEditPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 128
 testRunner.When("I tap the close icon at the top left corner of the screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 129
 testRunner.Then("I am redirected to the page \"PostFeedPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 130
  testRunner.And("I could see the pull down to refresh instruction is not displayed anymore", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 131
  testRunner.And("the menu detail is closed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 132
 testRunner.When("I tap the hamburger icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 133
 testRunner.Then("I should see the menu detail is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 134
 testRunner.When("I tap the Useful Stuff item from the menu detail", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 135
 testRunner.Then("I am redirected to the page \"WikiPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 136
 testRunner.When("I tap the hamburger icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 137
 testRunner.Then("I should see the menu detail is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 138
 testRunner.When("I tap the Write Down icon from the menu detail with authenticated \"true\" and sign" +
                    "ed up \"true\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 139
 testRunner.Then("I am redirected to the page \"PostFeedPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 140
  testRunner.And("I could see the pull down to refresh instruction is displayed again", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Loading more posts")]
        [NUnit.Framework.CategoryAttribute("tag")]
        [NUnit.Framework.CategoryAttribute("FacebookLogonViaWriteYourThoughtsMenu")]
        public virtual void LoadingMorePosts()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Loading more posts", new string[] {
                        "tag",
                        "FacebookLogonViaWriteYourThoughtsMenu"});
#line 143
this.ScenarioSetup(scenarioInfo);
#line 144
 testRunner.Given("I am authenticated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 145
  testRunner.And("I am on the page \"PostFeedPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 146
 testRunner.Then("I should see a Post posted by \"Peter Smith\", with title \"Depression is something " +
                    "everyone should be aware of.\", and content \"According to @Glassdoor, these signs" +
                    " mean you\'re overthinking things at work:\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 147
 testRunner.When("I tap the load more post at the end", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 148
 testRunner.Then("I should that posts are added more", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Refreshing the Posts")]
        [NUnit.Framework.CategoryAttribute("tag")]
        [NUnit.Framework.CategoryAttribute("FacebookLogonViaWriteYourThoughtsMenu")]
        public virtual void RefreshingThePosts()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Refreshing the Posts", new string[] {
                        "tag",
                        "FacebookLogonViaWriteYourThoughtsMenu"});
#line 151
this.ScenarioSetup(scenarioInfo);
#line 152
 testRunner.Given("I am authenticated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 153
  testRunner.And("I am on the page \"PostFeedPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 154
 testRunner.Then("I should see a Post posted by \"Peter Smith\", with title \"Depression is something " +
                    "everyone should be aware of.\", and content \"According to @Glassdoor, these signs" +
                    " mean you\'re overthinking things at work:\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 155
 testRunner.When("I pull to refresh the page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 156
 testRunner.Then("I should see that post list are refreshed from the server again", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
