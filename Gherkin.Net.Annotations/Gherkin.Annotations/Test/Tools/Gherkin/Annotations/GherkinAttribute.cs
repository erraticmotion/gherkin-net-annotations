// <copyright file="GherkinAttribute.cs" company="Erratic Motion Ltd">
// Copyright (c) Erratic Motion Ltd. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace ErraticMotion.Test.Tools.Gherkin.Annotations
{
    using System;
    using System.Globalization;

    /// <summary>
    /// Acts as a base class for Gherkin syntax keywords.
    /// </summary>
    public abstract class GherkinAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GherkinAttribute" /> class.
        /// </summary>
        /// <param name="keyword">The keyword.</param>
        protected GherkinAttribute(string keyword)
        {
            this.Keyword = keyword;
            this.Description = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GherkinAttribute" /> class.
        /// </summary>
        /// <param name="keyword">The keyword.</param>
        /// <param name="description">The Gherkin description.</param>
        protected GherkinAttribute(string keyword, string description)
            : this(keyword)
        {
            this.Description = description;
        }

        /// <summary>
        /// Gets or sets the Gherkin description.
        /// </summary>
        public string Description { get; protected set; }

        /// <summary>
        /// Gets the Gherkin keyword.
        /// </summary>
        public string Keyword { get; }

        /// <summary>
        /// Returns a <see cref="string" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="string" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0} {1}", this.Keyword, this.Description);
        }
    }
}