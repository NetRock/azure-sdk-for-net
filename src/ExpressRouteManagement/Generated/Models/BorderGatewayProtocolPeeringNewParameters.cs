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

namespace Microsoft.WindowsAzure.Management.ExpressRoute.Models
{
    /// <summary>
    /// The New Bgp Peering parameters.
    /// </summary>
    public partial class BorderGatewayProtocolPeeringNewParameters
    {
        private uint _peerAsn;
        
        /// <summary>
        /// Required. Specifies the numeric identifier of the public autonomous
        /// system (AS) in which the device of the service provider is
        /// configured.
        /// </summary>
        public uint PeerAsn
        {
            get { return this._peerAsn; }
            set { this._peerAsn = value; }
        }
        
        private string _primaryPeerSubnet;
        
        /// <summary>
        /// Required. Specifies the subnet addresses of the interface to be
        /// used for establishing the BGP session on the primary port.
        /// </summary>
        public string PrimaryPeerSubnet
        {
            get { return this._primaryPeerSubnet; }
            set { this._primaryPeerSubnet = value; }
        }
        
        private string _secondaryPeerSubnet;
        
        /// <summary>
        /// Required. Specifies the subnet addresses of the interface to be
        /// used for establishing the BGP session on the secondary port.
        /// </summary>
        public string SecondaryPeerSubnet
        {
            get { return this._secondaryPeerSubnet; }
            set { this._secondaryPeerSubnet = value; }
        }
        
        private string _sharedKey;
        
        /// <summary>
        /// Optional. Specifies the shared MD5 key that is to be used for
        /// authorization.
        /// </summary>
        public string SharedKey
        {
            get { return this._sharedKey; }
            set { this._sharedKey = value; }
        }
        
        private uint _vlanId;
        
        /// <summary>
        /// Required. Specifies the identifier that is used to identify the
        /// customer.
        /// </summary>
        public uint VlanId
        {
            get { return this._vlanId; }
            set { this._vlanId = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// BorderGatewayProtocolPeeringNewParameters class.
        /// </summary>
        public BorderGatewayProtocolPeeringNewParameters()
        {
        }
    }
}
