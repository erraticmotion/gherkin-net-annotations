# gherkin-net-annotations

The Gherkin syntax consists of a few basic keywords that are used to construct a business orientated specification language useful for communicating the expected behavior of a software system. It can be thought of as a Domain Specific Language (DSL) specifically designed for communication of business functionality and benefit without detailing how that behavior is implemented.

## Gherkin Syntax

### Feature

Every .feature  file conventionally consists of a single feature. A line starting with the keyword Feature followed by free indented text starts a feature. A feature usually contains a list of scenarios. You can write whatever you want up until the first scenario, which starts with the word Scenario on a new line.

### Background

Background allows you to add some context to the scenarios in a single feature. A Background is much like a scenario containing a number of steps. The difference is when it is run. The background is run before each of your scenarios. Backgrounds are implicitly created when the test fixture class is decorated with Given's and/or When's.

### Scenario

Every scenario consists of a list of steps, which must start with one of the keywords Given, When, Then, But or And.

### Scenario Outline

When you have a complex business rule with several variable inputs or outputs you might end up creating several scenarios that only differ by their values. If there are many examples, this becomes tedious. We can simplify it with a Scenario Outline. Scenario Outlines are created implicitly when the ```ScenarioAttribute``` is constructed with a reference to an area of code decorated with the ```ExamplesAttribute```.

### Given

The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps).

### When

The purpose of When steps is to describe the key action the user performs.

### Then

The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).

### DocString

Doc Strings are handy for passing a larger piece of text to a step definition.

### Examples

Examples are data tables consisting of a list of test case values that can be passed to a step definition providing parameter driven tests.

## Gherkin Annotations

### ```AndAttribute```

Used to decorate a section of code to indicate that it is a <c>And</c> syntax element.

### ```BackgroundAttribute```

Used to decorate a section of code to indicate that it is a <c>Background</c> syntax element.

### ```ButAttribute```

Used to decorate a section of code to indicate that it is a <c>But</c> syntax element.

### ```DataTableAttribute```

Used to decorate a section of code to indicate that it is a <c>DataTable</c> syntax element.

### ```DocStringAttribute```

Used to decorate a section of code to indicate that it is a <c>DocString</c> syntax element.

<b>Gherkin Abstract</b>: Step Arguments. In some cases you might want to pass a larger chunk of text or a table of data to a step—something that doesn't fit on a single line. For this purpose Gherkin has Doc Strings, ```ExamplesAttribute``` and Data Tables. Doc Strings are handy for passing a larger piece of text to a step definition. The syntax is inspired from Python's <b>DocString</b> syntax. The text should be offset by delimiters consisting of three double-quote marks on lines of their own. Indentation of the opening """ is unimportant, although common practice is two spaces in from the enclosing step. The indentation inside the triple quotes, however, is significant. Each line of the Doc String will be de-indented according to the opening """. Indentation beyond the column of the opening """ will therefore be preserved.


```gherkin

  Scenario: This is the scenario title
    Given that pre-conditions and expectations are set
    When something happens
    Then carry out state verification using:
    """
    expected value
    """
    
```


The following code snippet shows a method decorated with this attribute using the Id reference of 'scenario' which is used to match the methods return value with a Given-When-Then statement defined on a test method.


```c#
[DocString(Id = "scenario")]
public string Expected_State()
{
    return "expected value"; 
}
```


The following code snippet shows a test method referencing the ```DocStringAttribute``` decorated method and where the Id value 'scenario' is prefixed with the character '#' and supplied to the ```GherkinStepAttribute.IdRef``` property.


```c#
[Then("carry out state verification using:", IdRef = "#scenario")]
[TestMethod]
public void ThenCarryOutStateVerificationUsing()
{
}
```

### ```ExamplesAttribute```

Used to decorate a section of code to indicate that it is a <c>Examples</c> syntax element.

Used to decorate a method that returns a representation of tabular test data. The method decorated must have no arguments and return its string representation as a valid Gherkin Examples table.

<b>Gherkin Abstract</b>: Step Arguments. In some cases you might want to pass a larger chunk of text or a table of data to a step—something that doesn't fit on a single line. For this purpose Gherkin has ```DocStringAttribute``` and Data Tables. Data Tables are handy for passing a list of values to a step definition:

```gherkin

  Scenario Outline: Feeding a cow
    Given the cow weighs <weight> kg
    When we calculate the feeding requirements
    Then the energy should be <energy> MJ
      And the protein should be <protein> kg
    Examples:
      |  Weight |  Energy | Protein |
      |     450 |   26500 |     215 |
      |     500 |   29500 |     245 |
      |     575 |   31500 |     255 |
      |     600 |   37000 |     305 |
     
```

```c#
[TestCase]
private class TestCase : GherkinExamplesBase
{
    [TestCaseProperty]
    public int Weight { get; set; }
    
    [TestCaseProperty]
    public int Energy { get; set; }
    
    [TestCaseProperty]
    public int Protein { get; set; }
}
    
[Examples(Id = "feeding_a_cow")]
private GherkinExamplesCollection&lt;TestCase&gt; TestCases()
{
    return new GherkinExamplesCollection<TestCase>(new System.Collections.Generic.List<TestCase>
    {
         new TestCase { Weight = 450, Energy = 26500, Protein = 215 },
         new TestCase { Weight = 500, Energy = 29500, Protein = 245 },
         new TestCase { Weight = 575, Energy = 31500, Protein = 255 },
         new TestCase { Weight = 600, Energy = 37000, Protein = 305 }
    });
}

[Scenario(IdRef = "#feeding_a_cow")]
[Given("the cow weighs <weight> kg")]
[When("we calculate the feeding requirements")]
[Then("the energy should be <energy> MJ", And = "the protein should be <protein> kg")]
[TestMethod]
public void Feeding_a_cow()
{
}
```

### ```FeatureAttribute```

Used to decorate a section of code to indicate that it is a <c>Feature</c> syntax element.Used to decorate a test fixture specification class that can be used to generate Gherkin feature files.
