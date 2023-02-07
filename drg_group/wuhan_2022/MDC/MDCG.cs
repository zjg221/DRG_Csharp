namespace drg_group.wuhan_2022
{
    public class MDCG
    {
        public static String group(MedicalRecord record){
            String[] mdc_zd={"Q43.404","D01.404","K61.001","K91.842","A56.302","K92.207","K62.821","K40.904","K65.004","K91.820","K60.302","K52.800x003","D18.000x042","K52.804","C78.500x004","K56.102","C18.900x001","K91.836","K62.818","I86.800x014","Q43.804","A00.100x001","D12.603","Q43.000","Q39.100x021","K65.001","K91.800x117","A18.306+K93.0*","K62.822","S36.803","S36.500x031","K40.402","D37.200x002","S36.402","D37.411","C18.700","C18.901","K57.302","K64.807","K27.400x004","Q43.200","A04.900","Q45.300x102","C17.800","K31.818","D37.501","D37.201","E10.400x350+G99.0*","K22.101","K59.900x002","K28.600","A02.004","K63.103","K91.200x002","K40.100x001","K66.101","K26.200x001","A04.800x001","B81.802","K22.000x001","K51.400","B66.500","K62.300x003","C18.800x002","K29.801","C19.x00","K63.210","D13.100","A09.900x006","D17.500x005","A05.300","Q43.803","T18.200","Q85.902","K43.200","K52.001","K63.305","Q43.805","K65.801","D01.000","K22.802","K92.801","K55.105","T18.300x003","K20.x00x003","B37.805","K65.012","K63.203","Q39.200x011","Q42.102","K55.101","E16.402","B81.800x001","K62.100","K62.809","K90.200","K63.000","K65.000","K51.902","A03.800x002","K63.306","K66.809","K38.801","K45.003","K62.401","K31.810","C78.402","K31.604","Q42.302","K91.800x111","K92.209","K31.820","R19.100x002","S11.202","A04.600","A04.401","K40.401","K91.201","Q42.101","K55.300x001","E16.401","D37.404","Q79.501","K62.000","D37.410","K22.805","Q43.800x015","K27.901","K43.301","K46.100","A09.904","Q42.000x301","Q79.400","K90.200x001","Q45.300x105","R93.300x004","K27.000","R85.100","K65.902","C21.101","K55.201","T18.300","K31.502","K29.600x006","K31.104","Q51.702","K55.013","R14.x00x002","K59.200","K27.400","E14.400x370+G99.0*","K40.305","K50.000x001","K63.804","K40.200x001","C78.804","K31.819","D17.500x008","Q39.600","K57.100x005","K43.605","C78.401","K40.300","K56.000","S36.601","A00.900x003","K55.103","K91.802","A02.000x005","C48.101","D18.000x043","K66.000x007","K66.802","K25.700","K41.300x003","Q79.301","D37.101","K31.805","D17.500x007","K59.002","K92.208","K60.000","K22.401","K31.608","K52.919","K91.819","K63.807","A04.500","D37.100x003","K52.103","I86.800x022","D17.500x001","K38.800x003","A18.312+K93.0*","K46.905","S36.404","K25.401","K64.808","K57.003","B77.000x001+K93.8*","C15.800x002","D36.901","D37.403","K52.901","K55.000x010","C78.403","K22.809","A08.402","I72.800x132","C16.800","Q40.204","A09.900x007","D12.800","K62.800x012","K91.800x702","K90.801","C16.401","K51.001","C16.000x003","K40.902","K91.813","K91.300","A08.400","C78.800x010","K31.800x802","K31.800x806","K91.800x102","Q42.002","A04.800x007","K28.000","D37.700x002","K59.303","K91.404","S36.403","B82.901","K43.003","C18.000","K55.003","K40.203","E10.400x330+G99.0*","Q40.002","Q43.201","A18.310","K29.100x001","K92.210","K25.501","Q85.900x002","Q40.200x010","Q42.200x905","A54.602","K40.302","K43.603","Q43.807","K62.200x001","K31.904","E84.102","Q40.201","K64.100","K65.011","A18.800x014+K23.0*","K43.303","A56.301","C48.102","K62.400x003","K25.901","K42.000x001","K59.100","K29.200","K29.600x007","K22.811","Q42.301","K64.806","K29.604","K57.107","K90.900x002","K22.500","K66.008","K59.800x002","K25.001","K30.x00","K91.835","K92.901","K55.000","K91.303","B37.800x091","Q43.806","R12.x00","K63.104","K62.800x009","S36.511","K51.203","K65.002","Q39.000x001","K22.203","Q42.800x003","K22.207","K65.017","A00.900x005","C78.400","D01.100","K26.900x001","S36.700","K57.105","K64.500","K57.305","K60.200","S36.411","S36.810","C45.700x005","A05.100","K65.804","K29.001","K25.903","K22.812","C78.500x008","K63.403","K58.801","S36.500","S36.901","C16.402","A08.101","K63.813","C78.801","K66.811","Q39.602","K63.105","K63.209","K57.000","B81.100","K51.301","K57.401","A54.807+K67.1*","K31.802","K35.300","K64.900","K56.700","K29.802","A05.400x001","K56.200x011","K65.806","K52.917","K62.400x004","K66.800","S36.800x022","D13.304","K62.812","A03.901","D01.200","D37.701","A04.400x004","E16.400x003","Q39.802","Q43.901","A18.300x014+K93.0*","K26.900x002","R85.600","K26.500x001","C16.903","K55.005","C18.200","K29.400","K63.814","R10.103","A06.100","B66.501","K65.901","K20.x00x006","K29.900","K50.000x005","A04.803","A04.801","I86.401","K43.000","D18.000x838","D13.101","K55.007","K59.200x002","C20.x00","K40.900x003","C15.100","K22.200","K64.809","K22.400","K91.837","R15.x00","K91.800x601","C26.900","A09.900x003","K57.801","B67.907","S36.405","Q41.902","D37.300x001","K66.002","K92.800x005","A03.900x009","K46.900x004","K63.216","C21.802","Q43.002","D37.400x001","K66.102","K63.108","K56.700x003","A09.903","C16.500","Q41.101","K90.300x001","Q41.202","S36.600x003","A04.300x001","K55.002","A07.200","K40.907","I74.800x011","Q43.800x009","K40.304","R10.400x002","K31.821","K27.900x002","D37.204","A09.005","K63.302","K26.100","C16.802","D48.117","K40.306","D37.405","R19.300","K59.800x005","C78.802","T18.501","Q43.001","Q89.300x001","K21.902","B76.901","D18.000x801","R19.500x003","K57.500","D13.902","K41.900x001","K52.203","I72.800x063","D37.100x001","Q43.601","K46.900x002","E14.400x340+G99.0*","K25.300x001","C18.600","K41.302","C77.207","A07.900x001","A06.002","K40.310","A09.004","S36.500x041","K62.700","K27.700x001","K56.400x001","K56.604","D12.200","K59.400x002","K91.100","K66.200","C16.301","C77.200x001","K26.501","K52.912","C26.800x001","K50.002","K20.x02","K91.833","A03.800x001","K55.009","A18.300x006+K67.3*","K62.800x005","K91.803","Q40.209","Q41.203","K63.815","K63.501","K29.700x002","A07.801","K91.800x501","K91.800x206","B37.806","K46.903","K40.312","K40.311","K56.701","B78.000","C15.200","K56.200","K63.207","K45.808","K31.905","E11.400x340+G99.0*","K52.300","Q40.200x004","K63.819","D12.100","A08.400x003","K57.101","K38.802","C45.705","R93.300x001","S36.400x091","K62.300","K22.100","A02.000x010","K91.812","K62.806","D12.001","K52.204","Q79.201","Q43.105","Q43.300x201","K65.904","K25.900x001","T80.200x001","K45.002","A18.812+K93.8*","D17.500x009","A20.800x004","K52.902","Q43.402","K31.702","K63.201","K22.813","K66.100","K65.905","Q45.300x103","A18.302+K93.0*","A54.600x001","K91.808","C15.802","K22.600x001","K25.100x001","C16.000x004","K63.900x003","K91.300x002","Q43.800x014","K66.001","B77.001+K93.8*","K55.900x004","K52.000x001","K35.200","K62.100x002","K51.200x001","Q39.501","A42.100","C18.500","K65.803","A03.000x001","Q42.200x902","D37.707","K63.806","K31.902","K63.200x008","K27.401","K66.004","Q39.801","K55.004","K26.701","C16.000","K57.108","K63.208","A06.200x001","K61.200","Q39.100","K38.100","K62.400x002","I85.000x001","Q41.104","K42.100x001","K60.403","K36.x02","C78.800x013","K57.900x001","K58.800","K92.203","K31.601","D12.500","K22.800x003","K37.x00","C45.703","K63.401","K40.900x005","Q42.200x904","R10.401","K51.401","K55.012","K65.006","D13.900x003","A02.000","C15.100x002","A07.300","R93.500x001","K38.900","K56.400x003","Q41.003","K62.001","D37.203","K25.902","I86.400x002","C78.803","K43.400","K90.002","Q40.208","K41.200x001","A04.902","D12.602","K64.401","K62.301","K55.102","K55.104","K40.900x004","I88.001","K43.500","K52.801","Q41.800","K59.801","K40.307","K22.808","B37.804","K27.900x005","K92.201","K63.803","K62.800x001","K31.102","A18.305+K93.0*","Q39.601","R85.800","K55.202","K62.801","I72.801","Q43.700","I78.802","K62.819","C15.900x003","R12.x00x002","K52.803","Q43.106","K65.805","A01.000x009","K51.900","K57.800","K28.900x002","K61.300","K45.100","K66.103","C16.600","A05.000","K36.x00x004","C26.800","A21.301","K65.009","R93.300x003","Q39.100x011","A04.800x006","D37.205","R19.100x001","C15.801","K22.700x001","K51.800x001","K91.829","S36.400","Q42.201","C78.504","K91.102","K43.602","C78.503","K90.404","K43.302","K41.301","D37.408","K63.805","Q41.002","K62.500x001","I72.807","C19.x01","K40.002","K22.102","K42.900","Q79.200","D48.403","K64.501","A04.800x003","K57.201","K90.100x001","A05.900","B49.x16","K51.002","K63.504","D37.702","Q40.900","K62.802","A18.807+K23.0*","Q89.302","C26.800x002","K31.812","R19.500x004","K44.000x001","D37.103","K62.902","K31.816","K92.800x002","Q43.900","K63.812","K52.911","K64.300","K62.803","K25.000x001","K63.900x005","R14.x00x006","C17.000","B82.900","K55.800x003","K66.808","K62.800x017","D13.302","D37.502","A03.200x001","D12.301","K56.600x001","A06.000x001","K46.101","K65.903","D37.301","E11.406+G99.0*","K44.901","Q43.300x901","A09.002","K50.800x001","K25.500x001","S36.500x091","K91.828","K92.206","A01.000x010","C16.800x002","R19.200x002","A21.300","I72.815","K52.202","K38.800x001","K45.802","Q40.207","K91.101","R85.400","A02.900x003","K62.804","K66.805","D17.700x022","K52.908","K50.801","Q39.300","A02.001","K56.203","R19.200","K41.100x001","D37.207","K62.602","E73.800","D12.901","K63.809","K59.900x001","K91.815","K91.100x001","C21.801","K57.301","R10.102","K45.806","S36.600","K31.807","K90.402","K60.100","K57.001","K27.503","K20.x00","C16.900x003","K64.805","K26.300","K51.901","K55.000x005","R19.400","K57.900","R19.500x002","D01.405","K40.101","B81.300","K44.900x001","K65.005","D00.200x002","K22.209","C45.102","K62.807","K63.810","K63.214","K28.600x001","K22.208","K31.607","A18.300x013+K93.0*","K35.201","A00.900","K21.901","Q43.301","D12.900x001","K91.900","K27.400x002","A01.000x008","D01.300x001","K22.804","D37.500x002","K55.800x004","D12.400","K63.801","K91.202","I86.812","Q43.800x019","C17.100","K57.104","K91.402","K64.000","S36.400x095","Q43.103","I89.800x006","D37.500x001","K56.602","K91.821","K31.814","C15.100x004","K65.016","C18.801","K45.805","K25.400x001","K55.006","A08.200","K40.400x001","K91.405","D01.401","S36.501","A09.007","D01.403","K63.816","D37.202","S36.801","D37.606","K43.001","K56.600x008","K92.800x001","A02.000x007","K65.807","K28.401","K51.003","K56.202","D12.601","A09.000x001","D18.100x001","K52.102","S39.905","K59.401","A22.200x001","K59.200x003","D12.700","K66.801","B77.900","B76.902","C16.801","K45.807","K56.501","K64.803","A51.100x001","K57.304","K29.603","K91.809","K55.100","A09.000x003","K56.001","D37.900x001","K31.600x004","K27.501","Q89.300","R10.400x004","C21.100","Q43.102","K57.103","A18.316+K93.0*","K52.910","K29.600","R14.x00x007","Q39.803","B49.x17","N88.803","A06.200","Q43.800x006","K27.500","K57.200x001","Q42.801","S36.413","D37.700x007","A08.500","A09.001","K62.816","A09.900x004","A03.903","A05.400","K29.605","T18.502","K29.800","K52.907","A07.100","K22.301","K66.006","B88.200x001","E10.400x340+G99.0*","K60.401","A22.200","K63.301","B81.800x002","K31.101","A00.000x001","K59.003","A18.309","S36.611","A18.317","Q43.801","D37.402","K65.003","K91.814","M32.112+K93.8*","K21.903","D13.200","K55.001","K64.200","D37.200x001","K91.800x007","K26.000","K38.000","Q42.800x002","E14.400x350+G99.0*","K21.001","K43.004","B81.801","K25.600","K45.000","C15.900","K63.001","Q43.802","S36.301","K90.401","D37.901","D37.709","E73.100","K64.400","D17.500x003","I77.400","K51.202","K63.500","K27.600","Q43.500","T18.801","C16.100","K40.900x006","K42.001","D13.301","K43.700","R58.x01","A04.802","R14.x00x003","K31.605","Q40.200x005","K27.900x001","K66.901","Q40.800","K40.905","Q43.602","Q44.500x008","D48.129","A18.300x015+K93.0*","C78.502","K40.903","Q42.802","R19.100","K55.100x006","K62.808","K57.102","K22.800x011","K52.104","K26.600","K90.400x003","K27.100x001","Q27.810","A08.300","A07.300x002","K66.800x008","D00.200x003","C18.802","Q85.913","A74.801+K67.0*","K57.300x006","K27.500x001","K45.800","Q39.800x905","I86.400","K64.402","K31.800x801","K63.901","K62.601","K55.010","K56.101","A09.003","K62.811","R19.501","D37.607","K29.602","K52.802","K91.834","D01.402","K65.008","K42.902","R93.303","K29.601","Q43.200x002","K38.800x004","K31.300","K22.000x002","K92.205","I72.800x142","K43.604","K59.101","K63.500x002","C15.000","A09.902","K50.102","D37.700x001","K56.600x005","S36.300","A09.000x006","K55.902","E14.400x330+G99.0*","K91.817","Q40.100","K31.808","K60.301","K50.103","K60.303","K29.700","K52.101","Q43.403","K31.603","K31.000","Q42.000x401","K27.502","K46.901","K63.206","K90.901","K22.806","I89.800x019","K63.818","K31.803","K63.500x084","K63.900x002","K50.800","C20.x01","C16.902","K55.900","K52.201","Q42.001","K63.802","K40.906","S36.811","K61.400","K40.201","K51.903","A54.601","Q42.202","D37.102","Q43.800x017","K40.314","K29.501","K31.804","R14.x00x001","C16.800x003","D18.000x825","K56.603","D00.200","K63.212","R10.402","A06.300","K50.001","Q42.000x501","K46.000","A18.311+K93.0*","C15.500","E73.000","C16.804","K92.200x001","C16.803","K51.000","D37.401","K91.801","Q43.104","Q39.900","K91.401","K90.100x003","D37.409","Q89.301","K63.902","R10.000x004","Q45.900","I89.005","K31.100","A04.000x002","A18.304+K93.0*","D17.700x027","K90.000","B81.400","D37.503","D37.206","K31.400","K63.200x003","A03.900x008","K55.106","C16.002","Q43.800x008","C16.001","A05.202","D18.000x041","S30.102","K40.900x001","D37.407","K92.800x003","Q43.812","K22.300","K63.211","K59.400","C15.800x003","C17.900x002","C18.900","A09.901","K58.100","A04.901","K43.100","S36.400x093","K38.200","K62.501","K46.001","D37.708","K57.400","Q41.903","K61.002","K55.100x001","K31.809","K62.810","K91.811","Q39.800x903","K56.601","Q43.003","K55.901","E85.417+K93.8*","K62.600x002","K63.107","T18.400","K25.000x002","K51.303","A18.308","C78.501","S36.310","S36.701","B46.200x001+K93.8*","A06.800x002","Q40.300","C16.200","K38.000x002","K55.008","K46.100x001","Q39.400","K62.200","S36.910","K22.803","D20.102","K92.800x007","K55.100x008","S36.802","C17.300","K35.301","K37.x00x002","A05.800","I85.900x001","K56.503","A06.001","K52.903","K31.815","D12.300","K52.904","K43.304","S36.414","D37.400x002","K29.701","K90.100x002","K55.200","K50.104","K66.807","S36.813","K90.000x001","K63.303","K56.300","B76.000","K29.500","K40.301","A56.300x001","K91.800x103","A18.314+K67.3*","K63.817","A04.700","C77.106","A03.900x007","K31.500","K31.800x808","K31.813","K45.801","K31.609","K56.201","Q85.900x036","K25.200x001","K62.813","C18.100","K50.900","T18.301","A18.307+K93.0*","K42.901","Q79.300","K46.002","S36.900","S39.909","K63.200","K40.204","A00.900x002","K41.000","K46.900x012","I88.105","K63.100x001","K63.502","K56.401","K26.400x003","C77.201","K51.500","C16.900","K31.600x005","K41.300x002","I86.400x004","Q43.100","Q43.811","C26.901","A52.710+K67.2*","D18.000x040","E11.400x350+G99.0*","K36.x00x003","D01.900","A60.102+K93.8*","K66.812","K22.801","A04.800x010","K29.606","Q42.000x101","K55.300","K36.x01","S36.812","K40.900x002","R85.300","C78.809","K91.804","Q42.803","K63.307","K63.202","A03.100x001","K92.800x004","A03.900","K31.811","A07.800x002","K22.202","K91.810","K22.900x001","C16.400","D18.000x046","K60.402","A04.700x002","K63.205","K59.301","K91.831","Q41.103","K46.900","K91.406","K62.901","K62.820","K25.400x002","A04.702","K45.804","A08.100x001","C26.000","K91.839","K91.103","C18.400","E11.400x330+G99.0*","K31.806","D13.303","K64.901","I72.800x131","K35.800x001","K20.x03","K63.304","A04.100x001","Q45.801","K62.903","K91.302","K64.804","K92.204","K55.100x005","K91.800x116","K62.800x010","D17.700x017","K31.103","A00.900x004","A02.000x009","K63.215","K29.000","D18.000x859","K57.202","K22.103","K46.900x003","A03.902","K27.200","K44.000x002","E10.400x370+G99.0*","D37.200x004","K40.000x001","K51.302","Q43.800x012","D48.402","D37.200x003","C15.800x001","K63.900x001","K43.002","B05.400","K90.802+M14.8*","K51.201","T98.300x001","A02.003","K62.817","K61.100","K57.800x001","K62.805","A08.000","Q42.903","Q41.001","A18.300x009+K93.0*","K31.501","K64.801","K55.011","K52.918","T18.100","K31.200","E73.900","K55.000x011","D12.600","K62.815","B49.x00x002","A03.904","K28.900x001","K29.101","C20.x00x003","Q40.206","Q43.800x018","Q39.800x904","K61.000","Q42.000x201","C15.100x003","A05.200x002","R10.301","K50.101","K61.101","Q43.200x003","A04.600x001","K64.810","Q40.203","K91.800x106","Q41.901","T18.900","K31.801","Q40.000","K31.703","K43.601","A06.100x002","Q43.808","A08.401","K63.308","I89.006","R19.800x001","K40.303","K65.010","K26.200x002","K66.803","Q40.003","K91.816","K22.400x003","K92.100x001","Q42.200x903","K41.400x001","K66.810","C45.101","D37.406","C78.500x006","K27.500x002","K27.600x001","D18.000x045","C18.803","K40.308","K64.811","C78.603","K31.903","C15.400","K40.313","K52.000","K60.300","K28.901","I89.803","S36.412","K27.400x001","K22.815","K65.900","K60.400","R19.000x005","R85.000","K66.800x009","A03.900x002","K38.300","K31.602","B87.800x002+K93.8*","T18.500x004","A02.002","D37.100x002","K40.315","D13.000","A06.000","C18.001","C78.800x014","K26.401","K92.202","K66.201","K59.302","K92.000","K27.500x005","K55.801","K63.400","D12.000","K56.100","K65.800x001","K66.003","K28.500x001","R19.600","I85.901","R10.000","K66.005","Q42.901","C18.300","K91.000","R85.500","K92.200x005","K55.200x013","B49.x12","K22.601","K29.608","K22.201","A03.300x001","K31.100x002","Q43.810","K62.201","K65.000x014","Q42.902","C26.800x003","A03.900x005","K31.901","K22.204","A18.303+K93.0*","J11.800x002","A05.000x001","K51.300","K52.914","Q85.906","K56.500x003","S36.500x021","K52.200x004","K62.814","A05.200","K20.x01","K28.400x002","K60.400x003","K91.805","Q41.102","R85.200","K26.001","Q40.205","D37.710","Q43.809","C21.800","A04.200x001","Q79.500","K66.007","A07.000","K63.101","Q41.201","K91.800x602","C15.800x004","K57.303","K63.102","K31.701","K91.408","Q39.800x201","A02.000x006","K25.000","S36.500x093","K22.206","Q40.202","E16.400","S36.500x011","K22.901","D48.121","K40.202","A18.318","K91.818","K91.830","K62.202","K65.802","Q43.101","C17.200","K27.300","K65.906","I72.816","K62.800x021","K50.000","A18.300x016","K28.200","Q43.004","D01.301","K91.832","A09.006","K29.300","K66.806","K63.213","K40.001","S36.500x092","K64.802","K63.503","K31.606","I86.400x001","K20.x00x001","K59.000","D12.000x002","K57.002","K65.800x002","K46.000x002","Q42.200x901","K60.500","K28.500","C78.505","K56.200x003","R10.101","K40.102","K30.x00x001","Q43.401","R85.700","S36.814","D12.302","K91.301","K57.106","C21.200","K40.309","C21.000","K91.824","C77.208","K40.901","K92.800x011","A18.315+K93.0*","S36.401","A08.301","K63.402","I88.000x003","C78.800x005","D17.500x004","C17.801","K90.001","C15.300","K52.909","I72.802","K22.807","K91.800x412","K46.902","K63.204","K44.100x001","K22.814","K22.205","K66.000","K90.406","I89.801","K28.300x001","Q45.300x104","K21.900x003","K27.902","K28.100","A05.300x001","D00.100","B82.000","B57.300","K91.305","C17.900","K62.402","K28.700"};
            String[] dept_list={};
            if (!(true && mdc_zd.Contains(record.zdList[0]))){
                return "";
            }
            
            Base.groupMessages.putMessage(record.Index,"符合MDCG入组条件，匹配规则：主诊断匹配");
            String result;
    
            result=GB1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=GB2.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=GC1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=GC2.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=GD1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=GD2.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=GE1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=GE2.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=GF1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=GF2.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=GG1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=GJ1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=GK1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=GK2.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=GK3.group(record);
            if (result.Length>0){
                return result;
            }
    
            if (false && record.ssList!=null && record.ssList.Length>0  && Base.intersect(Base.SS_VALID,record.ssList)){
                Base.groupMessages.putMessage(record.Index,"符合GQY入组条件，存在有效手术操作："+record.ssList.Intersect(Base.SS_VALID));
                return "GQY";
            }
    
            result=GR1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=GS1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=GT1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=GU1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=GU2.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=GV1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=GW1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=GZ1.group(record);
            if (result.Length>0){
                return result;
            }
    
            Base.groupMessages.putMessage(record.Index,"不符合MDCG的ADRG入组条件");
            return "";
        }
    }
}
