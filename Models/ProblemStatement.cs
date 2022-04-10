using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCodePlatform.Models
{
    public class ProblemStatement
    {
        [Key]
        public int ProblemStatementId { get; set; }

        [Required]
        public string ProblemName { get; set; }

        [Required]
        public string Description { get; set; }

        public int ProblemSolutionId { get; set; }
        
        public ProblemSolution ProblemSolution { get; set; }
    }
}
