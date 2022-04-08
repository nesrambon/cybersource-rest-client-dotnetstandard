/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = CyberSource.Client.SwaggerDateConverter;

namespace CyberSource.Model
{
    /// <summary>
    /// ReportingV3InterchangeClearingLevelDetailsGet200Response
    /// </summary>
    [DataContract]
    public partial class ReportingV3InterchangeClearingLevelDetailsGet200Response :  IEquatable<ReportingV3InterchangeClearingLevelDetailsGet200Response>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingV3InterchangeClearingLevelDetailsGet200Response" /> class.
        /// </summary>
        /// <param name="StartDate">Valid report Start Date in **ISO 8601 format**. Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14  **Example:** - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZZ .</param>
        /// <param name="EndDate">Valid report Start Date in **ISO 8601 format**. .</param>
        /// <param name="InterchangeClearingLevelDetails">List of InterchangeClearingLevelDetail.</param>
        public ReportingV3InterchangeClearingLevelDetailsGet200Response(DateTime? StartDate = default(DateTime?), DateTime? EndDate = default(DateTime?), List<ReportingV3InterchangeClearingLevelDetailsGet200ResponseInterchangeClearingLevelDetails> InterchangeClearingLevelDetails = default(List<ReportingV3InterchangeClearingLevelDetailsGet200ResponseInterchangeClearingLevelDetails>))
        {
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.InterchangeClearingLevelDetails = InterchangeClearingLevelDetails;
        }
        
        /// <summary>
        /// Valid report Start Date in **ISO 8601 format**. Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14  **Example:** - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZZ 
        /// </summary>
        /// <value>Valid report Start Date in **ISO 8601 format**. Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14  **Example:** - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZZ </value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Valid report Start Date in **ISO 8601 format**. 
        /// </summary>
        /// <value>Valid report Start Date in **ISO 8601 format**. </value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// List of InterchangeClearingLevelDetail
        /// </summary>
        /// <value>List of InterchangeClearingLevelDetail</value>
        [DataMember(Name="interchangeClearingLevelDetails", EmitDefaultValue=false)]
        public List<ReportingV3InterchangeClearingLevelDetailsGet200ResponseInterchangeClearingLevelDetails> InterchangeClearingLevelDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportingV3InterchangeClearingLevelDetailsGet200Response {\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  InterchangeClearingLevelDetails: ").Append(InterchangeClearingLevelDetails).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ReportingV3InterchangeClearingLevelDetailsGet200Response);
        }

        /// <summary>
        /// Returns true if ReportingV3InterchangeClearingLevelDetailsGet200Response instances are equal
        /// </summary>
        /// <param name="other">Instance of ReportingV3InterchangeClearingLevelDetailsGet200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportingV3InterchangeClearingLevelDetailsGet200Response other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) && 
                (
                    this.EndDate == other.EndDate ||
                    this.EndDate != null &&
                    this.EndDate.Equals(other.EndDate)
                ) && 
                (
                    this.InterchangeClearingLevelDetails == other.InterchangeClearingLevelDetails ||
                    this.InterchangeClearingLevelDetails != null &&
                    this.InterchangeClearingLevelDetails.SequenceEqual(other.InterchangeClearingLevelDetails)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();
                if (this.InterchangeClearingLevelDetails != null)
                    hash = hash * 59 + this.InterchangeClearingLevelDetails.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}