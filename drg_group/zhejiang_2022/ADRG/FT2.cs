namespace drg_group.zhejiang_2022{
    public class FT2
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"A18.820+I39.8*","A32.802+I39.8*","A39.502+I39.8*","A52.006+I39.8*","A54.802+I39.8*","B33.200x002+I39.8*","B37.600+I39.8*","I33.000x001","I33.000x004","I33.000x006","I33.000x007","I33.000x008","I33.000x011","I33.000x012","I33.000x019","I33.000x020","I33.000x021","I33.000x022","I33.000x024","I33.001","I33.002","I33.003","I33.004","I33.005","I33.006","I33.007","I33.900"};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && adrg_zd.Contains(record.zdList[0])){
                Base.groupMessages.putMessage(record.Index,"符合FT2入组条件，匹配规则：主诊断匹配");
                    
                if (MDCF_DRG.FT21_group(record))
                {
                    return "FT21";
                }
    
                if (MDCF_DRG.FT23_group(record))
                {
                    return "FT23";
                }

                return "FT2";
            }else{
                return "";
            }
        }
    }
}