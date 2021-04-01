namespace CovidPrognos.Models
{
    public class Patient
    {
        public string PatientId { get; set; }
        public System.DateTime AdmissionDate { get; set; }
        public double Age { get; set; }
        public bool IsMale { get; set; }
        public bool SaO2Below90PercAtAdmission { get; set; }
        public bool CRPGreater112mglAtAdmission { get; set; } //Proteine C reactive level mg/L
        public double Neutrophils { get; set; }
        public double Platelets { get; set; }
        public double NPRScore { get; set; }
    }
    public class PatientData
    {
        public string PatientId { get; set; }
        public int DayFromAdmission { get; set; }
        
        
        
    }
}
