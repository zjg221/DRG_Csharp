namespace drg_group.zhejiang_2022{
    public class ES1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"A15.000x001","A15.000x002","A15.000x003","A15.000x010","A15.000x012","A15.000x014","A15.000x016","A15.000x018","A15.000x020","A15.000x022","A15.000x024","A15.000x026","A15.000x028","A15.001","A15.002","A15.003","A15.004","A15.005","A15.006","A15.007","A15.008","A15.009","A15.100x001","A15.100x002","A15.100x003","A15.100x004","A15.100x005","A15.100x006","A15.100x007","A15.100x008","A15.100x009","A15.100x010","A15.100x011","A15.101","A15.102","A15.103","A15.104","A15.105","A15.106","A15.107","A15.108","A15.109","A15.200x001","A15.201","A15.202","A15.203","A15.204","A15.205","A15.206","A15.207","A15.208","A15.209","A15.301","A15.302","A15.303","A15.304","A15.305","A15.306","A15.307","A15.308","A15.309","A15.400x001","A15.401","A15.402","A15.403","A15.404","A15.405","A15.406","A15.407","A15.408","A15.409","A15.500x001","A15.500x002","A15.500x003","A15.500x004","A15.500x010","A15.500x011","A15.500x012","A15.500x013","A15.500x014","A15.500x015","A15.500x016","A15.500x017","A15.500x018","A15.500x019","A15.500x020","A15.500x021","A15.500x022","A15.500x023","A15.500x024","A15.500x025","A15.500x026","A15.500x027","A15.500x028","A15.500x029","A15.501","A15.502","A15.503","A15.504","A15.505","A15.506","A15.507","A15.508","A15.509","A15.601","A15.602","A15.603","A15.604","A15.605","A15.606","A15.607","A15.608","A15.609","A15.701","A15.702","A15.703","A15.800x001","A15.800x002","A15.801","A15.802","A15.803","A15.804","A15.805","A15.806","A15.807","A15.808","A15.809","A15.810","A15.811","A15.812","A15.813","A15.814","A15.900","A15.901","A16.000x001","A16.000x002","A16.001","A16.002","A16.003","A16.004","A16.005","A16.006","A16.007","A16.008","A16.009","A16.010","A16.011","A16.012","A16.013","A16.014","A16.015","A16.016","A16.017","A16.018","A16.019","A16.020","A16.021","A16.022","A16.023","A16.024","A16.025","A16.026","A16.027","A16.028","A16.029","A16.030","A16.031","A16.032","A16.033","A16.034","A16.035","A16.036","A16.037","A16.038","A16.100x001","A16.101","A16.102","A16.103","A16.104","A16.105","A16.106","A16.107","A16.108","A16.109","A16.200x002","A16.200x007","A16.200x012","A16.200x013","A16.200x014","A16.200x015","A16.201","A16.202","A16.203","A16.204","A16.205","A16.206","A16.207","A16.208","A16.209","A16.210","A16.300x002","A16.300x003","A16.300x007","A16.301","A16.302","A16.303","A16.304","A16.305","A16.400x004","A16.400x005","A16.400x010","A16.400x011","A16.401","A16.402","A16.403","A16.404","A16.405","A16.406","A16.500x001","A16.500x004","A16.500x008","A16.500x009","A16.500x010","A16.501","A16.502","A16.503","A16.504","A16.505","A16.700x001","A16.700x002","A16.701","A16.800x002","A16.800x003","A16.800x024","A16.801","A16.802","A16.803","A16.804","A16.805","A16.806","A16.807","A16.900x001","A16.900x002","A16.900x003","A16.900x023","A19.000","A19.001","A19.800x010","A19.800x011","A19.800x012","A19.800x013","A19.800x014","A19.800x015","A19.800x016","A19.800x017","A19.800x018","A19.800x019","A19.800x020","A19.800x021","A19.800x022","A19.800x023","A19.800x024","A19.800x025","A19.800x026","A19.800x027","A19.800x028","A19.800x029","A19.801","A19.802","A19.803"};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && adrg_zd.Contains(record.zdList[0])){
                Base.groupMessages.putMessage(record.Index,"符合ES1入组条件，匹配规则：主诊断匹配");
                    
                if (MDCE_DRG.ES11_group(record))
                {
                    return "ES11";
                }
    
                if (MDCE_DRG.ES13_group(record))
                {
                    return "ES13";
                }
    
                if (MDCE_DRG.ES15_group(record))
                {
                    return "ES15";
                }
    
                if (MDCE_DRG.ES19_group(record))
                {
                    return "ES19";
                }

                return "ES1";
            }else{
                return "";
            }
        }
    }
}