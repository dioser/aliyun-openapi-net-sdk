/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Smartag.Transform;
using Aliyun.Acs.Smartag.Transform.V20180313;

namespace Aliyun.Acs.Smartag.Model.V20180313
{
    public class ModifySagLanRequest : RpcAcsRequest<ModifySagLanResponse>
    {
        public ModifySagLanRequest()
            : base("Smartag", "2018-03-13", "ModifySagLan", "smartag", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string endIp;

		private long? resourceOwnerId;

		private string mask;

		private string startIp;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string iP;

		private long? ownerId;

		private string iPType;

		private string smartAGId;

		private string smartAGSn;

		private string portName;

		private string lease;

		public string EndIp
		{
			get
			{
				return endIp;
			}
			set	
			{
				endIp = value;
				DictionaryUtil.Add(QueryParameters, "EndIp", value);
			}
		}

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string Mask
		{
			get
			{
				return mask;
			}
			set	
			{
				mask = value;
				DictionaryUtil.Add(QueryParameters, "Mask", value);
			}
		}

		public string StartIp
		{
			get
			{
				return startIp;
			}
			set	
			{
				startIp = value;
				DictionaryUtil.Add(QueryParameters, "StartIp", value);
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

		public string IP
		{
			get
			{
				return iP;
			}
			set	
			{
				iP = value;
				DictionaryUtil.Add(QueryParameters, "IP", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string IPType
		{
			get
			{
				return iPType;
			}
			set	
			{
				iPType = value;
				DictionaryUtil.Add(QueryParameters, "IPType", value);
			}
		}

		public string SmartAGId
		{
			get
			{
				return smartAGId;
			}
			set	
			{
				smartAGId = value;
				DictionaryUtil.Add(QueryParameters, "SmartAGId", value);
			}
		}

		public string SmartAGSn
		{
			get
			{
				return smartAGSn;
			}
			set	
			{
				smartAGSn = value;
				DictionaryUtil.Add(QueryParameters, "SmartAGSn", value);
			}
		}

		public string PortName
		{
			get
			{
				return portName;
			}
			set	
			{
				portName = value;
				DictionaryUtil.Add(QueryParameters, "PortName", value);
			}
		}

		public string Lease
		{
			get
			{
				return lease;
			}
			set	
			{
				lease = value;
				DictionaryUtil.Add(QueryParameters, "Lease", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifySagLanResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifySagLanResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
