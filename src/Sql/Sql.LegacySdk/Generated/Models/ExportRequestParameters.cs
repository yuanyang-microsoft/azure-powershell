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

namespace Microsoft.Azure.Management.Sql.LegacySdk.Models
{
    /// <summary>
    /// Export Azure SQL Database parameters.
    /// </summary>
    public partial class ExportRequestParameters
    {
        private string _administratorLogin;
        
        /// <summary>
        /// Optional. Gets or sets the name of the SQL administrator.
        /// </summary>
        public string AdministratorLogin
        {
            get { return this._administratorLogin; }
            set { this._administratorLogin = value; }
        }
        
        private string _administratorLoginPassword;
        
        /// <summary>
        /// Optional. Gets or sets the password of the SQL administrator.
        /// </summary>
        public string AdministratorLoginPassword
        {
            get { return this._administratorLoginPassword; }
            set { this._administratorLoginPassword = value; }
        }
        
        private string _authenticationType;
        
        /// <summary>
        /// Optional. Gets or sets the authentication type.
        /// </summary>
        public string AuthenticationType
        {
            get { return this._authenticationType; }
            set { this._authenticationType = value; }
        }
        
        private string _storageKey;
        
        /// <summary>
        /// Optional. Gets or sets the storage key to use.
        /// </summary>
        public string StorageKey
        {
            get { return this._storageKey; }
            set { this._storageKey = value; }
        }
        
        private string _storageKeyType;
        
        /// <summary>
        /// Optional. Gets or sets the type of the storage key to use. Valid
        /// values are StorageAccessKey and SharedAccessKey.
        /// </summary>
        public string StorageKeyType
        {
            get { return this._storageKeyType; }
            set { this._storageKeyType = value; }
        }
        
        private Uri _storageUri;
        
        /// <summary>
        /// Optional. Gets or sets the storage uri to use.
        /// </summary>
        public Uri StorageUri
        {
            get { return this._storageUri; }
            set { this._storageUri = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ExportRequestParameters class.
        /// </summary>
        public ExportRequestParameters()
        {
        }
    }
}
