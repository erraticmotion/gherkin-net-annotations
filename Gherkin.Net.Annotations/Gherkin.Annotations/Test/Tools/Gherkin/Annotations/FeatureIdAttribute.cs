// <copyright file="FeatureIdAttribute.cs" company="Erratic Motion Ltd">
// Copyright (c) Erratic Motion Ltd. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace ErraticMotion.Test.Tools.Gherkin.Annotations
{
    using System;

    /// <summary>
    /// Used to decorate a test fixture with a unique identifier.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public sealed class FeatureIdAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureIdAttribute"/> class.
        /// </summary>
        /// <param name="value">The feature identifier value.</param>
        public FeatureIdAttribute(IComparable value)
        {
            this.Id = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureIdAttribute"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public FeatureIdAttribute(string value)
        {
            this.Id = value;
        }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>
        /// The feature identifier.
        /// </value>
        public IComparable Id { get; }

        /// <inheritdoc />
        public override string ToString()
        {
            return "Feature: " + this.Id;
        }
    }
}