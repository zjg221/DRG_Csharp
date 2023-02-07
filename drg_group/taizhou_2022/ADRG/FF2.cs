namespace drg_group.taizhou_2022{
    public class FF2
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"20.7100","20.7903","38.0000","38.0200x002","38.0200x003","38.0201","38.0202","38.0300x003","38.0300x005","38.0301","38.0302","38.0500x002","38.0501","38.0601","38.0602","38.0700x001","38.0700x003","38.0701","38.0703","38.0704","38.0705","38.0800x002","38.0800x003","38.0801","38.0802","38.0900x001","38.0900x002","38.0901","38.0902","38.1000x002","38.1200x003","38.1201","38.1202","38.1300","38.1600x002","38.1600x005","38.1601","38.1602","38.1603","38.1604","38.1800x001","38.1800x002","38.1800x003","38.1800x004","38.1800x005","38.1800x006","38.1800x007","38.1801","38.1802","38.1803","38.1804","38.3000","38.3000x001","38.3200x002","38.3201","38.3202","38.3300","38.3301","38.3701","38.3800","38.3900","38.4000","38.4200x001","38.4200x002","38.4200x003","38.4201","38.4202","38.4203","38.4300x001","38.4300x002","38.4301","38.4302","38.4303","38.4304","38.4500x002","38.4508","38.4509","38.4600x001","38.4600x003","38.4601","38.4602","38.4603","38.4604","38.4701","38.4800x001","38.4800x002","38.4801","38.4802","38.4803","38.4804","38.4805","38.4900x001","38.4900x002","38.5000","38.5201","38.5202","38.5300","38.5500","38.5701","38.5900x005","38.5900x008","38.5901","38.5902","38.5903","38.5904","38.5905","38.5906","38.5907","38.6000x010","38.6000x011","38.6000x012","38.6000x013","38.6200x002","38.6200x003","38.6200x005","38.6200x006","38.6200x007","38.6201","38.6300x001","38.6301","38.6302","38.6500x001","38.6500x002","38.6501","38.6600x002","38.6601","38.6602","38.6703","38.6705","38.6706","38.6800x002","38.6801","38.6802","38.6901","38.8000","38.8200x003","38.8200x005","38.8200x006","38.8200x007","38.8200x008","38.8201","38.8202","38.8203","38.8300x004","38.8301","38.8302","38.8303","38.8500x010","38.8500x016","38.8500x017","38.8503","38.8504","38.8600x004","38.8600x005","38.8601","38.8602","38.8603","38.8604","38.8605","38.8606","38.8607","38.8608","38.8609","38.8700x001","38.8700x002","38.8700x008","38.8700x009","38.8701","38.8702","38.8703","38.8704","38.8800x002","38.8801","38.8901","38.9100","38.9100x601","38.9100x602","38.9200","38.9300","38.9300x201","38.9300x701","38.9300x702","38.9300x901","38.9400","38.9501","38.9502","38.9700x002","38.9800x001","38.9800x801","38.9900x002","38.9900x501","38.9900x701","38.9900x901","39.0x02","39.1x00x007","39.1x00x012","39.1x00x013","39.1x07","39.1x10","39.2200x002","39.2200x003","39.2200x004","39.2200x005","39.2200x006","39.2200x011","39.2200x014","39.2200x018","39.2200x019","39.2202","39.2205","39.2206","39.2208","39.2209","39.2210","39.2211","39.2500x005","39.2500x006","39.2500x009","39.2500x010","39.2500x011","39.2500x012","39.2500x013","39.2500x014","39.2500x015","39.2501","39.2504","39.2506","39.2508","39.2600x002","39.2600x003","39.2600x004","39.2600x007","39.2600x009","39.2600x010","39.2602","39.2604","39.2605","39.2607","39.2900x001","39.2900x002","39.2900x003","39.2900x004","39.2900x005","39.2900x010","39.2900x011","39.2900x012","39.2900x013","39.2900x013","39.2900x015","39.2900x017","39.2900x019","39.2900x024","39.2900x025","39.2900x026","39.2900x027","39.2900x028","39.2900x030","39.2900x031","39.2900x032","39.2900x033","39.2900x034","39.2900x035","39.2900x036","39.2900x037","39.2900x038","39.2900x039","39.2900x040","39.2900x041","39.2900x042","39.2900x043","39.2900x044","39.2900x045","39.2900x046","39.2900x047","39.2900x048","39.2900x049","39.2901","39.2902","39.2903","39.2904","39.2905","39.2906","39.2907","39.2908","39.2909","39.2910","39.2911","39.2912","39.2913","39.2914","39.2915","39.2916","39.3100","39.3100x002","39.3100x004","39.3100x005","39.3100x006","39.3100x007","39.3100x009","39.3100x010","39.3101","39.3102","39.3103","39.3104","39.3105","39.3106","39.3108","39.3109","39.3110","39.3111","39.3112","39.3113","39.3200","39.3200x004","39.3201","39.3202","39.3204","39.3206","39.3207","39.4100x001","39.4100x002","39.4300x001","39.4301","39.4900x001","39.4900x004","39.4900x005","39.4900x006","39.4900x008","39.5100","39.5101","39.5102","39.5103","39.5104","39.5105","39.5106","39.5107","39.5108","39.5200x002","39.5200x003","39.5201","39.5202","39.5300x010","39.5300x011","39.5300x013","39.5300x015","39.5300x016","39.5300x017","39.5300x018","39.5302","39.5303","39.5304","39.5500","39.5601","39.5602","39.5701","39.5702","39.5800","39.5900x001","39.5900x003","39.5900x004","39.5900x005","39.5900x006","39.5900x007","39.5900x008","39.5900x010","39.5900x011","39.5900x013","39.5900x014","39.5900x019","39.5900x021","39.5900x022","39.5900x023","39.5900x024","39.5900x031","39.5900x033","39.5900x034","39.7900x015","39.7900x077","39.7900x078","39.7900x301","39.7900x801","39.8900x001","39.8901","39.9300","39.9401","39.9800x003","39.9900","40.0x01","40.2900x002","40.2900x008","40.2900x017","40.2900x018","40.2900x019","40.2900x020","40.2910","40.6301","40.9x00x003","40.9x00x004","40.9x00x005","40.9x00x006","40.9x00x007","40.9x00x008","40.9x00x009","40.9x00x010","40.9x00x011","40.9x00x012","40.9x00x013","40.9x00x014","40.9x00x015","40.9x00x016","40.9x00x017","40.9x01","40.9x02","40.9x03","40.9x04","40.9x05","40.9x06","40.9x07","40.9x08","40.9x09","54.9400x002","54.9401","55.9902","59.0200x007","59.0300x002","86.0701","87.3400x001","88.0400","88.0401","88.3400","88.3600","88.3900x001","88.8901","92.1601","99.6400","99.7200x002"};
            String[] adrg_ss1={"00.0102","00.0300","00.5500x009","00.5500x010","00.5500x011","00.5500x012","00.5500x013","00.5500x014","00.5500x015","00.5500x016","00.5500x017","00.5501","00.5502","00.5800","00.6000","00.6000x001","00.6300x006","07.4200x002","17.5600x001","38.2300","38.2500","38.7x03","38.7x04","39.5000x011","39.5000x013","39.5000x014","39.5000x019","39.5000x021","39.5000x024","39.5000x025","39.5000x026","39.5000x029","39.5000x030","39.5000x031","39.5000x041","39.5001","39.5002","39.5003","39.5004","39.5005","39.5006","39.5007","39.5008","39.5009","39.5010","39.5011","39.5012","39.5013","39.5014","39.5015","39.5016","39.5017","39.5900x025","39.5900x026","39.5900x027","39.5900x028","39.5900x029","39.7200x001","39.7201","39.7900x007","39.7900x009","39.7900x013","39.7900x017","39.7900x019","39.7900x020","39.7900x021","39.7900x022","39.7900x023","39.7900x024","39.7900x025","39.7900x027","39.7900x028","39.7900x029","39.7900x031","39.7900x032","39.7900x033","39.7900x034","39.7900x035","39.7900x036","39.7900x037","39.7900x038","39.7900x039","39.7900x040","39.7900x041","39.7900x042","39.7900x043","39.7900x044","39.7900x045","39.7900x046","39.7900x047","39.7900x049","39.7900x075","39.7900x809","39.7901","39.7902","39.7903","39.7904","39.7905","39.7906","39.7907","39.7910","39.9000x010","39.9000x011","39.9000x012","39.9000x016","39.9000x017","39.9000x019","39.9000x020","39.9000x021","39.9000x023","39.9000x024","39.9000x025","39.9000x028","39.9000x029","39.9000x030","39.9000x031","39.9000x032","39.9000x033","39.9000x034","39.9000x035","39.9000x036","39.9001","39.9003","39.9004","39.9005","39.9006","39.9007","39.9008","39.9009","39.9010","39.9011","39.9012","39.9013","39.9014","39.9015","39.9016","44.4400x001","87.0800x002","88.4201","88.4202","88.4203","88.4204","88.4205","88.4300x002","88.4400x001","88.4402","88.4403","88.4404","88.4405","88.4500","88.4600","88.4701","88.4702","88.4703","88.4704","88.4705","88.4706","88.4707","88.4800x005","88.4801","88.4900x005","88.4901","88.4902","88.4903","88.4904","88.5101","88.5102","88.6000","88.6200x001","88.6400x001","88.6400x002","88.6400x003","88.6401","88.6500x002","88.6500x005","88.6501","88.6502","88.6503","88.6600x002","88.6600x002","88.6601","88.6701","88.6702","88.6703","88.6800","99.1000x006","99.1000x007","99.1000x008","99.1000x009","99.1000x010","99.1000x011","99.1001","99.1002","99.1003","99.1004"};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && Base.intersect(record.ssList,adrg_ss) && Base.intersect(record.ssList,adrg_ss1)){
                Base.groupMessages.putMessage(record.Index,"符合FF2入组条件，匹配规则：双手术匹配");
                    
                if (MDCF_DRG.FF21_group(record))
                {
                    return "FF21";
                }
    
                if (MDCF_DRG.FF23_group(record))
                {
                    return "FF23";
                }
    
                if (MDCF_DRG.FF25_group(record))
                {
                    return "FF25";
                }

                return "FF2";
            }else{
                return "";
            }
        }
    }
}