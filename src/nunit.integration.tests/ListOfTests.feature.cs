﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace nunit.integration.tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("NUnit should support the list of tests to explore and run")]
    public partial class NUnitShouldSupportTheListOfTestsToExploreAndRunFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ListOfTests.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "NUnit should support the list of tests to explore and run", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
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
    testRunner.Given("NUnit path is ..\\nunit\\", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I can explore tests and write the list of tests to file")]
        [NUnit.Framework.CategoryAttribute("3.4.1")]
        [NUnit.Framework.CategoryAttribute("teamcity")]
        [NUnit.Framework.TestCaseAttribute("Version45", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Version40", new string[0])]
        public virtual void ICanExploreTestsAndWriteTheListOfTestsToFile(string frameworkVersion, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "3.4.1",
                    "teamcity"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I can explore tests and write the list of tests to file", @__tags);
#line 8
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 9
    testRunner.Given(string.Format("Framework version is {0}", frameworkVersion), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
    testRunner.And("I added successful method as SuccessfulTest1 to the class Foo.Tests.UnitTests1 fo" +
                    "r foo.tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
    testRunner.And("I added successful method as SuccessfulTest2 to the class Foo.Tests.UnitTests1 fo" +
                    "r foo.tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
    testRunner.And("I created the folder mocks", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
    testRunner.And("I added NUnit framework references to foo.tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
    testRunner.And("I copied NUnit framework references to folder mocks", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
    testRunner.And("I compiled the assembly foo.tests to file mocks\\foo.tests.dll", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
    testRunner.And("I added the assembly mocks\\foo.tests.dll to the list of testing assemblies", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
    testRunner.And("I added the arg Explore=mocks\\AllTests.xml to NUnit console command line", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
    testRunner.When("I run NUnit console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 19
    testRunner.Then("the exit code should be 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "name"});
            table1.AddRow(new string[] {
                        "foo.tests.dll"});
#line 20
    testRunner.And("the xml file mocks\\AllTests.xml contains items by xPath .//test-suite[@type=\'Asse" +
                    "mbly\']:", ((string)(null)), table1, "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "fullname"});
            table2.AddRow(new string[] {
                        "Foo.Tests.UnitTests1.SuccessfulTest1"});
            table2.AddRow(new string[] {
                        "Foo.Tests.UnitTests1.SuccessfulTest2"});
#line 23
    testRunner.And("the xml file mocks\\AllTests.xml contains items by xPath .//test-suite[@type=\'Test" +
                    "Fixture\']/test-case:", ((string)(null)), table2, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I can explore tests and write the list of tests to file for several assemblies")]
        [NUnit.Framework.CategoryAttribute("3.4.1")]
        [NUnit.Framework.CategoryAttribute("teamcity")]
        [NUnit.Framework.TestCaseAttribute("Version45", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Version40", new string[0])]
        public virtual void ICanExploreTestsAndWriteTheListOfTestsToFileForSeveralAssemblies(string frameworkVersion, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "3.4.1",
                    "teamcity"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I can explore tests and write the list of tests to file for several assemblies", @__tags);
#line 34
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 35
    testRunner.Given(string.Format("Framework version is {0}", frameworkVersion), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 36
    testRunner.And("I added successful method as SuccessfulTest1 to the class Foo.Tests.UnitTests1 fo" +
                    "r foo1.tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
    testRunner.And("I added successful method as SuccessfulTest2 to the class Foo.Tests.UnitTests1 fo" +
                    "r foo1.tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
    testRunner.And("I added successful method as SuccessfulTest1 to the class Foo.Tests.UnitTests2 fo" +
                    "r foo1.tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
    testRunner.And("I added successful method as SuccessfulTest1 to the class Foo.Tests.UnitTests1 fo" +
                    "r foo2.tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
    testRunner.And("I created the folder mocks", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
    testRunner.And("I added NUnit framework references to foo1.tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
    testRunner.And("I added NUnit framework references to foo2.tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
    testRunner.And("I copied NUnit framework references to folder mocks", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
    testRunner.And("I compiled the assembly foo1.tests to file mocks\\foo1.tests.dll", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
    testRunner.And("I compiled the assembly foo2.tests to file mocks\\foo2.tests.dll", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
    testRunner.And("I added the assembly mocks\\foo1.tests.dll to the list of testing assemblies", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
    testRunner.And("I added the assembly mocks\\foo2.tests.dll to the list of testing assemblies", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
    testRunner.And("I added the arg Explore=mocks\\AllTests.xml to NUnit console command line", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
    testRunner.When("I run NUnit console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 50
    testRunner.Then("the exit code should be 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "name"});
            table3.AddRow(new string[] {
                        "foo1.tests.dll"});
            table3.AddRow(new string[] {
                        "foo2.tests.dll"});
#line 51
    testRunner.And("the xml file mocks\\AllTests.xml contains items by xPath .//test-suite[@type=\'Asse" +
                    "mbly\']:", ((string)(null)), table3, "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "fullname"});
            table4.AddRow(new string[] {
                        "Foo.Tests.UnitTests1.SuccessfulTest1"});
            table4.AddRow(new string[] {
                        "Foo.Tests.UnitTests1.SuccessfulTest2"});
            table4.AddRow(new string[] {
                        "Foo.Tests.UnitTests2.SuccessfulTest1"});
            table4.AddRow(new string[] {
                        "Foo.Tests.UnitTests1.SuccessfulTest1"});
#line 55
    testRunner.And("the xml file mocks\\AllTests.xml contains items by xPath .//test-suite[@type=\'Test" +
                    "Fixture\']/test-case:", ((string)(null)), table4, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I can run tests from the list of tests")]
        [NUnit.Framework.CategoryAttribute("3.4.1")]
        [NUnit.Framework.CategoryAttribute("teamcity")]
        [NUnit.Framework.TestCaseAttribute("Version45", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Version40", new string[0])]
        public virtual void ICanRunTestsFromTheListOfTests(string frameworkVersion, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "3.4.1",
                    "teamcity"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I can run tests from the list of tests", @__tags);
#line 68
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 69
    testRunner.Given(string.Format("Framework version is {0}", frameworkVersion), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 70
    testRunner.And("I added successful method as SuccessfulTest1 to the class Foo.Tests.UnitTests1 fo" +
                    "r foo.tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
    testRunner.And("I added successful method as SuccessfulTest2 to the class Foo.Tests.UnitTests2 fo" +
                    "r foo.tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
    testRunner.And("I added successful method as SuccessfulTest3 to the class Foo.Tests.UnitTests3 fo" +
                    "r foo.tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
    testRunner.And("I created the folder mocks", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 74
    testRunner.And("I added NUnit framework references to foo.tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
    testRunner.And("I copied NUnit framework references to folder mocks", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
    testRunner.And("I compiled the assembly foo.tests to file mocks\\foo.tests.dll", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 77
    testRunner.And("I added the assembly mocks\\foo.tests.dll to the list of testing assemblies", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
    testRunner.And("I appended the line Foo.Tests.UnitTests1 to file mocks\\ListOfTests.txt", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
    testRunner.And("I appended the line Foo.Tests.UnitTests2 to file mocks\\ListOfTests.txt", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
    testRunner.And("I added the arg TestList=mocks\\ListOfTests.txt to NUnit console command line", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
    testRunner.When("I run NUnit console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 82
    testRunner.Then("the exit code should be 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
            table5.AddRow(new string[] {
                        "Test Count",
                        "2"});
            table5.AddRow(new string[] {
                        "Passed",
                        "2"});
            table5.AddRow(new string[] {
                        "Failed",
                        "0"});
            table5.AddRow(new string[] {
                        "Inconclusive",
                        "0"});
            table5.AddRow(new string[] {
                        "Skipped",
                        "0"});
#line 83
    testRunner.And("the Test Run Summary should has following:", ((string)(null)), table5, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I can run tests from the list of tests for several assemblies")]
        [NUnit.Framework.CategoryAttribute("3.4.1")]
        [NUnit.Framework.CategoryAttribute("teamcity")]
        [NUnit.Framework.TestCaseAttribute("ProjectFile", "Version45", new string[0])]
        [NUnit.Framework.TestCaseAttribute("ProjectFile", "Version40", new string[0])]
        [NUnit.Framework.TestCaseAttribute("CmdArguments", "Version45", new string[0])]
        [NUnit.Framework.TestCaseAttribute("CmdArguments", "Version40", new string[0])]
        public virtual void ICanRunTestsFromTheListOfTestsForSeveralAssemblies(string configurationType, string frameworkVersion, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "3.4.1",
                    "teamcity"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I can run tests from the list of tests for several assemblies", @__tags);
#line 97
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 98
    testRunner.Given(string.Format("Framework version is {0}", frameworkVersion), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 99
    testRunner.And("I added successful method as SuccessfulTest1 to the class Foo.Tests.UnitTests1 fo" +
                    "r foo1.tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 100
    testRunner.And("I added successful method as SuccessfulTest2 to the class Foo.Tests.UnitTests2 fo" +
                    "r foo1.tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 101
    testRunner.And("I added successful method as SuccessfulTest3 to the class Foo.Tests.UnitTests3 fo" +
                    "r foo1.tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 102
    testRunner.And("I added successful method as SuccessfulTest1 to the class Foo.Tests.UnitTests4 fo" +
                    "r foo2.tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 103
    testRunner.And("I added successful method as SuccessfulTest1 to the class Foo.Tests.UnitTests1 fo" +
                    "r foo2.tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 104
    testRunner.And("I created the folder mocks", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 105
    testRunner.And("I added NUnit framework references to foo1.tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 106
    testRunner.And("I added NUnit framework references to foo2.tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 107
    testRunner.And("I copied NUnit framework references to folder mocks", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 108
    testRunner.And("I compiled the assembly foo1.tests to file mocks\\foo1.tests.dll", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 109
    testRunner.And("I compiled the assembly foo2.tests to file mocks\\foo2.tests.dll", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 110
    testRunner.And("I added the assembly mocks\\foo1.tests.dll to the list of testing assemblies", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 111
    testRunner.And("I added the assembly mocks\\foo2.tests.dll to the list of testing assemblies", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 112
    testRunner.And("I appended the line Foo.Tests.UnitTests1 to file mocks\\ListOfTests.txt", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 113
    testRunner.And("I appended the line Foo.Tests.UnitTests2 to file mocks\\ListOfTests.txt", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 114
    testRunner.And("I added the arg TestList=mocks\\ListOfTests.txt to NUnit console command line", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 115
    testRunner.And(string.Format("I want to use {0} configuration type", configurationType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 116
    testRunner.When("I run NUnit console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 117
    testRunner.Then("the exit code should be 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
            table6.AddRow(new string[] {
                        "Test Count",
                        "3"});
            table6.AddRow(new string[] {
                        "Passed",
                        "3"});
            table6.AddRow(new string[] {
                        "Failed",
                        "0"});
            table6.AddRow(new string[] {
                        "Inconclusive",
                        "0"});
            table6.AddRow(new string[] {
                        "Skipped",
                        "0"});
#line 118
    testRunner.And("the Test Run Summary should has following:", ((string)(null)), table6, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I can run tests from the list of tests for several assemblies from different dire" +
            "ctories")]
        [NUnit.Framework.CategoryAttribute("3.4.1")]
        [NUnit.Framework.CategoryAttribute("teamcity")]
        [NUnit.Framework.TestCaseAttribute("ProjectFile", "Version45", new string[0])]
        [NUnit.Framework.TestCaseAttribute("ProjectFile", "Version40", new string[0])]
        [NUnit.Framework.TestCaseAttribute("CmdArguments", "Version45", new string[0])]
        [NUnit.Framework.TestCaseAttribute("CmdArguments", "Version40", new string[0])]
        public virtual void ICanRunTestsFromTheListOfTestsForSeveralAssembliesFromDifferentDirectories(string configurationType, string frameworkVersion, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "3.4.1",
                    "teamcity"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I can run tests from the list of tests for several assemblies from different dire" +
                    "ctories", @__tags);
#line 134
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 135
    testRunner.Given(string.Format("Framework version is {0}", frameworkVersion), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 136
    testRunner.And("I added successful method as SuccessfulTest1 to the class Foo.Tests.UnitTests1 fo" +
                    "r foo1.tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 137
    testRunner.And("I added successful method as SuccessfulTest2 to the class Foo.Tests.UnitTests2 fo" +
                    "r foo1.tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 138
    testRunner.And("I added successful method as SuccessfulTest3 to the class Foo.Tests.UnitTests3 fo" +
                    "r foo1.tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 139
    testRunner.And("I added successful method as SuccessfulTest1 to the class Foo.Tests.UnitTests4 fo" +
                    "r foo2.tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 140
    testRunner.And("I added successful method as SuccessfulTest1 to the class Foo.Tests.UnitTests1 fo" +
                    "r foo2.tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 141
    testRunner.And("I created the folder mocks", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 142
    testRunner.And("I added NUnit framework references to foo1.tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 143
    testRunner.And("I added NUnit framework references to foo2.tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 144
    testRunner.And("I created the folder mocks\\1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 145
    testRunner.And("I copied NUnit framework references to folder mocks\\1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 146
    testRunner.And("I compiled the assembly foo1.tests to file mocks\\1\\foo1.tests.dll", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 147
    testRunner.And("I created the folder mocks\\2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 148
    testRunner.And("I copied NUnit framework references to folder mocks\\2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 149
    testRunner.And("I compiled the assembly foo2.tests to file mocks\\2\\foo2.tests.dll", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 150
    testRunner.And("I added the assembly mocks\\1\\foo1.tests.dll to the list of testing assemblies", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 151
    testRunner.And("I added the assembly mocks\\2\\foo2.tests.dll to the list of testing assemblies", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 152
    testRunner.And("I appended the line Foo.Tests.UnitTests1 to file mocks\\ListOfTests.txt", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 153
    testRunner.And("I appended the line Foo.Tests.UnitTests2 to file mocks\\ListOfTests.txt", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 154
    testRunner.And("I added the arg TestList=mocks\\ListOfTests.txt to NUnit console command line", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 155
    testRunner.And(string.Format("I want to use {0} configuration type", configurationType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 156
    testRunner.When("I run NUnit console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 157
    testRunner.Then("the exit code should be 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
            table7.AddRow(new string[] {
                        "Test Count",
                        "3"});
            table7.AddRow(new string[] {
                        "Passed",
                        "3"});
            table7.AddRow(new string[] {
                        "Failed",
                        "0"});
            table7.AddRow(new string[] {
                        "Inconclusive",
                        "0"});
            table7.AddRow(new string[] {
                        "Skipped",
                        "0"});
#line 158
    testRunner.And("the Test Run Summary should has following:", ((string)(null)), table7, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
