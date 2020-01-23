// <copyright file="WhenAttribute.cs" company="Erratic Motion Ltd">
// Copyright (c) Erratic Motion Ltd. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace ErraticMotion.Test.Tools.Gherkin.Annotations
{
    using System;

    /// <summary>
    /// Used to decorate a section of code to indicate that it is a <c>When</c> syntax element.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The purpose of When steps is to describe the key action the user performs.
    /// </para>
    /// <para>
    /// Gherkin keywords <c>And</c> and <c>But</c> statements can be added to the attribute values.
    /// </para>
    /// <para>
    /// The When attribute can decorate either a test fixture Class or Method.
    /// <list type="bullet">
    /// <item>
    /// <term>Class</term>
    /// <description>
    /// Implicitly creates a Gherkin <c>Background</c> syntax keyword, and indicates that the steps
    /// are to be run before each <c>Scenario</c> in the test fixture.
    /// </description>
    /// </item>
    /// <item>
    /// <term>Method</term>
    /// <description>
    /// Indicates that this is a step to be executed within the context of an individual test method.
    /// </description>
    /// </item>
    /// </list>
    /// </para>
    /// </remarks>
    /// <example>
    /// <para>
    /// The following code snippet decorates a test method the the When attribute and the resulting
    /// Gherkin output.
    /// </para>
    /// <code language="c#">
    /// [Given("the backlight is at its minimum value"),
    ///   When("the driver presses the F8 key"),
    ///   Then("the driver should see that the backlight is high")]
    /// [TestMethod, TestCategory("Customer")]
    /// public void The_driver_can_adjust_the_backlight_by_pressing_the_F8_key()
    /// {
    /// }
    /// </code>
    /// <code language="Gherkin">
    /// Scenario: The driver can adjust the backlight by pressing the F8 key
    ///   Given the backlight is at its minimum value
    ///   When the driver presses the F8 key
    ///   Then the driver should see that the backlight is high
    /// </code>
    /// </example>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
    [GherkinSyntax(GherkinStep.When)]
    public sealed class WhenAttribute : GherkinStepAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WhenAttribute"/> class.
        /// </summary>
        /// <param name="description">The description.</param>
        public WhenAttribute(string description)
            : base("When", description)
        {
        }
    }
}