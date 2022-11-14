using graduation.Model;

namespace graduation.Interface
{
    public interface IClinic
    {
        public List<Clinic> GetClinics();
        public Clinic GetClinicById(int id);
        public void AddClinic(Clinic clinic);
        public void UpdateClinic(Clinic clinic);
        public Clinic DeleteClinic(int id);
        public Clinic SearchForClinic(string query);
    }
}
