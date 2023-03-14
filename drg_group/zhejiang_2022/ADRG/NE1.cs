namespace drg_group.zhejiang_2022{
    public class NE1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"68.2100x002","68.2101","68.2201","68.2202","68.2204","68.2206","68.2300","68.2300x005","68.2301","68.2302","68.2900x038","68.2900x048","68.2902","68.2903","68.2913","68.2914","68.2915","68.2916","69.7x00","97.7101","97.7102","98.1600x001","98.1600x002"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && Base.intersect(record.ssList,adrg_ss)){
                Base.groupMessages.putMessage(record.Index,"符合NE1入组条件，匹配规则：某一手术匹配");
                    
                if (MDCN_DRG.NE11_group(record))
                {
                    return "NE11";
                }
    
                if (MDCN_DRG.NE13_group(record))
                {
                    return "NE13";
                }
    
                if (MDCN_DRG.NE15_group(record))
                {
                    return "NE15";
                }

                return "NE1";
            }else{
                return "";
            }
        }
    }
}