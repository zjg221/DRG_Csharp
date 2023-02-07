namespace drg_group.wuhan_2022
{
    public class MDCQ
    {
        public static String group(MedicalRecord record){
            String[] mdc_zd={"D64.300","D58.000","D74.801","D58.900","R76.801","D73.400","D57.001","D60.100x001","E32.800x001","D67.x01","D69.300","D53.804","D73.800x011","D83.200","D51.200","D68.200x001","D68.001","D72.001","D83.800","D59.300x001","L04.100","D55.203","D61.900","R23.301","D58.000x001","D73.503","R71.x00","D59.602","D65.x00x003","D73.800x002","D68.402","D69.203","D81.801","D72.806","D89.300","I89.800x011","D68.504","D73.001","E32.001","D64.903","D74.900","R59.011","D75.107","D57.800","D61.001","D56.102","D57.301","D73.805","D76.100x004","I74.800x010","D59.603","D59.800","D51.102","I89.010","D64.803","D69.200x006","B55.200x001","D53.200","D69.000x008","D80.100","I89.802","L04.002","D70.x06","A18.209","D58.000x003","D57.000x001","D81.901","D69.502","S36.000x021","D46.000","D68.201","D61.006","D70.x02","D69.500","Q27.807","D55.000","I88.108","D68.000x002","D56.400","D59.104","D75.111","E32.802","D68.902","D68.101","C37.x00","L03.901","D68.505","D46.100","D59.200","D55.100x001","D81.600","D61.202","D52.000x003","D69.000x007","D53.901","D53.000","D51.002","D60.000x001","D70.x00x003","D59.500","D80.100x003","D59.201","D69.401","D71.x00","D73.200","D80.500","D46.100x002","D53.803","D50.102","D37.700x005","D15.000","D52.800","D61.201","D69.102","E32.100","Q89.004","Q85.907","M32.111+D77*","D46.400","D80.000","I88.900x006","E80.200x007","D46.000x002","D68.208","D51.001","D76.303","D73.504","D56.301","D76.304","D36.000","D21.900x015","D61.102","C79.800x829","D58.100","D61.000","D69.301","D46.200","D75.805","D68.200x009","D69.503","D82.200","D83.900","E32.002","D68.300x004","D73.807","D68.200x006","D59.600x004","D84.900x003","D57.100","D56.300","D46.201x001","D64.401","D65.x04","D68.801","D18.100x023","D69.000x011","R59.004","D55.204","D69.100x004","D72.105","D81.400","D80.102","A18.207","D56.800","D84.000","D55.100x003","D64.000","D51.302+G32.0*","D56.900","D61.004","D59.501","D69.200x005","D51.101","D68.300","D70.x00x010","S36.011","D61.909","D75.801","D66.x00x001","D52.000x001","D82.800x001","D73.800x010","N18.900x012+D63.8*","D69.000","D80.800","D61.902","D59.403","D56.901","D53.801","E32.900","D56.100","D51.300","D84.800","A18.210","D81.000","D89.800x003","D75.802","S36.000x031","D59.902","D89.301","D61.000x006","D18.100x017","D89.002","D84.103","D72.102","D18.100x019","D47.700x010","R93.300x002","D75.800","C26.100","D59.400x001","D73.002","D89.000","E85.400x004","D76.301","D76.102","D69.900","D75.105","D57.200","D89.801","D82.900","D75.103","R59.002","D72.800x003","A18.813+D77*","D68.900x006","R59.003","D69.406","D84.900x002","R59.013","D68.605","D69.008","D56.101","I89.806","D81.200","D61.801","I88.800x001","R59.000x013","L04.301","D69.405","D50.800x001","I72.812","R16.100x001","D80.101","D57.302","D70.x00x004","D73.505","D61.101","D61.905","R59.010","D68.203","D84.800x001","D89.100x001","D75.109","D69.000x010","D70.x00","D68.500","R59.005","D51.003+G32.0*","D75.806","R59.012","D66.x03+M36.2*","D59.900","D69.100x003","D69.004","D68.200x008","D57.100x003","C78.805","D61.904","D69.801","D72.101","D76.302","I72.811","D72.807","D64.900x006","D56.100x001","D73.804","D73.500","D58.201","D75.809","D80.601","D58.203","D68.601","D75.110","D59.000","D61.900x001","D73.803","D75.102","D55.101","D57.300","D64.001","D18.000x044","D74.800x001","D55.201","D69.800x002","D73.900","E32.800x005","D84.100x005","D68.903","S36.000","D59.100x005","D72.803","D69.400x001","D69.003","D13.901","A18.200x010","D18.100x003","D50.901","D53.802","D65.x00x005","D80.002","D68.302","D75.000","D69.103","D69.400x002","D56.000","D57.200x001","D74.000x003","D18.100x024","D64.904","D64.801","D59.500x001","D53.001","D65.x00x001","D59.601","D73.501","D75.901","R59.014","L04.202","D61.005","D68.901","R59.100","D89.100","D84.900","D68.502","D82.300","D58.200x002","D73.502","D48.906+D63.0*","D74.800x003","D51.000","L04.901","D56.100x003","D68.301","D68.303","D47.700x009","D82.100","D89.800x002","D64.300x002","D69.201","D70.x07","T86.001","D80.901","D80.300","D51.800","D84.101","D68.602","R71.x00x004","L04.200","D55.001","D76.200","D68.207","D61.300","D89.001","D72.900","D70.x05","D69.200x008","D71.x01","D46.000x003","D82.800","L04.900x005","D73.901","D74.000x004","D68.206","D61.907","D58.205","D58.800x001","D89.000x004","I74.800x012","D82.300x002","D60.900x001","D69.400x006","D72.809","D68.000","D61.802","D76.300","I88.900x005","D89.100x006","D68.100x001","D55.900","D57.202","D82.000","D62.x00","D69.002","D72.000","D57.204","D89.100x003","D69.200x007","D76.100x005","D81.802","D59.404","D69.504","D65.x02","D59.903","I74.800x004","D75.902","D59.604","D75.000x002","D69.501","D70.x00x001","D64.901","R59.000x012","D81.803","D59.105","D58.101","D69.200","D68.300x003","T86.000x004","D80.900x002","L03.102","D70.x00x011","D81.700","D70.x00x005","R71.x00x005","D64.200","D61.903","D58.003","R59.100x002","D46.001","D68.603","D69.000x013","E83.101","I88.100","D83.000","D68.000x001","D89.900","D69.500x003","D75.100","D68.300x001","D89.100x002","D73.100","D66.x01","D18.100x002","D80.001","D68.200x005","D65.x03","D68.204","D72.808","D68.900x003","D73.801","I88.900x003","D75.106","D82.400","D58.206","D46.600","D58.200x004","D84.102","D72.805","D64.900x007","R59.006","D68.900x005","D81.900x001","D58.100x004","D69.802","D47.700x011","D50.801","D61.200x002","D86.101","D51.301","D89.000x003","D76.101","D68.400x003","D81.601","D55.800","D75.800x003","D59.101","D72.800","I86.810","A51.400x010","I74.805","D57.201","D58.100x002","A18.200x006","D18.107","D61.003","D73.800x007","D68.401","I77.008","D46.203","D69.005+N08.2*","L04.201","D80.200x001","D59.901","D18.100x018","D68.205","D80.700","D65.x01","L04.900x002","D68.400","D59.401","R59.007","D50.100","T86.000","D75.101","D53.002","D74.000x002","D58.901","D69.100x002","D69.600","I82.800x002","D73.000","D18.104","D67.x00x003","D68.200x007","D68.400x002","D81.800","D73.802","D51.100","D68.501","D17.700x031","D69.100x001","D69.302","D83.100","D53.900","D58.800","A18.208","D52.100","D69.400","D59.103","D76.100x003","R59.000x010","D81.100","D58.801","L04.300","D59.100x002","D59.402","D71.x00x004","D47.700x008","D66.x02","D68.604","D71.x00x003","E32.000","D69.200x003","D68.600x003","D70.x03","E32.000x003","D69.010","D72.804","R59.000x009","D37.703","D73.300","D51.200x001","R59.008","D72.801","D58.001","D68.503","D46.100x012","S36.001","D60.800","D70.x04","D75.803","D73.808","D68.202","R94.800x001","S36.002","D69.202","D84.100","D61.007","D52.900x001","D61.901","D69.400x003","D86.100","D50.001","D69.006","D89.200","D71.x00x002","E80.200x008","R23.300x003","D69.800","D58.204","A18.206","D56.200","R72.x00x002","D59.102","D64.900","D80.900","D58.200x006","D81.000x002","D70.x00x008","D59.400x002","D75.804","D55.300","D61.002","D58.202","S36.000x081","D55.200","D69.403","D69.001","D80.800x001","D38.401","D59.301","D69.101","D69.009","D61.906","D64.400x001","D74.000","L04.900x007","D72.802","D72.104","D80.400","D46.500","D82.301","D55.202","D89.100x005","D75.104","I88.901","D18.100x006","D64.802","D84.100x002","D61.800x002","D50.000","D58.002","D59.600","D50.900","D57.203","D37.704","D50.101","D70.x01","D51.900","D64.800x002","D81.900","D61.908","D69.007","D75.108","E32.801","A18.212","D69.407","L04.900","D64.902","L04.902","D75.807","D89.100x004","E32.800x004","D71.x00x005","D68.200x010","D38.400x001","D89.800","T86.000x003","A18.211","D53.100","D64.100","D72.100","D52.001","D18.103","D89.100x007","R23.300"};
            String[] dept_list={};
            if (!(true && mdc_zd.Contains(record.zdList[0]))){
                return "";
            }
            
            Base.groupMessages.putMessage(record.Index,"符合MDCQ入组条件，匹配规则：主诊断匹配");
            String result;
    
            result=QB1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=QC1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=QD1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=QJ1.group(record);
            if (result.Length>0){
                return result;
            }
    
            if (false && record.ssList!=null && record.ssList.Length>0  && Base.intersect(Base.SS_VALID,record.ssList)){
                Base.groupMessages.putMessage(record.Index,"符合QQY入组条件，存在有效手术操作："+record.ssList.Intersect(Base.SS_VALID));
                return "QQY";
            }
    
            result=QR1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=QS1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=QS2.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=QS3.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=QS4.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=QT1.group(record);
            if (result.Length>0){
                return result;
            }
    
            Base.groupMessages.putMessage(record.Index,"不符合MDCQ的ADRG入组条件");
            return "";
        }
    }
}
