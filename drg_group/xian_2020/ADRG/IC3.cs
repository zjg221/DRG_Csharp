namespace drg_group.xian_2020{
    public class IC3
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"77.0600","77.1600x001","77.2900x007","77.6601","77.6900x013","77.8300x007","77.8600","77.8700x004","77.9600","78.0600x001","78.0600x003","78.1601","78.2300x001","78.4600x002","78.4600x003","78.5700x011","78.5700x012","78.5700x013","78.6600x003","79.0603","79.0604","79.1600x007","79.1600x008","79.1600x013","79.1603","79.2603","79.2900x004","79.3600x009","79.3600x010","79.3600x011","79.3600x012","79.3603","79.6900x002","79.7100","79.7200","79.7500","79.7600","79.7600x001","79.7700","79.7900x005","79.7900x007","79.8100x003","79.8100x004","79.8100x006","79.8200","79.8200x001","79.8201","79.8500","79.8500x001","79.8600","79.8700","79.8800x001","79.8800x002","79.8900x001","79.8900x008","79.8901","80.0100x001","80.0100x002","80.0101","80.0200x001","80.0200x002","80.0201","80.0500x001","80.0500x003","80.0501","80.0600x001","80.0600x002","80.0601","80.0700x001","80.0700x002","80.0701","80.1100","80.1100x001","80.1101","80.1200","80.1200x001","80.1200x002","80.1201","80.1500","80.1500x001","80.1500x002","80.1501","80.1600","80.1600x001","80.1601","80.1602","80.1603","80.1604","80.1700","80.1700x001","80.1701","80.1702","80.4101","80.4102","80.4201","80.4202","80.4500x001","80.4501","80.4502","80.4601","80.4602","80.4603","80.4700x002","80.4701","80.4702","80.6x00x002","80.6x00x010","80.6x00x011","80.6x01","80.6x02","80.6x03","80.6x04","80.6x05","80.6x06","80.6x07","80.6x08","80.7100","80.7101","80.7200","80.7201","80.7500","80.7501","80.7600","80.7601","80.7700","80.7701","80.8101","80.8102","80.8200x003","80.8201","80.8202","80.8501","80.8502","80.8600x009","80.8601","80.8602","80.8700x007","80.8701","80.8702","80.8900x005","80.9100","80.9200","80.9500","80.9600","80.9700","81.1100","81.1100x003","81.1101","81.1300x004","81.1500x001","81.2101","81.2201","81.2300x002","81.2300x003","81.2300x004","81.2300x005","81.2301","81.2401","81.2901","81.2902","81.4000","81.4000x004","81.4000x005","81.4000x006","81.4200","81.4300","81.4401","81.4402","81.4403","81.4501","81.4502","81.4503","81.4504","81.4505","81.4600x001","81.4601","81.4700x001","81.4700x005","81.4700x012","81.4700x013","81.4700x014","81.4700x015","81.4700x016","81.4700x017","81.4700x018","81.4700x019","81.4701","81.4900x001","81.4900x002","81.4900x003","81.4900x004","81.4900x005","81.4900x006","81.4901","81.4902","81.8200","81.8201","81.8300x001","81.8300x003","81.8300x004","81.8300x006","81.8300x007","81.8300x008","81.8300x009","81.8301","81.8302","81.8303","81.8304","81.8305","81.8401","81.8500x002","81.8500x004","81.8500x005","81.8500x006","81.8500x007","81.8500x008","81.9300x009","81.9300x010","81.9400x001","81.9400x006","81.9400x007","81.9401","81.9402","81.9500x001","81.9600x003","81.9600x020","81.9600x021","81.9600x022","81.9600x023","81.9600x024","81.9600x025","81.9600x026","81.9600x027","81.9600x028","81.9600x029","81.9600x030","81.9600x031","81.9600x032","83.1900x008","83.3100x008","83.4500x003","83.8800x010","84.0600","84.0800","84.0900x001","84.1300","84.1400","84.1600","84.1800","84.2302","84.2303","84.2304","84.2601","84.2801","84.4500"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合IC3入组条件，匹配规则：主手术匹配");
                    
                if (MDCI_DRG.IC39_group(record))
                {
                    return "IC39";
                }

                return "IC3";
            }else{
                return "";
            }
        }
    }
}