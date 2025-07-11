public class Resume
{
    public string _name;
    public List<Job> _listOfJobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"\nName:{_name}\nJobs:");
        foreach (Job job in _listOfJobs)
        {
            job.DisplayShowDetails();
        }
    }
}