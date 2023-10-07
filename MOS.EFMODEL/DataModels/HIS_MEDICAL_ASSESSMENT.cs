//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MOS.EFMODEL.DataModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class HIS_MEDICAL_ASSESSMENT
    {
        public HIS_MEDICAL_ASSESSMENT()
        {
            this.HIS_ASSESSMENT_MEMBER = new HashSet<HIS_ASSESSMENT_MEMBER>();
        }
    
        public long ID { get; set; }
        public Nullable<long> CREATE_TIME { get; set; }
        public Nullable<long> MODIFY_TIME { get; set; }
        public string CREATOR { get; set; }
        public string MODIFIER { get; set; }
        public string APP_CREATOR { get; set; }
        public string APP_MODIFIER { get; set; }
        public Nullable<short> IS_ACTIVE { get; set; }
        public Nullable<short> IS_DELETE { get; set; }
        public string GROUP_CODE { get; set; }
        public long TREATMENT_ID { get; set; }
        public long ASSESSMENT_OBJECT_ID { get; set; }
        public Nullable<long> ASSESSMENT_TYPE_ID { get; set; }
        public string WELFARE_TYPE_IDS { get; set; }
        public long ASSESSMENT_TIME_FROM { get; set; }
        public string REPORT_NUMBER { get; set; }
        public Nullable<decimal> PREVIOUS_INJURY_RATE { get; set; }
        public string REFERRAL_CODE { get; set; }
        public Nullable<long> REQUEST_TIME { get; set; }
        public string REQUEST_ORG_CODE { get; set; }
        public string REQUEST_ORG_NAME { get; set; }
        public string EXAMINATION_RESULT { get; set; }
        public string LEGAL_GROUND_NUMBERS { get; set; }
        public Nullable<decimal> INJURY_RATE { get; set; }
        public Nullable<decimal> INJURY_RATE_TOTAL { get; set; }
        public Nullable<long> DISABILITY_TYPE_ID { get; set; }
        public Nullable<long> DISABILITY_STATUS_ID { get; set; }
        public string REQUEST_AFTER_ASSESSMENT { get; set; }
        public string CONCLUSION { get; set; }
        public string ASSESSMENT_BOARD_NAME { get; set; }
        public Nullable<long> ASSESSMENT_TIME_TO { get; set; }
        public string ASSESSMENT_PURPOSE { get; set; }
        public string LEGAL_GROUND_DOCUMENTS { get; set; }
        public string ASSESSMENT_REQUEST_CONTENT { get; set; }
        public string PATHOLOGICAL_HISTORY { get; set; }
        public string DISCUSSION { get; set; }
    
        public virtual ICollection<HIS_ASSESSMENT_MEMBER> HIS_ASSESSMENT_MEMBER { get; set; }
        public virtual HIS_ASSESSMENT_OBJECT HIS_ASSESSMENT_OBJECT { get; set; }
        public virtual HIS_TREATMENT HIS_TREATMENT { get; set; }
    }
}