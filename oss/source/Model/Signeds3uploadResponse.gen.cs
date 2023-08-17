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
    /// Signeds3uploadResponse
    /// </summary>
    [DataContract]
    public partial class Signeds3uploadResponse 
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Signeds3uploadResponse" /> class.
        /// </summary>
        public Signeds3uploadResponse()
        {
        }
        
        /// <summary>
        /// An array of signed URLs. For a single-part upload, this will only include a single URL. For a multipart upload, there will be one for each chunk of a multipart upload; the index of the URL in the array corresponds to the part number of the chunk.
        /// </summary>
        /// <value>An array of signed URLs. For a single-part upload, this will only include a single URL. For a multipart upload, there will be one for each chunk of a multipart upload; the index of the URL in the array corresponds to the part number of the chunk.</value>
        [DataMember(Name="urls", EmitDefaultValue=false)]
        public List<string> Urls { get; set; }

        /// <summary>
        /// The identifier of the upload session, to differentiate multiple attempts to upload data for the the same object. This must be provided when re-requesting chunk URLs for the same blob if they expire, and when calling the Complete Upload endpoint.
        /// </summary>
        /// <value>The identifier of the upload session, to differentiate multiple attempts to upload data for the the same object. This must be provided when re-requesting chunk URLs for the same blob if they expire, and when calling the Complete Upload endpoint.</value>
        [DataMember(Name="uploadKey", EmitDefaultValue=false)]
        public string UploadKey { get; set; }

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
