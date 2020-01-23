// <copyright file="WhereAttribute.cs" company="Erratic Motion Ltd">
// Copyright (c) Erratic Motion Ltd. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace ErraticMotion.Test.Tools.Gherkin.Annotations
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Text;

    /// <summary>
    /// Used to decorate a section of code to indicate that it is a <c>Where</c> syntax element.
    /// </summary>
    /// <remarks>
    /// Java/Groovy Spock uses this to decorate a method that returns a collection of test data items
    /// from the <c>Gherkin</c> Example: keyword. Currently just a place holder for test documentation.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    [SuppressMessage("Microsoft.Design", "CA1019:DefineAccessorsForAttributeArguments", Justification = "Set Description from arguments")]
    public sealed class WhereAttribute : GherkinAttribute
    {
        private readonly List<object> container = new List<object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WhereAttribute" /> class.
        /// </summary>
        /// <param name="arguments">The arguments.</param>
        public WhereAttribute(params object[] arguments)
            : base("Where")
        {
            this.container.AddRange(arguments);
            this.Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WhereAttribute"/> class.
        /// </summary>
        /// <param name="argument">The argument.</param>
        public WhereAttribute(object argument)
            : base("Where")
        {
            this.container.Add(argument);
            this.Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WhereAttribute"/> class.
        /// </summary>
        /// <param name="argument1">The first argument.</param>
        /// <param name="argument2">The second argument.</param>
        public WhereAttribute(object argument1, object argument2)
            : base("Where")
        {
            this.container.Add(argument1);
            this.container.Add(argument2);
            this.Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WhereAttribute"/> class.
        /// </summary>
        /// <param name="argument1">The first argument.</param>
        /// <param name="argument2">The second argument.</param>
        /// <param name="argument3">The third argument.</param>
        public WhereAttribute(object argument1, object argument2, object argument3)
            : base("Where")
        {
            this.container.Add(argument1);
            this.container.Add(argument2);
            this.container.Add(argument3);
            this.Initialize();
        }

        private void Initialize()
        {
            var builder = new StringBuilder();
            builder.Append("(");
            foreach (var o in this.container)
            {
                builder.AppendFormat("{0}, ", o);
            }

            this.Description = builder.ToString().TrimEnd().TrimEnd(',') + ")";
        }
    }
}