// <copyright file="GherkinIdentifierAttribute.cs" company="Erratic Motion Ltd">
// Copyright (c) Erratic Motion Ltd. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace ErraticMotion.Test.Tools.Gherkin.Annotations
{
    using System;

    /// <summary>
    /// Acts as a base class for Gherkin syntax keywords that need
    /// an identifier.
    /// </summary>
    public abstract class GherkinIdentifierAttribute : Attribute
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        public string Id { get; set; }
    }
}