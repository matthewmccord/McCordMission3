using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace McCordMission3.Models
{
    public class GradeCalcModel
    {
        [Range(0,100, ErrorMessage= "Value for Assignments must be between {1} and {2}.")]
        public double assign { get; set; }
        [Range(0, 100, ErrorMessage = "Value for Quizzes must be between {1} and {2}.")]
        public double quiz { get; set; }
        [Range(0, 100, ErrorMessage = "Value for Group Projects must be between {1} and {2}.")]
        public double gp { get; set; }
        [Range(0, 100, ErrorMessage = "Value for Exams must be between {1} and {2}.")]
        public double ex { get; set; }
        [Range(0, 100, ErrorMessage = "Value for Intex must be between {1} and {2}.")]
        public double inte { get; set; }

    }
}
