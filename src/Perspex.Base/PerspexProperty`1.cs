﻿// Copyright (c) The Perspex Project. All rights reserved.
// Licensed under the MIT license. See licence.md file in the project root for full license information.

using System;
using Perspex.Data;

namespace Perspex
{
    /// <summary>
    /// A typed perspex property.
    /// </summary>
    /// <typeparam name="TValue">The value type of the property.</typeparam>
    public class PerspexProperty<TValue> : PerspexProperty
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PerspexProperty{TValue}"/> class.
        /// </summary>
        /// <param name="name">The name of the property.</param>
        /// <param name="ownerType">The type of the class that registers the property.</param>
        /// <param name="defaultBindingMode">The default binding mode for the property.</param>
        /// <param name="notifying">
        /// A method that gets called before and after the property starts being notified on an
        /// object; the bool argument will be true before and false afterwards. This callback is
        /// intended to support IsDataContextChanging.
        /// </param>
        protected PerspexProperty(
            string name,
            Type ownerType,
            BindingMode defaultBindingMode = BindingMode.Default,
            Action<PerspexObject, bool> notifying = null)
            : base(
                name,
                typeof(TValue),
                ownerType,
                defaultBindingMode,
                notifying)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PerspexProperty"/> class.
        /// </summary>
        /// <param name="source">The property to copy.</param>
        /// <param name="ownerType">The new owner type.</param>
        protected PerspexProperty(PerspexProperty source, Type ownerType)
            : base(source, ownerType)
        {
        }
    }
}
