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
    /// Completes3uploadBody
    /// </summary>
    [DataContract]
    public partial class Completes3uploadBody 
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Completes3uploadBody" /> class.
        /// </summary>
        public Completes3uploadBody()
        {
        }
        
        /// <summary>
        /// The identifier of the upload session, which was provided by OSS in the response to the request for the signed URL/s with which to upload the object.
        /// </summary>
        /// <value>The identifier of the upload session, which was provided by OSS in the response to the request for the signed URL/s with which to upload the object.</value>
        [DataMember(Name="uploadKey", EmitDefaultValue=false)]
        public string UploadKey { get; set; }

        /// <summary>
        /// The expected size of the uploaded object. If provided, OSS will check this against the blob in S3 and return an error if the size does not match.
        /// </summary>
        /// <value>The expected size of the uploaded object. If provided, OSS will check this against the blob in S3 and return an error if the size does not match.</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public int? Size { get; set; }

        /// <summary>
        /// An array of eTags. For a single-part upload, this array contains the expected eTag of the entire object. For a multipart upload, this array contains the expected eTag of each part of the upload; the index of an eTag in the array corresponds to its part number in the upload.
        /// </summary>
        /// <value>An array of eTags. For a single-part upload, this array contains the expected eTag of the entire object. For a multipart upload, this array contains the expected eTag of each part of the upload; the index of an eTag in the array corresponds to its part number in the upload.</value>
        [DataMember(Name="eTags", EmitDefaultValue=false)]
        public List<string> ETags { get; set; }

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
