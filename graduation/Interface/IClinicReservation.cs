using graduation.Model;

namespace graduation.Interface
{
    public interface IClinicReservation
    {
        public List<ClinicReservation> GetClinicReservations();
        public ClinicReservation GetClinicReservationById(int id);
        public void AddClinicReservation(ClinicReservation clinicReservation);
        public void UpdateClinicReservation(ClinicReservation clinicReservation);
        public ClinicReservation DeleteClinicReservation(int id);
    }
}
