namespace drg_group.wuhan_2022{
    public class RU2
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"Z51.800x095","Z51.800x951","Z51.800x952","Z51.802","Z51.805","Z51.808","Z51.810"};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && adrg_zd.Contains(record.zdList[0])){
                Base.groupMessages.putMessage(record.Index,"符合RU2入组条件，匹配规则：主诊断匹配");
                    
                if (MDCR_DRG.RU21_group(record))
                {
                    return "RU21";
                }
    
                if (MDCR_DRG.RU23_group(record))
                {
                    return "RU23";
                }
    
                if (MDCR_DRG.RU25_group(record))
                {
                    return "RU25";
                }

                return "RU2";
            }else{
                return "";
            }
        }
    }
}