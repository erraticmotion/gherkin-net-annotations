// <copyright file="NamespaceDoc.cs" company="Erratic Motion Ltd">
// Copyright (c) Erratic Motion Ltd. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace ErraticMotion.Test.Tools.Gherkin.Annotations
{
    /// <summary>
    /// <para>
    /// The <see cref="Annotations" /> namespace contains classes for the creation
    /// of <c>Gherkin</c> .feature files from test fixture specification classes.
    /// </para>
    /// <para>
    /// The Gherkin syntax consists of a few basic keywords that are used to construct a business
    /// orientated specification language useful for communicating the expected behaviour
    /// of a software system. It can be thought of as a Domain Specific Language (DSL)
    /// specifically designed for communication of business functionality and benefit
    /// without detailing how that behaviour is implemented.
    /// </para>
    /// <para>
    /// <list type="bullet">
    /// <listheader><term>Term</term><description>Description</description></listheader>
    /// <item>
    /// <term>Feature</term>
    /// <description>
    /// Every .feature  file conventionally consists of a single feature. A line starting
    /// with the keyword Feature followed by free indented text starts a feature. A feature
    /// usually contains a list of scenarios. You can write whatever you want up until the
    /// first scenario, which starts with the word Scenario on a new line.
    /// <para>
    /// For further information and code samples, see <see cref="FeatureAttribute"/>.
    /// </para>
    /// </description>
    /// </item>
    /// <item>
    /// <term>Background</term>
    /// <description>
    /// Background allows you to add some context to the scenarios in a single feature. A
    /// Background is much like a scenario containing a number of steps. The difference
    /// is when it is run. The background is run before each of your scenarios. Backgrounds
    /// are implicitly created when the test fixture class is decorated with Given's and/or When's.
    /// <para> </para>
    /// </description>
    /// </item>
    /// <item>
    /// <term>Scenario</term>
    /// <description>
    /// Every scenario consists of a list of steps, which must start with one of the
    /// keywords Given, When, Then, But or And.
    /// <para>
    /// For further information and code samples, see <see cref="ScenarioAttribute"/>.
    /// </para>
    /// </description>
    /// </item>
    /// <item>
    /// <term>Scenario Outline</term>
    /// <description>
    /// When you have a complex business rule with severable variable inputs or outputs
    /// you might end up creating several scenarios that only differ by their values.
    /// If there are many examples, this becomes tedious. We can simplify it with a
    /// Scenario Outline. Scenario Outlines are created implicitly when the <see cref="ScenarioAttribute"/>
    /// is constructed with a reference to an area of code decorated with the <see cref="ExamplesAttribute"/>.
    /// <para> </para>
    /// </description>
    /// </item>
    /// <item>
    /// <term>Given</term>
    /// <description>
    /// The purpose of givens is to put the system in a known state before the user
    /// (or external system) starts interacting with the system (in the When steps).
    /// <para>
    /// For further information and code samples, see <see cref="GivenAttribute"/>.
    /// </para>
    /// </description>
    /// </item>
    /// <item>
    /// <term>When</term>
    /// <description>
    /// The purpose of When steps is to describe the key action the user performs.
    /// <para>
    /// For further information and code samples, see <see cref="WhenAttribute"/>.
    /// </para>
    /// </description>
    /// </item>
    /// <item>
    /// <term>Then</term>
    /// <description>
    /// The purpose of Then steps is to observe outcomes. The observations should be
    /// related to the business value/benefit in your feature description. The observations
    /// should also be on some kind of output – that is something that comes out of the
    /// system (report, user interface, message) and not something that is deeply buried
    /// inside it (that has no business value).
    /// <para>
    /// For further information and code samples, see <see cref="ThenAttribute"/>.
    /// </para>
    /// </description>
    /// </item>
    /// <item>
    /// <term>DocString</term>
    /// <description>
    /// Doc Strings are handy for passing a larger piece of text to a step definition.
    /// <para>
    /// For further information and code samples, see <see cref="DocStringAttribute"/>.
    /// </para>
    /// </description>
    /// </item>
    /// <item>
    /// <term>Examples</term>
    /// <description>
    /// Examples are data tables consisting of a list of test case values that can be
    /// passed to a step definition providing parameter driven tests.
    /// <para>
    /// For further information and code samples, see <see cref="ExamplesAttribute"/>.
    /// </para>
    /// </description>
    /// </item>
    /// </list>
    /// </para>
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    internal class NamespaceDoc
    {
    }
}
