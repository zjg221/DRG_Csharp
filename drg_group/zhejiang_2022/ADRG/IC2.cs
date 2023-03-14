namespace drg_group.zhejiang_2022{
    public class IC2
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"00.7400","00.7500","00.7600","00.7700","00.8500x001","00.8600x001","00.8700x001","81.5100","81.5200x004","81.5201","81.5202","81.5400x004","81.5400x005","81.5400x007","81.5400x008","81.5401","81.5600","81.8000x003","81.8101","81.8400x002","81.8401","81.8800","81.9701","81.9702"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && Base.intersect(record.ssList,adrg_ss)){
                Base.groupMessages.putMessage(record.Index,"符合IC2入组条件，匹配规则：某一手术匹配");
                    
                if (MDCI_DRG.IC21_group(record))
                {
                    return "IC21";
                }
    
                if (MDCI_DRG.IC23_group(record))
                {
                    return "IC23";
                }
    
                if (MDCI_DRG.IC25_group(record))
                {
                    return "IC25";
                }

                return "IC2";
            }else{
                return "";
            }
        }
    }
}