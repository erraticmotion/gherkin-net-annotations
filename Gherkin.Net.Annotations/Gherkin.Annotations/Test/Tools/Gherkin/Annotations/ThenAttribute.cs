// <copyright file="ThenAttribute.cs" company="Erratic Motion Ltd">
// Copyright (c) Erratic Motion Ltd. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace ErraticMotion.Test.Tools.Gherkin.Annotations
{
    using System;

    /// <summary>
    /// Used to decorate a section of code to indicate that it is a <c>Then</c> syntax element.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The purpose of Then steps is to observe outcomes. The observations should be
    /// related to the business value/benefit in your feature description. The observations
    /// should also be on some kind of output – that is something that comes out of the
    /// system (report, user interface, message) and not something that is deeply buried
    /// inside it (that has no business value).
    /// </para>
    /// <para>
    /// Gherkin keywords <c>And</c> and <c>But</c> statements can be added to the attribute values.
    /// </para>
    /// </remarks>
    /// <example>
    /// <para>
    /// The following code snippet decorates a test method the the Then attribute and the resulting
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
    [AttributeUsage(AttributeTargets.Method, Inherited = false)]
    [GherkinSyntax(GherkinStep.Then)]
    public sealed class ThenAttribute : GherkinStepAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThenAttribute"/> class.
        /// </summary>
        /// <param name="description">The description.</param>
        public ThenAttribute(string description)
            : base("Then", description)
        {
        }
    }
}