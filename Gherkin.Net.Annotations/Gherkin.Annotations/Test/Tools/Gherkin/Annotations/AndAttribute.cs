// <copyright file="AndAttribute.cs" company="Erratic Motion Ltd">
// Copyright (c) Erratic Motion Ltd. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace ErraticMotion.Test.Tools.Gherkin.Annotations
{
    using System;

    /// <summary>
    /// Used to decorate a section of code to indicate that it is a <c>And</c> syntax element.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
    public sealed class AndAttribute : GherkinAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AndAttribute"/> class.
        /// </summary>
        /// <param name="description">A textural description of the expected behaviour.</param>
        public AndAttribute(string description)
            : base("And", description)
        {
        }
    }
}