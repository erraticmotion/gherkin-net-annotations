// <copyright file="ExamplesAttribute.cs" company="Erratic Motion Ltd">
// Copyright (c) Erratic Motion Ltd. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace ErraticMotion.Test.Tools.Gherkin.Annotations
{
    using System;

    /// <summary>
    /// Used to decorate a section of code to indicate that it is a <c>Examples</c> syntax element.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public sealed class ExamplesAttribute : GherkinIdentifierAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExamplesAttribute"/> class.
        /// </summary>
        public ExamplesAttribute()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExamplesAttribute"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public ExamplesAttribute(string id)
        {
            this.Id = id;
        }
    }
}