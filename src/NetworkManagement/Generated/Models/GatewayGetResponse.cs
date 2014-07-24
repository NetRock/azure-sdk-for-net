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
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Management.Network.Models;

namespace Microsoft.WindowsAzure.Management.Network.Models
{
    /// <summary>
    /// A standard service response including an HTTP status code and request
    /// ID.
    /// </summary>
    public partial class GatewayGetResponse : OperationResponse
    {
        private GatewayType _gatewayType;
        
        /// <summary>
        /// Optional. The type of gateway routing used for this virtual network.
        /// </summary>
        public GatewayType GatewayType
        {
            get { return this._gatewayType; }
            set { this._gatewayType = value; }
        }
        
        private GatewayEvent _lastEvent;
        
        /// <summary>
        /// Optional. The last recorded event for this virtual network gateway.
        /// </summary>
        public GatewayEvent LastEvent
        {
            get { return this._lastEvent; }
            set { this._lastEvent = value; }
        }
        
        private string _state;
        
        /// <summary>
        /// Optional. The provisioning state of the virtual network gateway.
        /// </summary>
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }
        
        private string _vipAddress;
        
        /// <summary>
        /// Optional. The virtual IP address for this virtual network gateway.
        /// </summary>
        public string VipAddress
        {
            get { return this._vipAddress; }
            set { this._vipAddress = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the GatewayGetResponse class.
        /// </summary>
        public GatewayGetResponse()
        {
        }
    }
}
