// DriveCollection.cs
// Script#/Libraries/Windows
// Copyright (c) Nikhil Kothari.
// Copyright (c) Microsoft Corporation.
// This source code is subject to terms and conditions of the Microsoft 
// Public License. A copy of the license can be found in License.txt.
//

using System;
using System.Runtime.CompilerServices;

namespace System.Windows.FileSystem {

    /// <summary>
    /// Represents a set of drives.
    /// </summary>
    [IgnoreNamespace]
    [Imported]
    public sealed class DriveCollection {

        private DriveCollection() {
        }

        /// <summary>
        /// Gets the number of drives in the collection.
        /// </summary>
        [IntrinsicProperty]
        [PreserveCase]
        public int Count {
            get {
                return 0;
            }
        }

        /// <summary>
        /// Gets the specified drive.
        /// </summary>
        [IntrinsicProperty]
        public Drive this[int index] {
            get {
                return null;
            }
        }
    }
}
