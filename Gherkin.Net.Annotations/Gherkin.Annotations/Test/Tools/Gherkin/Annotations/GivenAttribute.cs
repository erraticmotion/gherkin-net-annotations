// <copyright file="GivenAttribute.cs" company="Erratic Motion Ltd">
// Copyright (c) Erratic Motion Ltd. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace ErraticMotion.Test.Tools.Gherkin.Annotations
{
    using System;

    /// <summary>
    /// Used to decorate a section of code to indicate that it is a <c>Given</c> syntax element.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The purpose of givens is to put the system in a known state before the user
    /// (or external system) starts interacting with the system (in the When steps).
    /// </para>
    /// <para>
    /// Gherkin keywords <c>And</c> and <c>But</c> statements can be added to the attribute values.
    /// </para>
    /// <para>
    /// The Given attribute can decorate either a test fixture Class or Method.
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
    /// The following code snippet decorates a test fixture with the Given attribute and the resulting
    /// Gherkin output.
    /// </para>
    /// <code langauge="c#">
    /// [Feature("As a driver I want to adjust backlight and contrast"),
    ///    Given("the system is showing the Driver Settings menu")]
    /// [TestClass]
    /// public class DriverSettingsMenuWhenDriverPressesKeysFeature
    /// {
    /// }
    /// </code>
    /// <code language="Gherkin">
    /// Feature: Driver settings menu when driver presses keys feature
    ///
    /// As a driver I want to adjust backlight and contrast
    ///
    /// Background:
    ///   Given the system is showing the Driver Settings menu
    /// </code>
    /// <para>
    /// The following code snippet decorates a test method the the Given attribute and the resulting
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
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, Inherited = false)]
    [GherkinSyntax(GherkinStep.Given)]
    public sealed class GivenAttribute : GherkinStepAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GivenAttribute"/> class.
        /// </summary>
        /// <param name="description">The description.</param>
        public GivenAttribute(string description)
            : base("Given", description)
        {
        }
    }
}