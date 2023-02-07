namespace drg_group.wuhan_2022{
    public class ER2
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"I26.900x001","I26.900x002","I26.900x003","I26.900x005","I26.900x006","I26.900x007","I26.900x008","I26.900x009","I26.900x010","I26.900x011","I26.900x012","I26.900x013","I26.900x015","I26.900x016","I26.900x017","I26.900x018","I26.901","I26.902","I28.800x010","T79.100"};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && adrg_zd.Contains(record.zdList[0])){
                Base.groupMessages.putMessage(record.Index,"符合ER2入组条件，匹配规则：主诊断匹配");
                    
                if (MDCE_DRG.ER21_group(record))
                {
                    return "ER21";
                }
    
                if (MDCE_DRG.ER2B_group(record))
                {
                    return "ER2B";
                }

                return "ER2";
            }else{
                return "";
            }
        }
    }
}