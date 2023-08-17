/* 
 * APS SDK
 *
 * The APS Platform contains an expanding collection of web service components that can be used with Autodesk cloud-based products or your own technologies. Take advantage of Autodesk’s expertise in design and engineering.
 *
 * oss
 *
 * The Object Storage Service (OSS) allows your application to download and upload raw files (such as PDF, XLS, DWG, or RVT) that are managed by the Data service.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Autodesk.Oss.Model
{
    /// <summary>
    /// resetexpiration definition
    /// </summary>
    [DataContract]
    public partial class Resetexpiration 
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Resetexpiration" /> class.
        /// </summary>
        public Resetexpiration()
        {
        }
        
        /// <summary>
        /// Gets or Sets BucketKey
        /// </summary>
        [DataMember(Name="bucketKey", EmitDefaultValue=false)]
        public string BucketKey { get; set; }

        /// <summary>
        /// Object ID
        /// </summary>
        /// <value>Object ID</value>
        [DataMember(Name="objectId", EmitDefaultValue=false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// Object name
        /// </summary>
        /// <value>Object name</value>
        [DataMember(Name="objectKey", EmitDefaultValue=false)]
        public string ObjectKey { get; set; }

        /// <summary>
        /// Gets or Sets Sha1
        /// </summary>
        [DataMember(Name="sha1", EmitDefaultValue=false)]
        public string Sha1 { get; set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public int? Size { get; set; }

        /// <summary>
        /// Gets or Sets ContentType
        /// </summary>
        [DataMember(Name="contentType", EmitDefaultValue=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// URL to download the object
        /// </summary>
        /// <value>URL to download the object</value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }

        /// <summary>
        /// Timestamp in epoch time
        /// </summary>
        /// <value>Timestamp in epoch time</value>
        [DataMember(Name="ceatedDate", EmitDefaultValue=false)]
        public long? CeatedDate { get; set; }

        /// <summary>
        /// Timestamp in epoch time
        /// </summary>
        /// <value>Timestamp in epoch time</value>
        [DataMember(Name="lastAccessedDate", EmitDefaultValue=false)]
        public long? LastAccessedDate { get; set; }

        /// <summary>
        /// Timestamp in epoch time
        /// </summary>
        /// <value>Timestamp in epoch time</value>
        [DataMember(Name="lastModifiedDate", EmitDefaultValue=false)]
        public long? LastModifiedDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }

}
