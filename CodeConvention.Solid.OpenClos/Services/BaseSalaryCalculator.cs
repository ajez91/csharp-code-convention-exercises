﻿using CodeConvention.Solid.OpenClos.Models;

namespace CodeConvention.Solid.OpenClos.Services
{
    // 1) To create a code that abides by the Open Closed Principle, 
    //we are going to create an abstract class first:
    public abstract class BaseSalaryCalculator
    {
        protected DeveloperReport DeveloperReport { get; private set; }

        public BaseSalaryCalculator(DeveloperReport developerReport)
        {
            DeveloperReport = developerReport;
        }

        public abstract double CalculateSalary();
    }
}
