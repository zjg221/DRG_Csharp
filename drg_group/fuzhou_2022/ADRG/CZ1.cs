namespace drg_group.fuzhou_2022{
    public class CZ1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"D16.408","D17.700x005","D18.000x002","D18.000x804","D18.000x805","D18.000x821","D21.000","D21.003","D22.100","D22.100x004","D23.100x001","D23.100x002","D23.100x003","D23.101","D23.302","D31.000x001","D31.000x002","D31.100","D31.200","D31.300","D31.400","D31.402","D31.500x001","D31.500x003","D31.501","D31.502","D31.600","D31.600x001","D31.601","D31.602","D31.603","D31.604","D31.605","D31.900","D31.901","D48.703","D48.705","D86.801","E05.002+H06.2*","E50.000x001+H13.8*","E50.100x002+H13.8*","E50.200x001+H19.8*","E50.300x001+H19.8*","E50.400x001+H19.8*","E50.500x001+H58.1*","E50.600x001+H19.8*","E50.701+H19.8*","E65.x00x006","E70.302","E85.418","H00.000x001","H00.001","H00.002","H00.100","H01.000","H01.100","H01.100x003","H01.100x004","H01.100x005","H01.100x006","H01.100x007","H01.101","H01.801","H01.802","H01.900","H01.901","H02.000","H02.000x004","H02.001","H02.002","H02.003","H02.004","H02.100","H02.101","H02.102","H02.103","H02.200","H02.300","H02.300x004","H02.301","H02.400","H02.500","H02.500x008","H02.501","H02.502","H02.503","H02.504","H02.506","H02.600","H02.700","H02.700x001","H02.700x008","H02.702","H02.703","H02.704","H02.705","H02.800x011","H02.800x014","H02.800x016","H02.800x018","H02.801","H02.802","H02.803","H02.804","H02.805","H02.806","H02.807","H02.808","H02.809","H02.810","H02.811","H02.812","H02.813","H02.900","H02.900x003","H02.901","H04.000","H04.000x004","H04.001","H04.002","H04.003","H04.100","H04.101","H04.102","H04.103","H04.104","H04.105","H04.200","H04.300","H04.300x004","H04.300x005","H04.302","H04.303","H04.304","H04.305","H04.400","H04.401","H04.402","H04.500x001","H04.500x004","H04.501","H04.502","H04.503","H04.504","H04.505","H04.506","H04.507","H04.508","H04.509","H04.600","H04.600x003","H04.601","H04.602","H04.603","H04.604","H04.800x002","H04.800x003","H04.801","H04.900","H04.900x001","H04.901","H05.100x008","H05.200","H05.201","H05.202","H05.203","H05.204","H05.300","H05.300x003","H05.301","H05.400","H05.800","H05.800x002","H05.800x003","H05.800x005","H05.800x006","H05.801","H05.802","H05.900","H05.900x002","H05.900x003","H05.900x004","H05.901","H10.000","H10.100","H10.101","H10.102","H10.103","H10.200","H10.200x001","H10.400","H10.401","H10.500","H10.500x001","H10.800x001","H10.801","H10.900","H10.901","H11.000","H11.100","H11.100x001","H11.100x007","H11.101","H11.102","H11.103","H11.104","H11.105","H11.106","H11.107","H11.108","H11.200","H11.201","H11.400","H11.401","H11.402","H11.403","H11.404","H11.405","H11.800x005","H11.800x006","H11.801","H11.802","H11.803","H11.804","H11.805","H11.806","H11.807","H11.808","H11.900","H11.901","H15.000","H15.000x002","H15.001","H15.100","H15.800x008","H15.800x009","H15.800x010","H15.801","H15.802","H15.803","H15.804","H15.805","H15.806","H15.900","H16.100","H16.100x004","H16.100x005","H16.100x006","H16.100x007","H16.100x008","H16.100x009","H16.400","H16.401","H16.402","H17.000","H17.100","H17.801","H17.802","H17.803","H17.901","H17.902","H18.000","H18.000x004","H18.000x005","H18.000x006","H18.001","H18.002","H18.003","H18.100","H18.200","H18.300","H18.300x001","H18.300x002","H18.400","H18.400x003","H18.400x004","H18.401","H18.402","H18.403","H18.404","H18.405","H18.500","H18.500x005","H18.500x007","H18.501","H18.502","H18.504","H18.506","H18.600","H18.700","H18.700x005","H18.701","H18.702","H18.800x005","H18.800x007","H18.800x009","H18.800x012","H18.800x014","H18.801","H18.802","H18.803","H18.804","H18.805","H18.806","H18.807","H18.808","H18.900","H18.901","H20.000x003","H20.000x004","H20.001","H20.002","H20.003","H20.004","H20.100","H20.100x002","H20.101","H20.200x001","H20.803","H20.900x002","H20.900x004","H20.900x006","H21.100","H21.101","H21.102","H21.103","H21.104","H21.200","H21.200x005","H21.200x006","H21.200x007","H21.200x008","H21.200x009","H21.201","H21.202","H21.203","H21.204","H21.300x005","H21.300x006","H21.300x007","H21.300x008","H21.300x009","H21.300x010","H21.300x011","H21.300x012","H21.300x013","H21.301","H21.302","H21.303","H21.400","H21.401","H21.402","H21.403","H21.500","H21.500x003","H21.500x004","H21.500x011","H21.500x013","H21.500x015","H21.501","H21.502","H21.503","H21.504","H21.505","H21.506","H21.507","H21.508","H21.510","H21.800","H21.800x001","H21.801","H21.802","H21.900","H21.901","H30.000","H30.000x002","H30.000x004","H30.000x005","H30.001","H30.100","H30.100x002","H30.100x003","H30.200","H30.201","H30.800x002","H30.801","H30.900","H30.900x001","H30.900x002","H30.901","H30.902","H30.903","H31.100","H31.101","H31.102","H31.200","H31.200x002","H31.200x003","H31.200x004","H31.200x005","H31.200x006","H31.800x001","H31.800x002","H31.800x003","H31.800x004","H31.801","H31.802","H31.900","H31.901","H33.000","H33.000x005","H33.000x006","H33.000x007","H33.001","H33.002","H33.100","H33.100x004","H33.100x005","H33.100x006","H33.101","H33.102","H35.000x004","H35.005","H35.006","H35.010","H35.015","H35.100","H35.200","H35.200x001","H35.300","H35.300x007","H35.300x008","H35.300x009","H35.300x010","H35.300x011","H35.300x012","H35.301","H35.302","H35.303","H35.304","H35.305","H35.306","H35.307","H35.400","H35.400x001","H35.400x003","H35.400x004","H35.400x005","H35.400x006","H35.400x007","H35.500","H35.500x003","H35.500x004","H35.500x005","H35.500x006","H35.500x007","H35.500x008","H35.500x009","H35.501","H35.502","H35.503","H35.700","H35.700x005","H35.701","H35.702","H35.800x005","H35.800x008","H35.800x009","H35.800x010","H35.800x011","H35.801","H35.802","H35.803","H35.804","H35.805","H35.806","H35.807","H35.808","H35.809","H35.900","H40.002","H40.102","H40.500x001","H43.000","H43.001","H43.100x003","H43.200","H43.200x001","H43.300","H43.800x003","H43.800x004","H43.800x005","H43.801","H43.802","H43.803","H43.804","H43.805","H43.806","H43.900","H44.200","H44.200x001","H44.300","H44.300x001","H44.300x002","H44.300x003","H44.301","H44.302","H44.400","H44.401","H44.402","H44.500","H44.502","H44.503","H44.600","H44.800","H44.802","H44.803","H44.900","H44.901","H47.005","H47.100","H47.101","H47.300","H47.400","H49.807","H52.000","H52.100","H52.101","H52.200","H52.300x002","H52.301","H52.400","H52.600","H52.700","H52.701","H53.000","H53.000x001","H53.000x004","H53.000x005","H53.001","H53.002","H53.100","H53.100x001","H53.100x004","H53.101","H53.102","H53.103","H53.104","H53.105","H53.300","H53.300x001","H53.300x002","H53.300x003","H53.300x004","H53.401","H53.500","H53.500x002","H53.500x003","H53.500x004","H53.500x005","H53.500x006","H53.500x007","H53.500x008","H53.500x009","H53.501","H53.600","H53.800x001","H53.800x002","H53.801","H53.802","H53.803","H53.900","H54.000","H54.001","H54.100","H54.200","H54.300","H54.400","H54.400x002","H54.500","H54.600","H54.601","H54.900","H57.100","H57.100x002","H57.800x003","H57.800x004","H57.800x007","H57.900","H59.000","H59.001","H59.002","H59.003","H59.800x003","H59.800x008","H59.800x009","H59.800x010","H59.800x011","H59.800x013","H59.800x014","H59.800x015","H59.802","H59.803","H59.804","H59.805","H59.806","H59.807","H59.813","I72.803","L65.905","Q10.000","Q10.100","Q10.200","Q10.300","Q10.300x008","Q10.300x011","Q10.300x012","Q10.301","Q10.302","Q10.303","Q10.304","Q10.306","Q10.307","Q10.400","Q10.401","Q10.402","Q10.403","Q10.404","Q10.500","Q10.500x003","Q10.500x004","Q10.600","Q10.600x002","Q10.601","Q10.602","Q10.700","Q10.701","Q11.000","Q11.100","Q11.200","Q11.200x001","Q11.201","Q11.202","Q11.203","Q11.300","Q12.100","Q12.200","Q12.300","Q12.400","Q12.800","Q12.801","Q12.900","Q13.000","Q13.100","Q13.201","Q13.202","Q13.203","Q13.300","Q13.301","Q13.400x001","Q13.400x004","Q13.400x006","Q13.401","Q13.405","Q13.500","Q13.500x002","Q13.801","Q13.802","Q13.803","Q13.900","Q14.000","Q14.001","Q14.002","Q14.003","Q14.100","Q14.101","Q14.102","Q14.103","Q14.104","Q14.200","Q14.201","Q14.202","Q14.203","Q14.300x001","Q14.301","Q14.801","Q14.900","Q15.000x001","Q15.002","Q15.801","Q15.802","Q15.803","Q15.900","Q18.803","Q75.500","Q85.900x046","Q87.005","R44.100","R93.800x008","R94.101","R94.105","R94.106","S05.400x001","S05.400x002","S05.500x001","T20.000x010","T20.000x011","T20.100x010","T20.100x011","T20.100x012","T20.200x010","T20.200x011","T20.200x012","T20.300x010","T20.300x011","T20.300x012","T20.400x010","T20.400x011","T20.400x012","T20.500x010","T20.500x011","T20.500x012","T20.600x010","T20.600x011","T20.600x012","T20.700x010","T20.700x011","T20.700x012","T26.000","T26.001","T26.002","T26.100x001","T26.100x003","T26.101","T26.102","T26.200x001","T26.301","T26.400","T26.400x001","T26.401","T26.500","T26.500x002","T26.500x003","T26.600x001","T26.600x002","T26.600x003","T26.601","T26.602","T26.603","T26.604","T26.605","T26.700x001","T26.800x001","T26.900","T26.900x001","T26.901","T26.902","T79.800x006","T85.800x805","T85.800x806","T85.800x807","T85.800x808","T85.800x809","T85.903","T86.800x802","T86.800x804","T86.800x811","T86.800x812","T86.800x816","T86.801","T86.809","T86.810","T90.101","Z41.101","Z42.003","Z42.004","Z44.201","Z46.000","Z48.801","Z52.500"};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && adrg_zd.Contains(record.zdList[0])){
                Base.groupMessages.putMessage(record.Index,"符合CZ1入组条件，匹配规则：主诊断匹配");
                    
                if (MDCC_DRG.CZ19_group(record))
                {
                    return "CZ19";
                }

                return "CZ1";
            }else{
                return "";
            }
        }
    }
}