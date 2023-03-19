using Secao9_Enum.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secao9_Enum.Entities
{
    public class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department department { get; set; }
        public List<HourContrat> Contracts { get; set; }

        public Worker()
        {
            Contracts = new List<HourContrat>();
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            this.department = department;
        }

        public void AddContract(HourContrat contrat)
        {
            Contracts.Add(contrat);
        }

        public void RemoveContract(HourContrat contrat)
        {
            Contracts.Remove(contrat);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;

            foreach(HourContrat contract in Contracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
