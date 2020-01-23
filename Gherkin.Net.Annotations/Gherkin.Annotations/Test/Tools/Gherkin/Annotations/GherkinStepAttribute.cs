// <copyright file="GherkinStepAttribute.cs" company="Erratic Motion Ltd">
// Copyright (c) Erratic Motion Ltd. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace ErraticMotion.Test.Tools.Gherkin.Annotations
{
    /// <summary>
    /// Acts as a base class for Gherkin Given, When, and Then step values.
    /// </summary>
    public abstract class GherkinStepAttribute : GherkinAttribute
    {
        private readonly string step;

        /// <summary>
        /// Initializes a new instance of the <see cref="GherkinStepAttribute" /> class.
        /// </summary>
        /// <param name="keyword">The keyword.</param>
        /// <param name="syntax">The Gherkin syntax.</param>
        protected GherkinStepAttribute(string keyword, string syntax)
            : base(keyword, syntax)
        {
            var atts = this.GetType().GetCustomAttributes(typeof(GherkinSyntaxAttribute), false);
            this.step = atts.Length > 0 ? ((GherkinSyntaxAttribute)atts[0]).Step.ToString() : string.Empty;
        }

        /// <summary>
        /// Gets or sets the identifier reference.
        /// </summary>
        public string IdRef { get; set; }

        /// <summary>
        /// Gets or sets the Gherkin <c>And</c> step syntax.
        /// </summary>
        public string And { get; set; }

        /// <summary>
        /// Gets or sets the Gherkin <c>But</c> step syntax.
        /// </summary>
        public string But { get; set; }
    }
}