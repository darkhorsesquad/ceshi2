//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Share_data
    {
        public int Share_data_ID { get; set; }
        public string Share_DataRoute { get; set; }
        public System.DateTime CreationData { get; set; }
        public System.DateTime ExpirationData { get; set; }
        public string Extraction_Code { get; set; }
        public int Permanent { get; set; }
        public int Share_people { get; set; }
    
        public virtual User User { get; set; }
    }
}
