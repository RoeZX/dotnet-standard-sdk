/**
* Copyright 2018, 2019 IBM Corp. All Rights Reserved.
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
*
*/

using Newtonsoft.Json;

namespace IBM.Watson.CompareComply.v1.Model
{
    /// <summary>
    /// An effective date.
    /// </summary>
    public class EffectiveDates
    {
        /// <summary>
        /// The confidence level in the identification of the effective date.
        /// </summary>
        public class ConfidenceLevelEnumValue
        {
            /// <summary>
            /// Constant HIGH for High
            /// </summary>
            public const string HIGH = "High";
            /// <summary>
            /// Constant MEDIUM for Medium
            /// </summary>
            public const string MEDIUM = "Medium";
            /// <summary>
            /// Constant LOW for Low
            /// </summary>
            public const string LOW = "Low";
            
        }

        /// <summary>
        /// The confidence level in the identification of the effective date.
        /// Constants for possible values can be found using EffectiveDates.ConfidenceLevelEnumValue
        /// </summary>
        [JsonProperty("confidence_level", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfidenceLevel { get; set; }
        /// <summary>
        /// The effective date, listed as a string.
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }
        /// <summary>
        /// The numeric location of the identified element in the document, represented with two integers labeled
        /// `begin` and `end`.
        /// </summary>
        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public Location Location { get; set; }
    }

}
