// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.WindowsAzure.Management.Scheduler.Models
{
    /// <summary>
    /// Specifies the state for a cloud service resource.
    /// </summary>
    public static partial class GetCloudServiceResourceState
    {
        /// <summary>
        /// The resource state is unknown, there may have been a communicaiton
        /// failure, or the resource has not yet been processed.
        /// </summary>
        public const string Unknown = "Unknown";
        
        /// <summary>
        /// The resource provider did not respond with information for the
        /// resource.
        /// </summary>
        public const string NotFound = "NotFound";
        
        /// <summary>
        /// The resource has started and is running fine.
        /// </summary>
        public const string Started = "Started";
        
        /// <summary>
        /// The resource was stopped due to an issue.
        /// </summary>
        public const string Stopped = "Stopped";
        
        /// <summary>
        /// The resource was temporarily put on hold. This may be due to a
        /// monetary event.
        /// </summary>
        public const string Paused = "Paused";
    }
}
