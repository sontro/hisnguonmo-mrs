//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LIS.EFMODEL.DataModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class LIS_SAMPLE
    {
        public LIS_SAMPLE()
        {
            this.LIS_SAMPLE_SERVICE = new HashSet<LIS_SAMPLE_SERVICE>();
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
        public string SAMPLE_ROOM_CODE { get; set; }
        public string SAMPLE_ROOM_NAME { get; set; }
        public string EXECUTE_ROOM_CODE { get; set; }
        public string EXECUTE_ROOM_NAME { get; set; }
        public string BARCODE { get; set; }
        public string SERVICE_REQ_CODE { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string PATIENT_CODE { get; set; }
        public long SAMPLE_STT_ID { get; set; }
        public string GENDER_CODE { get; set; }
        public Nullable<long> DOB { get; set; }
        public Nullable<long> RESULT_TIME { get; set; }
        public Nullable<long> BARCODE_TIME { get; set; }
        public string VIR_DATE_BARCODE { get; set; }
        public string REQUEST_ROOM_CODE { get; set; }
        public string REQUEST_ROOM_NAME { get; set; }
        public Nullable<short> IS_NOT_USE_BARCODE { get; set; }
        public Nullable<long> NUM_ORDER { get; set; }
        public Nullable<long> SAMPLE_TIME { get; set; }
        public Nullable<long> APPOINTMENT_TIME { get; set; }
        public Nullable<long> INTRUCTION_TIME { get; set; }
        public string SAMPLE_LOGINNAME { get; set; }
        public string SAMPLE_USERNAME { get; set; }
        public Nullable<long> APPROVAL_TIME { get; set; }
        public string APPROVAL_LOGINNAME { get; set; }
        public string APPROVAL_USERNAME { get; set; }
        public string TREATMENT_CODE { get; set; }
        public string REQUEST_DEPARTMENT_CODE { get; set; }
        public string REQUEST_DEPARTMENT_NAME { get; set; }
        public string REJECT_REASON { get; set; }
        public Nullable<long> SAMPLE_TYPE_ID { get; set; }
        public Nullable<long> SAMPLE_CONDITION_ID { get; set; }
        public string REQUEST_LOGINNAME { get; set; }
        public string REQUEST_USERNAME { get; set; }
        public Nullable<long> SAMPLE_ORDER { get; set; }
        public Nullable<short> IS_SAMPLE_ORDER_REQUEST { get; set; }
        public Nullable<long> CALL_SAMPLE_ORDER { get; set; }
        public string ADDRESS { get; set; }
        public Nullable<short> IS_ANTIBIOTIC_RESISTANCE { get; set; }
        public string KSK_CONTRACT_CODE { get; set; }
    
        public virtual LIS_SAMPLE_STT LIS_SAMPLE_STT { get; set; }
        public virtual LIS_SAMPLE_TYPE LIS_SAMPLE_TYPE { get; set; }
        public virtual LIS_SAMPLE_CONDITION LIS_SAMPLE_CONDITION { get; set; }
        public virtual ICollection<LIS_SAMPLE_SERVICE> LIS_SAMPLE_SERVICE { get; set; }
    }
}