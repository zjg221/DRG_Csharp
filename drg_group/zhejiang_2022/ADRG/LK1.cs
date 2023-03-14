namespace drg_group.zhejiang_2022{
    public class LK1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"55.0300x002","55.0300x003","55.0400x005","55.0400x006","55.0400x007","55.0400x008","55.0400x009","55.0400x010","55.0401","55.0402","55.0403","55.0404","55.0405","56.0x03","56.0x04","56.0x05","56.0x06","56.0x07","56.0x08","57.0x00x002","57.0x00x007","57.0x00x008","57.0x00x009","57.0x00x010","57.0x00x011","57.0x00x012","57.0x00x013","57.0x05","57.0x06","57.0x07","57.0x08","58.6x00x003","59.9502","98.5101","98.5102","98.5103","98.5104"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && Base.intersect(record.ssList,adrg_ss)){
                Base.groupMessages.putMessage(record.Index,"符合LK1入组条件，匹配规则：某一手术匹配");
                    
                if (MDCL_DRG.LK11_group(record))
                {
                    return "LK11";
                }
    
                if (MDCL_DRG.LK13_group(record))
                {
                    return "LK13";
                }
    
                if (MDCL_DRG.LK15_group(record))
                {
                    return "LK15";
                }

                return "LK1";
            }else{
                return "";
            }
        }
    }
}