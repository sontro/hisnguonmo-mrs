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
    
    public partial class HIS_EXP_MEST_REASON
    {
        public HIS_EXP_MEST_REASON()
        {
            this.HIS_EXME_REASON_CFG = new HashSet<HIS_EXME_REASON_CFG>();
            this.HIS_EXP_MEST = new HashSet<HIS_EXP_MEST>();
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
        public string EXP_MEST_REASON_CODE { get; set; }
        public string EXP_MEST_REASON_NAME { get; set; }
        public Nullable<short> IS_DEPA { get; set; }
        public Nullable<short> IS_ODD { get; set; }
    
        public virtual ICollection<HIS_EXME_REASON_CFG> HIS_EXME_REASON_CFG { get; set; }
        public virtual ICollection<HIS_EXP_MEST> HIS_EXP_MEST { get; set; }
    }
}