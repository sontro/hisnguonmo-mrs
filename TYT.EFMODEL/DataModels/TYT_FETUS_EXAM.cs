//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TYT.EFMODEL.DataModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class TYT_FETUS_EXAM
    {
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
        public string BRANCH_CODE { get; set; }
        public string PATIENT_CODE { get; set; }
        public string PERSON_CODE { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string VIR_PERSON_NAME { get; set; }
        public long DOB { get; set; }
        public Nullable<short> IS_HAS_NOT_DAY_DOB { get; set; }
        public string GENDER_NAME { get; set; }
        public string PERSON_ADDRESS { get; set; }
        public string CAREER_NAME { get; set; }
        public string ETHNIC_NAME { get; set; }
        public string BHYT_NUMBER { get; set; }
        public Nullable<long> LAST_MENSES_TIME { get; set; }
        public Nullable<long> WEEK { get; set; }
        public Nullable<long> BORN_TIME { get; set; }
        public Nullable<long> FETUS_COUNT { get; set; }
        public Nullable<decimal> WEIGHT { get; set; }
        public Nullable<decimal> HEIGHT { get; set; }
        public Nullable<long> BLOOD_PRESSURE_MAX { get; set; }
        public Nullable<long> BLOOD_PRESSURE_MIN { get; set; }
        public Nullable<decimal> UTERUS { get; set; }
        public Nullable<long> BELLY { get; set; }
        public Nullable<long> PELVIC { get; set; }
        public Nullable<long> BLOOD { get; set; }
        public Nullable<long> PROTEIN { get; set; }
        public Nullable<short> IS_HIV_TEST { get; set; }
        public string OTHER_TEST { get; set; }
        public string BORN_GUESS { get; set; }
        public Nullable<long> UV_COUNT { get; set; }
        public Nullable<short> IS_FOLIC { get; set; }
        public Nullable<long> FETUS_HEART { get; set; }
        public string FETUS_POSITION { get; set; }
        public string DOCTOR_LOGINNAME { get; set; }
        public string DOCTOR_USERNAME { get; set; }
        public string NOTE { get; set; }
        public Nullable<long> EXAM_TIME { get; set; }
        public string HEALTH_HISTORY { get; set; }
    }
}