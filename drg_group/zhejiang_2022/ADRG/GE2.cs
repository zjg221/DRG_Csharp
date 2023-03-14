namespace drg_group.zhejiang_2022{
    public class GE2
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"53.4101","53.4201","53.4301","53.4901","53.4902","53.5100","53.5101","53.5900x001","53.5901","53.5902","53.6101","53.6900x002","53.7101","53.7201","53.7202","53.7500","53.9x00x015","53.9x00x016","53.9x01","53.9x02","53.9x03","53.9x04","53.9x05","53.9x06"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && Base.intersect(record.ssList,adrg_ss)){
                Base.groupMessages.putMessage(record.Index,"符合GE2入组条件，匹配规则：某一手术匹配");
                    
                if (MDCG_DRG.GE21_group(record))
                {
                    return "GE21";
                }
    
                if (MDCG_DRG.GE23_group(record))
                {
                    return "GE23";
                }
    
                if (MDCG_DRG.GE25_group(record))
                {
                    return "GE25";
                }

                return "GE2";
            }else{
                return "";
            }
        }
    }
}