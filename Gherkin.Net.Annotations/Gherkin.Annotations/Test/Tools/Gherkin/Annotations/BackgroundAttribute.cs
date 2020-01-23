// <copyright file="BackgroundAttribute.cs" company="Erratic Motion Ltd">
// Copyright (c) Erratic Motion Ltd. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace ErraticMotion.Test.Tools.Gherkin.Annotations
{
    using System;

    /// <summary>
    /// Used to decorate a section of code to indicate that it is a <c>Background</c> syntax element.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, Inherited = false)]
    public sealed class BackgroundAttribute : GherkinAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundAttribute"/> class.
        /// </summary>
        /// <param name="description">A textural description that adds context to the background.</param>
        public BackgroundAttribute(string description)
            : base("Background:", description)
        {
        }
    }
}