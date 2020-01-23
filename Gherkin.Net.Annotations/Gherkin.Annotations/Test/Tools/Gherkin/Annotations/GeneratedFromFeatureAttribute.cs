// <copyright file="GeneratedFromFeatureAttribute.cs" company="Erratic Motion Ltd">
// Copyright (c) Erratic Motion Ltd. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace ErraticMotion.Test.Tools.Gherkin.Annotations
{
    using System;

    /// <summary>
    /// When used to decorate a class, indicates that the test fixture was generated
    /// from a .feature file using a tool, and so should not create a .feature file when
    /// the test fixture is executed.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public sealed class GeneratedFromFeatureAttribute : GherkinAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratedFromFeatureAttribute"/> class.
        /// </summary>
        public GeneratedFromFeatureAttribute()
            : base(string.Empty)
        {
        }

        /// <inheritdoc />
        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}