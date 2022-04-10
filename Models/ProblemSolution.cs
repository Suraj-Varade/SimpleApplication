using System.ComponentModel.DataAnnotations;

namespace OnlineCodePlatform.Models
{
    public class ProblemSolution
    {
        [Key]
        public int ProblemSolutionId { get; set; }
        public string Solution { get; set; }

        public ProblemStatement ProblemStatement { get; set; }
    }
}