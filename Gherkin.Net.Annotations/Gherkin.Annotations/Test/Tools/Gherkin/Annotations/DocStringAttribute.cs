// <copyright file="DocStringAttribute.cs" company="Erratic Motion Ltd">
// Copyright (c) Erratic Motion Ltd. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace ErraticMotion.Test.Tools.Gherkin.Annotations
{
    using System;

    /// <summary>
    /// Used to decorate a section of code to indicate that it is a <c>DocString</c> syntax element.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    public sealed class DocStringAttribute : GherkinIdentifierAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocStringAttribute"/> class.
        /// </summary>
        public DocStringAttribute()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocStringAttribute" /> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public DocStringAttribute(string id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Gets or sets the identifier reference.
        /// </summary>
        public string IdRef { get; set; }
    }
}