// <copyright file="GherkinSyntaxAttribute.cs" company="Erratic Motion Ltd">
// Copyright (c) Erratic Motion Ltd. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace ErraticMotion.Test.Tools.Gherkin.Annotations
{
    using System;

    /// <summary>
    /// Defines the <c>Gherkin</c> settings applied to a Step definition.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    internal sealed class GherkinSyntaxAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GherkinSyntaxAttribute"/> class.
        /// </summary>
        /// <param name="step">The step.</param>
        public GherkinSyntaxAttribute(GherkinStep step)
        {
            this.Step = step;
        }

        /// <summary>
        /// Gets the <c>Gherkin</c> step.
        /// </summary>
        public GherkinStep Step { get; }
    }
}