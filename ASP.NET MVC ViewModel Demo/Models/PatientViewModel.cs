using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class PatientViewModel
    {
        public List<Patient> patientList;

        public Patient currentPatient;

        public Problem currentProblem;
    }
}
