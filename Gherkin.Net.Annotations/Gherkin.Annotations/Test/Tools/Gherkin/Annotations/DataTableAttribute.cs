// <copyright file="DataTableAttribute.cs" company="Erratic Motion Ltd">
// Copyright (c) Erratic Motion Ltd. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace ErraticMotion.Test.Tools.Gherkin.Annotations
{
    using System;

    /// <summary>
    /// Used to decorate a section of code to indicate that it is a <c>DataTable</c> syntax element.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    public sealed class DataTableAttribute : GherkinIdentifierAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataTableAttribute"/> class.
        /// </summary>
        public DataTableAttribute()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataTableAttribute"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public DataTableAttribute(string id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Gets or sets the identifier reference.
        /// </summary>
        public string IdRef { get; set; }
    }
}