// <copyright file="TestFactAttribute.cs" company="Erratic Motion Ltd">
// Copyright (c) Erratic Motion Ltd. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace ErraticMotion.Test.Tools.Gherkin.Annotations
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// When applied to a type, specifies that the type is part of a test
    /// fact contract.
    /// </summary>
    /// <remarks>
    /// <para>
    /// By default, the class name will be used for diagnostics purposes when creating tabular
    /// test cases. To override this behaviour, supply a value to be used as the name
    /// in the <see cref="Name"/> property.
    /// </para>
    /// <para>
    /// The format "f" and "fullname" will always return the true name of the class and it's
    /// enclosing type (if present).
    /// </para>
    /// </remarks>
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Format specifiers")]
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public sealed class TestFactAttribute : Attribute
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name to be used when creating tabular test cases.
        /// </value>
        /// <remarks>
        /// If not explicitly set, value will be taken from the class name this attribute
        /// has been applied to.
        /// </remarks>
        public string Name { get; set; }
    }
}