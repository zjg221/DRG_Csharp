namespace drg_group.xian_2020
{
    public class MDCT
    {
        public static String group(MedicalRecord record){
            String[] mdc_zd={"F04.x00x001","F04.x00x901","F05.000","F05.000x001","F05.001","F05.100","F05.101","F05.801","F05.802","F05.900","F05.901","F05.902","F06.000","F06.100","F06.200","F06.300","F06.300x002","F06.300x010","F06.300x020","F06.300x021","F06.300x030","F06.301","F06.302","F06.400","F06.400x003","F06.500","F06.600","F06.700","F06.800","F06.800x002","F06.800x003","F06.800x004","F06.800x005","F06.800x006","F06.800x007","F06.800x008","F06.800x009","F06.800x010","F06.800x011","F06.800x012","F06.800x013","F06.800x014","F06.800x015","F06.800x016","F06.800x017","F06.800x018","F06.800x019","F06.800x020","F06.800x021","F06.800x023","F06.800x024","F06.800x025","F06.800x026","F06.800x027","F06.800x032","F06.800x033","F06.800x034","F06.800x037","F06.800x038","F06.800x039","F06.800x040","F06.800x041","F06.800x042","F06.800x043","F06.800x044","F06.800x045","F06.800x046","F06.800x047","F06.800x048","F06.800x049","F06.800x050","F06.801","F06.802","F06.803","F06.804","F06.805","F06.806","F06.807","F06.808","F06.809","F06.810","F06.811","F06.900","F07.000","F07.001","F07.100","F07.200","F07.201","F07.800x001","F07.800x002","F07.800x003","F07.900","F07.900x001","F07.901","F09.x00x003","F09.x00x004","F09.x01","F09.x02","F09.x03","F20.000","F20.100","F20.200","F20.200x002","F20.201","F20.300","F20.301","F20.400","F20.500","F20.501","F20.600","F20.800x001","F20.800x002","F20.800x003","F20.801","F20.802","F20.803","F20.900","F21.x00","F22.000","F22.001","F22.002","F22.003","F22.800","F22.800x001","F22.900","F23.000","F23.001","F23.002","F23.100","F23.200","F23.200x003","F23.200x011","F23.300x001","F23.300x002","F23.300x003","F23.301","F23.800","F23.900","F23.901","F23.902","F23.903","F24.x00","F25.000","F25.000x001","F25.100","F25.100x001","F25.200","F25.200x001","F25.200x002","F25.800","F25.900","F28.x00x002","F28.x00x011","F28.x00x012","F28.x01","F28.x02","F29.x00","F30.000","F30.100","F30.100x001","F30.200","F30.200x001","F30.200x002","F30.201","F30.800x002","F30.900","F30.901","F31.000","F31.100","F31.200","F31.300x002","F31.300x003","F31.300x005","F31.300x011","F31.300x012","F31.301","F31.400","F31.500","F31.600","F31.700","F31.800x001","F31.800x002","F31.800x003","F31.801","F31.802","F31.803","F31.900","F31.901","F31.902","F32.000x002","F32.000x011","F32.100x002","F32.100x011","F32.200","F32.300","F32.301","F32.800x001","F32.800x002","F32.801","F32.802","F32.900","F32.901","F32.902","F33.000","F33.000x002","F33.000x011","F33.100","F33.100x002","F33.100x011","F33.200","F33.300","F33.400","F33.800","F33.900","F34.000","F34.001","F34.002","F34.100","F34.101","F34.102","F34.800","F34.900","F38.000x001","F38.001","F38.100x001","F38.100x002","F38.800","F39.x00","F40.000","F40.100","F40.200x001","F40.200x002","F40.200x003","F40.200x004","F40.800","F40.900","F40.901","F41.000","F41.001","F41.100","F41.101","F41.102","F41.200","F41.200x002","F41.201","F41.300x001","F41.800","F41.900","F42.000","F42.001","F42.003","F42.100","F42.101","F42.200","F42.800","F42.800x001","F42.900","F42.901","F43.000","F43.001","F43.002","F43.100","F43.101","F43.200","F43.200x031","F43.200x041","F43.200x051","F43.200x081","F43.800x002","F43.801","F43.802","F43.803","F43.804","F43.900","F44.000","F44.100","F44.200","F44.300","F44.301","F44.400","F44.401","F44.402","F44.403","F44.404","F44.405","F44.406","F44.407","F44.500","F44.501","F44.600","F44.600x002","F44.601","F44.602","F44.603","F44.700","F44.800x002","F44.800x011","F44.800x012","F44.800x021","F44.801","F44.802","F44.804","F44.805","F44.900","F44.901","F44.902","F44.903","F45.000","F45.100","F45.200","F45.201","F45.202","F45.300","F45.300x021","F45.300x022","F45.300x031","F45.300x041","F45.300x051","F45.300x091","F45.301","F45.302","F45.303","F45.304","F45.305","F45.306","F45.307","F45.308","F45.309","F45.310","F45.400","F45.401","F45.402","F45.403","F45.800x002","F45.801","F45.802","F45.803","F45.804","F45.805","F45.806","F45.807","F45.900","F45.901","F48.000","F48.001","F48.100","F48.100x002","F48.801","F48.802","F48.900","F48.901","F50.000","F50.100","F50.200","F50.300","F50.401","F50.501","F50.502","F50.800x002","F50.801","F50.900","F51.000","F51.100","F51.200","F51.200x002","F51.200x003","F51.300","F51.400","F51.500","F51.800","F51.900","F52.000","F52.001","F52.100","F52.100x002","F52.100x011","F52.200","F52.200x002","F52.201","F52.202","F52.300","F52.400","F52.500","F52.600","F52.700","F52.800","F52.900","F53.800","F54.x00","F59.x00","F59.x00x001","F60.000","F60.100","F60.200","F60.201","F60.300","F60.301","F60.302","F60.400","F60.500","F60.600","F60.700","F60.800x001","F60.800x002","F60.800x003","F60.801","F60.802","F60.900","F61.x00","F61.x00x011","F62.000","F62.100","F62.800","F62.900","F63.000","F63.100","F63.200","F63.300","F63.800","F63.800x001","F63.801","F63.900","F64.000x001","F64.000x002","F64.100","F64.200","F64.800","F64.900","F65.000","F65.100","F65.200","F65.300","F65.400","F65.500","F65.500x001","F65.500x002","F65.600","F65.800","F65.900","F66.000","F66.100","F66.200","F66.800","F66.900","F68.000","F68.000x001","F68.100","F68.100x001","F68.800","F69.x00","F70.000","F70.000x001","F70.100","F70.800","F70.900","F71.000","F71.000x001","F71.100","F71.800","F71.900","F72.000","F72.000x001","F72.100","F72.800","F72.900","F73.000","F73.000x001","F73.100","F73.800","F73.900","F78.000","F78.100","F78.800","F78.900","F79.000","F79.000x001","F79.100","F79.800","F79.900","F79.901","F80.000","F80.100","F80.200","F80.201","F80.202","F80.203","F80.204","F80.205","F80.300","F80.800","F80.900","F81.000","F81.100","F81.200","F81.201","F81.300","F81.800","F81.900","F82.x00","F83.x00","F84.000","F84.000x001","F84.001","F84.002","F84.100","F84.200","F84.300x001","F84.301","F84.400","F84.500","F84.800","F84.900","F84.900x001","F88.x00","F88.x01","F89.x00","F90.000","F90.000x001","F90.100","F90.800","F90.900","F91.000","F91.100","F91.100x002","F91.200","F91.300","F91.800","F91.900","F92.000","F92.800","F92.900","F93.000","F93.100","F93.200","F93.300","F93.800","F93.900","F94.000","F94.100","F94.200","F94.800","F94.900","F95.000","F95.100","F95.101","F95.200","F95.201","F95.800","F95.801","F95.900","F98.000","F98.001","F98.100","F98.101","F98.200","F98.300","F98.400","F98.500","F98.600","F98.800","F98.800x001","F98.801","F98.802","F98.803","F98.900","F99.x00","G47.000","G47.000x001","G47.000x002","G47.100","G47.200x002","G47.200x003","G47.400x002","G47.400x003","G47.800x001","G47.800x002","G47.801","G47.900","Q87.806","Q90.900","Q91.300","Q93.400","Q93.500","Q93.500x001","Q93.501","Q93.900","R41.801","R44.000","R44.300","R45.000","R45.100x001","R45.100x002","R45.200","R45.200x001","R45.200x003","R45.300x001","R45.300x002","R45.400x001","R45.400x002","R45.500","R45.600","R45.700x001","R45.700x002","R45.800x091","R45.801","R46.200x002","R46.400","R48.000x002","R48.001","R48.100","R48.200","R48.800x001","R48.800x002","R48.800x004","R48.800x005","R48.801","R68.803","Z03.200"};
            String[] dept_list={};
            if (!(true && mdc_zd.Contains(record.zdList[0]))){
                return "";
            }
            
            Base.groupMessages.putMessage(record.Index,"符合MDCT入组条件，匹配规则：主诊断匹配");
            String result;
    
            result=TB1.group(record);
            if (result.Length>0){
                return result;
            }
    
            if (false && record.ssList!=null && record.ssList.Length>0  && Base.intersect(Base.SS_VALID,record.ssList)){
                Base.groupMessages.putMessage(record.Index,"符合TQY入组条件，存在有效手术操作："+record.ssList.Intersect(Base.SS_VALID));
                return "TQY";
            }
    
            result=TR1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=TR2.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=TS1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=TS2.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=TT1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=TT2.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=TU1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=TV1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=TW1.group(record);
            if (result.Length>0){
                return result;
            }
    
            Base.groupMessages.putMessage(record.Index,"不符合MDCT的ADRG入组条件");
            return "";
        }
    }
}
