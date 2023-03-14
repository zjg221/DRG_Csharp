namespace drg_group.xian_2020{
    public class IG1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"34.4x01","34.4x03","82.0101","82.0102","82.0103","82.0200x001","82.0201","82.0401","82.0402","82.1100x002","82.1101","82.1200x002","82.1201","82.1202","82.1900x002","82.1901","82.2100","82.2101","82.2200","82.2900x001","82.3200x001","82.3301","82.3400x001","82.3500x001","82.3500x002","82.3501","82.3600x001","82.3601","82.4100","82.4200","82.4300x001","82.4301","82.4400x001","82.4400x002","82.4500x001","82.4500x009","82.4500x010","82.4500x011","82.4500x012","82.4500x013","82.4501","82.4601","82.4602","82.5100","82.5200","82.5301","82.5401","82.5501","82.5502","82.5600x002","82.5600x003","82.5600x004","82.5600x005","82.5601","82.5602","82.5700x001","82.5801","82.5900x001","82.7100x002","82.7100x003","82.7100x004","82.7101","82.7201","82.7202","82.7900x001","82.7901","82.8500x001","82.8500x002","82.8600x001","82.8600x006","82.8600x010","82.8600x011","82.8600x012","82.8600x013","82.8901","82.8902","82.9100x004","82.9101","82.9102","82.9103","82.9501","82.9900","83.0100x001","83.0101","83.0102","83.0103","83.0200x005","83.0200x006","83.0201","83.0202","83.0203","83.0204","83.0205","83.0900x003","83.0901","83.1101","83.1201","83.1202","83.1300x001","83.1300x004","83.1300x006","83.1300x007","83.1300x008","83.1301","83.1302","83.1303","83.1400x006","83.1400x007","83.1400x008","83.1401","83.1402","83.1403","83.1404","83.1405","83.1900x001","83.1900x003","83.1900x009","83.1900x010","83.1900x012","83.1900x013","83.1900x017","83.1900x018","83.1900x019","83.1900x020","83.1900x023","83.1900x024","83.1900x025","83.1900x026","83.1900x027","83.1900x028","83.1900x030","83.1900x031","83.1901","83.1902","83.1903","83.2900x001","83.2900x003","83.3100","83.3100x001","83.3101","83.3200","83.3200x001","83.3200x007","83.3200x009","83.3200x012","83.3201","83.3900x018","83.3901","83.3903","83.4100x001","83.4200x002","83.4201","83.4202","83.4300x001","83.4301","83.4302","83.4400x001","83.4400x002","83.4400x003","83.4500x001","83.4500x004","83.4500x005","83.4500x006","83.4500x007","83.4500x008","83.4500x013","83.4501","83.4502","83.6100","83.6201","83.6300","83.6301","83.6400x007","83.6400x008","83.6400x009","83.6400x011","83.6400x013","83.6400x015","83.6401","83.6402","83.6403","83.6500x001","83.6500x002","83.6500x003","83.6500x005","83.6500x006","83.6500x011","83.6500x012","83.6500x013","83.6500x014","83.6500x015","83.6500x016","83.6500x017","83.6500x018","83.6500x019","83.6500x020","83.6500x021","83.6501","83.6502","83.6503","83.7100","83.7200","83.7300x002","83.7400x001","83.7500x003","83.7500x004","83.7500x005","83.7501","83.7600x002","83.7600x003","83.7600x005","83.7600x006","83.7600x007","83.7600x008","83.7600x009","83.7600x010","83.7600x011","83.7600x012","83.7600x013","83.7700x001","83.7700x003","83.7700x004","83.7700x005","83.7700x006","83.7700x007","83.7700x008","83.7700x009","83.7700x010","83.7700x011","83.7700x012","83.7700x013","83.7700x014","83.7700x015","83.7700x016","83.7700x017","83.7700x018","83.7700x019","83.7700x020","83.7700x021","83.7700x022","83.7700x023","83.7700x024","83.7700x025","83.7700x026","83.7700x027","83.7700x028","83.7700x029","83.7700x030","83.7700x031","83.7700x032","83.7700x033","83.7701","83.7702","83.7900x001","83.7900x002","83.7900x003","83.7900x004","83.7900x005","83.7900x006","83.7900x007","83.7900x008","83.7900x009","83.7900x010","83.7900x011","83.7900x012","83.7900x013","83.8100","83.8100x003","83.8101","83.8200x001","83.8200x005","83.8200x007","83.8200x008","83.8200x009","83.8200x010","83.8200x011","83.8201","83.8202","83.8300","83.8401","83.8500x001","83.8500x002","83.8500x003","83.8500x004","83.8500x005","83.8500x008","83.8500x009","83.8500x010","83.8500x011","83.8500x012","83.8500x013","83.8500x014","83.8500x015","83.8500x016","83.8500x017","83.8500x018","83.8500x019","83.8500x020","83.8500x021","83.8500x022","83.8500x023","83.8500x024","83.8500x025","83.8500x026","83.8500x027","83.8500x028","83.8500x029","83.8500x030","83.8500x031","83.8500x032","83.8500x033","83.8500x034","83.8500x035","83.8500x036","83.8500x037","83.8500x038","83.8500x039","83.8500x040","83.8500x041","83.8500x042","83.8500x043","83.8500x044","83.8500x055","83.8501","83.8502","83.8600","83.8700x001","83.8700x003","83.8700x005","83.8700x007","83.8700x009","83.8701","83.8800x001","83.8800x012","83.8800x014","83.8800x015","83.8800x016","83.8800x017","83.8800x018","83.8801","83.8802","83.8803","83.8900x002","83.8901","83.8902","83.8903","83.8904","83.8905","83.9100x001","83.9100x004","83.9100x005","83.9100x007","83.9100x008","83.9100x009","83.9101","83.9102","83.9103","83.9104","83.9105","83.9201","83.9202","83.9300","83.9900x003","86.2800x012","86.8900x011"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合IG1入组条件，匹配规则：主手术匹配");
                    
                if (MDCI_DRG.IG19_group(record))
                {
                    return "IG19";
                }

                return "IG1";
            }else{
                return "";
            }
        }
    }
}