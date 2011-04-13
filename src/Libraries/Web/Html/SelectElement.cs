// SelectElement.cs
// Script#/Libraries/Web
// Copyright (c) Nikhil Kothari.
// Copyright (c) Microsoft Corporation.
// This source code is subject to terms and conditions of the Microsoft 
// Public License. A copy of the license can be found in License.txt.
//

using System;
using System.Runtime.CompilerServices;

namespace System.Html {

    [IgnoreNamespace]
    [Imported]
    public sealed class SelectElement : InputElement {

        private SelectElement() {
        }

        [IntrinsicProperty]
        public bool Multiple {
            get {
                return false;
            }
            set {
            }
        }

        [IntrinsicProperty]
        public ElementCollection Options {
            get {
                return null;
            }
        }

        [IntrinsicProperty]
        public int SelectedIndex {
            get {
                return 0;
            }
            set {
            }
        }

        [IntrinsicProperty]
        public int Size {
            get {
                return 0;
            }
            set {
            }
        }

        /// <summary>
        /// Adds an element to the end of the <see cref="Options"/> collection.
        /// </summary>
        /// <param name="option">Element to add to the <see cref="Options"/> collection.</param>
        public void Add(OptionElement option) {
        }

        /// <summary>
        /// Adds an element to the <see cref="Options"/> collection (IE only).
        /// </summary>
        /// <param name="option">Element to add to the <see cref="Options"/> collection.</param>
        /// <param name="index">Specifies the index position in the collection where the element is placed.</param>
        public void Add(OptionElement option, int index) {
        }

        /// <summary>
        /// Adds an element to the <see cref="Options"/> collection (Firefox only).
        /// </summary>
        /// <param name="option">Element to add to the <see cref="Options"/> collection.</param>
        /// <param name="before">The element before which to add <paramref name="option"/>.</param>
        public void Add(OptionElement option, OptionElement before) {
        }

        /// <summary>
        /// Removes an <see cref="OptionElement"/> from the <see cref="Options"/> collection.
        /// </summary>
        /// <param name="index"></param>
        public void Remove(int index) {
        }
    }
}
