namespace drg_group.xian_2020{
    public class BM1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"88.4100","88.4100x001","88.4101","88.4102","88.4103","88.4104","88.4401","88.6101","88.6102","88.6103"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合BM1入组条件，匹配规则：主手术匹配");
                    
                if (MDCB_DRG.BM19_group(record))
                {
                    return "BM19";
                }

                return "BM1";
            }else{
                return "";
            }
        }
    }
}