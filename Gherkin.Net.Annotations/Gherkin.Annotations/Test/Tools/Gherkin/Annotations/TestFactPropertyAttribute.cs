// <copyright file="TestFactPropertyAttribute.cs" company="Erratic Motion Ltd">
// Copyright (c) Erratic Motion Ltd. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace ErraticMotion.Test.Tools.Gherkin.Annotations
{
    using System;

    /// <summary>
    /// When applied to the member of a type, specifies that the member is part of a test
    /// fact contract.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The test case contract model is an "opt-in" model. Any properties not marked with this
    /// attribute will not be available within generated customer documentation.
    /// </para>
    /// <para>
    /// Properties marked must be "readable", i.e., expose a public <b>get</b> field.
    /// </para>
    /// <para>
    /// By default, the property name will be used as the header name when creating tabular
    /// test cases. To override this behaviour, supply a value to be used as the column name
    /// in the <see cref="ColumnName"/> property.
    /// </para>
    /// </remarks>
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class TestFactPropertyAttribute : Attribute
    {
        /// <summary>
        /// Gets or sets the name of the column.
        /// </summary>
        /// <value>
        /// The name of the column to be used when creating tabular test cases.
        /// </value>
        /// <remarks>
        /// If not explicitly set, value will be taken from the property name this attribute
        /// has been applied to.
        /// </remarks>
        public string ColumnName { get; set; }
    }
}