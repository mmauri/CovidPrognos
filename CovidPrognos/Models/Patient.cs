namespace CovidPrognos.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public System.DateTime AdmissionDate { get; set; }
        public int? Age { get; set; }
        public bool? IsMale { get; set; }
        public bool? SaO2Below90PercAtAdmission { get; set; }
        public bool? CRPGreater112mglAtAdmission { get; set; } //Proteine C reactive level mg/L
        public int Neutrophils { get; set; }
        public int Platelets { get; set; }
        public int NPRScore { get; set; } 
    }
    //public class PatientData
    //{
    //    public string PatientId { get; set; }
    //    public int DayFromAdmission { get; set; }
        
        
        
    //}
}
