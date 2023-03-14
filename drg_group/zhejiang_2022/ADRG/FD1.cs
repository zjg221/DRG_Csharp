namespace drg_group.zhejiang_2022{
    public class FD1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"35.1400x002","35.2100x002","35.3101","35.3400x001","35.4201","35.5400x003","35.5400x004","35.5400x005","35.5400x006","35.6100x001","35.6300x003","35.6300x004","35.6300x005","35.7100x008","35.7101","35.7200x002","35.7201","35.7300x002","35.7300x003","35.7300x004","35.7300x005","35.7300x006","35.7300x007","35.7301","35.8100x001","35.8100x002","35.8100x003","35.8100x004","35.8100x006","35.8200x006","35.8200x008","35.8200x009","35.8201","35.8300x004","35.8300x005","35.8301","35.8302","35.8303","35.8304","35.8305","35.8307","35.8308","35.8309","35.8400x001","35.8400x002","35.8400x003","35.8400x004","35.8400x005","35.9100x003","35.9100x004","35.9100x005","35.9101","35.9102","35.9200x001","35.9200x003","35.9200x004","35.9200x005","35.9201","35.9202","35.9300x002","35.9300x003","35.9300x004","35.9301","35.9302","35.9400x003","35.9400x004","35.9400x005","35.9400x006","35.9401","35.9402","35.9500x002","35.9500x007","35.9501","35.9900x002","36.9902","37.3501","38.8500x013","39.2100x001","39.2100x003","39.2100x004","39.2100x005","39.2100x006","39.2100x007","39.2102","39.4903","39.4904","39.5900x034"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && Base.intersect(record.ssList,adrg_ss)){
                Base.groupMessages.putMessage(record.Index,"符合FD1入组条件，匹配规则：某一手术匹配");
                    
                if (MDCF_DRG.FD19_group(record))
                {
                    return "FD19";
                }

                return "FD1";
            }else{
                return "";
            }
        }
    }
}