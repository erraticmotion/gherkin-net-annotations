// <copyright file="ScenarioIdAttribute.cs" company="Erratic Motion Ltd">
// Copyright (c) Erratic Motion Ltd. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace ErraticMotion.Test.Tools.Gherkin.Annotations
{
    using System;

    /// <summary>
    /// Identifies a Gherkin Scenario, or Scenario Outline test method.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, Inherited = false)]
    public sealed class ScenarioIdAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioIdAttribute"/> class.
        /// </summary>
        /// <param name="value">The scenario identifier value.</param>
        public ScenarioIdAttribute(IComparable value)
        {
            this.Id = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioIdAttribute"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public ScenarioIdAttribute(string value)
        {
            this.Id = value;
        }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>
        /// The scenario or scenario outline identifier.
        /// </value>
        public IComparable Id { get; private set; }

        /// <summary>
        /// Returns a <see cref="string" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="string" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return "Scenario: " + this.Id;
        }
    }
}