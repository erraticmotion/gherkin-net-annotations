// <copyright file="FeatureAttribute.cs" company="Erratic Motion Ltd">
// Copyright (c) Erratic Motion Ltd. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace ErraticMotion.Test.Tools.Gherkin.Annotations
{
    using System;

    /// <summary>
    /// Used to decorate a section of code to indicate that it is a <c>Feature</c> syntax element.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Used to decorate a test fixture specification class that can be used to generate Gherkin feature
    /// files.
    /// </para>
    /// <para>
    /// <b>Gherkin Abstract</b>: A .feature file is supposed to describe a single feature
    /// of the system, or a particular aspect of a feature. It's just a way to provide a
    /// high-level description of a software feature, and to group related scenarios.
    /// A feature has three basic elements—the Feature: keyword, a name (on the same line)
    /// and an optional (but highly recommended) description that can span multiple lines.
    /// </para>
    /// <para>
    /// The feature name is taken from the class name and formatted so that any uppercase
    /// letters in the name (apart from the first letter) are converted to lower case and
    /// a space is inserted to make it more human-readable. The description value is taken
    /// from the argument supplied in the <see cref="FeatureAttribute(string)"/>
    /// constructor.
    /// </para>
    /// </remarks>
    /// <example>
    /// <para>
    /// The following code sample shows the attribute decorating a test fixture specification
    /// type, and the Gherkin output produced when the test fixture is run.
    /// </para>
    /// <code language="c#">
    /// [Feature("feed planning for cattle and sheep")]
    /// public partial class FeedingCowsFeature : Specification
    /// {
    /// }
    /// </code>
    /// <code language="Gherkin">
    /// Feature: Feeding cows feature
    ///
    /// feed planning for cattle and sheep
    /// </code>
    /// </example>
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public sealed class FeatureAttribute : GherkinAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureAttribute"/> class.
        /// </summary>
        /// <param name="description">The feature description.</param>
        public FeatureAttribute(string description)
            : base("Feature:", description)
        {
        }
    }
}