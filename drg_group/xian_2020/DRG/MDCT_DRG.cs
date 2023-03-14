namespace drg_group.xian_2020
{
    public class MDCT_DRG 
    {
    
        public static bool TB19_group(MedicalRecord record){
            return true;
        }
    
        public static bool TR29_group(MedicalRecord record){
            return true;
        }
    
        public static bool TS19_group(MedicalRecord record){
            return true;
        }
    
        public static bool TS29_group(MedicalRecord record){
            return true;
        }
    
        public static bool TU19_group(MedicalRecord record){
            return true;
        }
    
        public static bool TV19_group(MedicalRecord record){
            return true;
        }
    
        public static bool TW19_group(MedicalRecord record){
            return true;
        }
    
        public static bool TR11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool TT11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool TT21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool TR13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool TT13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool TT23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool TR15_group(MedicalRecord record){
            return true;
        }
    
        public static bool TT15_group(MedicalRecord record){
            return true;
        }
    
        public static bool TT25_group(MedicalRecord record){
            return true;
        }
    
    }
}
