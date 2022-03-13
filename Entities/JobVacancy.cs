namespace DevJobs.API.Entities
{
    public class JobVacancy
    {
        public JobVacancy(string company, string description, string title, bool isRemote, string salaryRange, DateTime createdAt)
        {
            this.Company = company;
            this.Description = description;
            this.Title = title;
            this.IsRemote = isRemote;
            this.SalaryRange = salaryRange;
            this.CreatedAt = DateTime.UtcNow;
            this.Applications = new List<JobApplication>(); 
        }
        public int Id { get; private set; }
        public string Description { get; private set; }
        public string Title { get; private set; }
        public string Company { get; private set; }
        public bool IsRemote { get; private set; }
        public string SalaryRange { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public List<JobApplication> Applications { get; private set; }

    public void Update (string title, string description) {
      Title = title;
      Description = description; 
    }
    }
}