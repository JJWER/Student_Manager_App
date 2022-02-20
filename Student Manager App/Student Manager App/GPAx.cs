using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Manager_App
{
    internal class GPAx
    {
        private double sum = 0;
        private int n = 0;
        private double max = 0;
        private double min = 0;
        private string name = string.Empty;
        private string alldata = string.Empty;

        public void addGPA(double gpa, string name)
        {
            this.sum += gpa;
            this.n++;
            this.alldata += name + " " + gpa + "\r\n";

            if (this.max < gpa)
            {
                this.max = gpa;
                this.name = name;
            }

            if (this.min <= this.max)
            {
                this.min = gpa;
                this.name = name;
            }
        }
        public double getGPAx()
        {
            double result = this.sum / this.n;
            return result;

        }
        public double getMax()
        {
            return this.max;
        }
        public double getMin()
        {
            return this.min;
        }

        public string getMaxName()
        {
            return name;
        }
        public string getMinname()
        {
            return name;
        }
        public string getAllData()
        {
            return alldata;
        }
    }
}
