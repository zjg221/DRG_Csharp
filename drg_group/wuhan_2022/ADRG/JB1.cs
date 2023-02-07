namespace drg_group.wuhan_2022{
    public class JB1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_ss={"85.3100","85.3200","85.3500x001","85.5100x001","85.5200x001","85.5300x001","85.5400x001","85.5500x001","85.5500x002","85.6x00x001","85.7000x001","85.7100x001","85.7200x001","85.7300x001","85.7400x001","85.7500x001","85.7600x001","85.7900x001","85.8601","85.8700x003","85.8701","85.8702","85.8900x005","85.8900x006","85.8900x007","85.8900x008","85.8901","85.9300"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合JB1入组条件，匹配规则：主手术匹配");
                    
                if (MDCJ_DRG.JB11_group(record))
                {
                    return "JB11";
                }
    
                if (MDCJ_DRG.JB1B_group(record))
                {
                    return "JB1B";
                }

                return "JB1";
            }else{
                return "";
            }
        }
    }
}