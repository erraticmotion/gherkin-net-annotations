// <copyright file="ScenarioAttribute.cs" company="Erratic Motion Ltd">
// Copyright (c) Erratic Motion Ltd. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace ErraticMotion.Test.Tools.Gherkin.Annotations
{
    using System;

    /// <summary>
    /// Used to decorate a section of code to indicate that it is a <c>Scenario</c> syntax element.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Every scenario consists of a list of steps, which must start with one of the
    /// keywords Given, When, Then, But or And.
    /// </para>
    /// <para>
    /// The Scenario attribute can only decorate a test method. It is optional, and is
    /// only required if the test method requires a reference to a <see cref="ExamplesAttribute"/>
    /// test case method.
    /// </para>
    /// </remarks>
    /// <example>
    /// <para>
    /// The following code example shows a test method decorated with the Scenario attribute that
    /// references the test case data using the 'feeding_a_cow' identifier that relates to the Examples
    /// attribute that decorates the test case data member.
    /// </para>
    /// <code language="c#">
    /// [Scenario(IdRef = "#feeding_a_cow")]
    ///   [Given("the cow weighs &lt;weight&gt; kg"),
    ///     When("we calculate the feeding requirements"),
    ///     Then("the energy should be &lt;energy&gt; MJ", And = "the protein should be &lt;protein&gt; kg")]
    /// [TestMethod]
    /// public void Feeding_a_cow()
    /// {
    /// }
    ///
    /// [Examples(Id = "feeding_a_cow")]
    /// private GherkinExamplesCollection&lt;TestCase&gt; TestCases()
    /// {
    ///     return new GherkinExamplesCollection&lt;TestCase&gt;(new System.Collections.Generic.List&lt;TestCase&gt;
    ///     {
    ///         new TestCase { Weight = 450, Energy = 26500, Protein = 215 },
    ///         new TestCase { Weight = 500, Energy = 29500, Protein = 245 },
    ///         new TestCase { Weight = 575, Energy = 31500, Protein = 255 },
    ///         new TestCase { Weight = 600, Energy = 37000, Protein = 305 }
    ///     });
    /// }
    /// </code>
    /// <code language="Gherkin">
    /// Scenario Outline: Feeding a cow
    ///   Given the cow weighs &lt;weight&gt; kg
    ///   When we calculate the feeding requirements
    ///   Then the energy should be &lt;energy&gt; MJ
    ///     And the protein should be &lt;protein&gt; kg
    ///
    ///   Examples:
    ///     |  Weight |  Energy | Protein |
    ///     |     450 |   26500 |     215 |
    ///     |     500 |   29500 |     245 |
    ///     |     575 |   31500 |     255 |
    ///     |     600 |   37000 |     305 |
    /// </code>
    /// </example>
    [AttributeUsage(AttributeTargets.Method, Inherited = false)]
    public sealed class ScenarioAttribute : GherkinAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioAttribute"/> class.
        /// </summary>
        public ScenarioAttribute()
            : base("Scenario:", string.Empty)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioAttribute"/> class.
        /// </summary>
        /// <param name="description">The description.</param>
        public ScenarioAttribute(string description)
            : base("Scenario:", description)
        {
        }

        /// <summary>
        /// Gets or sets the identifier reference.
        /// </summary>
        public string IdRef { get; set; }
    }
}