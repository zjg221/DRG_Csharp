namespace drg_group.beijing_2022
{
    public class MDCK_DRG 
    {
    
        public static bool KU19_group(MedicalRecord record){
            return true;
        }
    
        public static bool KE19_group(MedicalRecord record){
            return true;
        }
    
        public static bool KD29_group(MedicalRecord record){
            return true;
        }
    
        public static bool KD19_group(MedicalRecord record){
            return true;
        }
    
        public static bool KC19_group(MedicalRecord record){
            return true;
        }
    
        public static bool KB19_group(MedicalRecord record){
            return true;
        }
    
        public static bool KV11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool KZ11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool KJ11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool KS11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool KS13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool KT13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool KR13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool KS15_group(MedicalRecord record){
            return true;
        }
    
        public static bool KR15_group(MedicalRecord record){
            return true;
        }
    
        public static bool KJ15_group(MedicalRecord record){
            return true;
        }
    
        public static bool KT15_group(MedicalRecord record){
            return true;
        }
    
        public static bool KZ15_group(MedicalRecord record){
            return true;
        }
    
        public static bool KV15_group(MedicalRecord record){
            return true;
        }
    
    }
}
