namespace DevJobs.API.Entities
{
    public class JobApplication
    {
        public JobApplication(string apllicantName, string applicantEmail, string idJobVacancy)
        {
            this.ApllicantName = apllicantName;
            this.ApplicantEmail = applicantEmail;
            this.IdJobVacancy = idJobVacancy;

        }
        public int Id { get; private set; }
        public string ApllicantName { get; set; }
        public string ApplicantEmail { get; set; }
        public string IdJobVacancy { get; set; }
    }
}