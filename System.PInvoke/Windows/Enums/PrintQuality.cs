﻿#region Copyright Notice
// 
// 
// Copyright (c) 2009-2010 Anindya Chatterjee
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// 
// 
#endregion
namespace System.PInvoke.Windows.Enums
{
    /// <summary>
    /// Specifies the printer resolution.
    /// </summary>
    [Flags]
    public enum PrintQuality : short
    {
        /// <summary>
        /// High resolution
        /// </summary>
        DMRES_HIGH = -4,
        /// <summary>
        /// Medium resolution
        /// </summary>
        DMRES_MEDIUM = -3,
        /// <summary>
        /// Low resolution
        /// </summary>
        DMRES_LOW = -2,
        /// <summary>
        /// Draft
        /// </summary>
        DMRES_DRAFT = -1
    }
}