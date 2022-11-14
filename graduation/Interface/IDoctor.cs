using graduation.Model;

namespace graduation.Interface
{
    public interface IDoctor
    {
        public List<Doctor> GetDoctors();
        public Doctor GetDoctorById(int id);
        public void AddDoctor(Doctor doctor);
        public void UpdateDoctor(Doctor doctor);
        public Doctor DeleteDoctor(int id);

        public Doctor SearchForDoctor(string query);
    }
}
