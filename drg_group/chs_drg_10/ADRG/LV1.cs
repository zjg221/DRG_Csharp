namespace drg_group.chs_drg_10{
    public class LV1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"E10.200x011+N08.3*","E10.200x012+N08.3*","E10.200x013+N08.3*","E10.200x014+N08.3*","E10.200x015+N08.3*","E10.200x016+N08.3*","E10.200x017+N08.3*","E10.200x023+N08.3*","E10.200x024+N08.3*","E10.200x025+N08.3*","E10.200x026+N08.3*","E10.200x027+N08.3*","E10.200x028+N08.3*","E10.200x029+N08.3*","E10.200x030+N08.3*","E10.200x091+N08.3*","E10.200x092+N08.3*","E10.200x211+N08.3*","E10.200x212+N08.3*","E10.200x213+N08.3*","E10.201+N08.3*","E11.200x011+N08.3*","E11.200x012+N08.3*","E11.200x013+N08.3*","E11.200x014+N08.3*","E11.200x015+N08.3*","E11.200x016+N08.3*","E11.200x017+N08.3*","E11.200x023+N08.3*","E11.200x024+N08.3*","E11.200x025+N08.3*","E11.200x026+N08.3*","E11.200x027+N08.3*","E11.200x028+N08.3*","E11.200x029+N08.3*","E11.200x030+N08.3*","E11.200x091+N08.3*","E11.200x092+N08.3*","E11.200x211+N08.3*","E11.200x212+N08.3*","E11.200x213+N08.3*","E11.201+N08.3*","E12.200","E13.200x521+N08.3*","E13.201+N08.3*","E14.200x011+N08.3*","E14.200x012+N08.3*","E14.200x013+N08.3*","E14.200x014+N08.3*","E14.200x015+N08.3*","E14.200x016+N08.3*","E14.200x017+N08.3*","E14.200x021+N08.3*","E14.200x023+N08.3*","E14.200x024+N08.3*","E14.200x025+N08.3*","E14.200x026+N08.3*","E14.200x027+N08.3*","E14.200x028+N08.3*","E14.200x029+N08.3*","E14.200x030+N08.3*","E14.200x091+N08.3*","E14.200x092+N08.3*","E14.200x211+N08.3*","E14.200x212+N08.3*","E14.200x213+N08.3*","I12.900x001","I12.900x002","I12.900x003","I12.900x005","N28.900x017"};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && adrg_zd.Contains(record.zdList[0])){
                Base.groupMessages.putMessage(record.Index,"符合LV1入组条件，匹配规则：主诊断匹配");
                    
                if (MDCL_DRG.LV19_group(record))
                {
                    return "LV19";
                }

                return "LV1";
            }else{
                return "";
            }
        }
    }
}