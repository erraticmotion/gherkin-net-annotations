// <copyright file="ButAttribute.cs" company="Erratic Motion Ltd">
// Copyright (c) Erratic Motion Ltd. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace ErraticMotion.Test.Tools.Gherkin.Annotations
{
    using System;

    /// <summary>
    /// Used to decorate a section of code to indicate that it is a <c>But</c> syntax element.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
    public sealed class ButAttribute : GherkinAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ButAttribute"/> class.
        /// </summary>
        /// <param name="description">A textural description of the expected behaviour.</param>
        public ButAttribute(string description)
            : base("But", description)
        {
        }
    }
}