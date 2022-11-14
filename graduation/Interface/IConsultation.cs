using graduation.Model;

namespace graduation.Interface
{
    public interface IConsultation
    {
        public List<Consultation> GetConsultations();
        public Consultation GetConsultationById(int id);
        public void AddConsultation(Consultation consultation);
        public void UpdateConsultation(Consultation consultation);
        public Consultation DeleteConsultation(int id);
    }
}
