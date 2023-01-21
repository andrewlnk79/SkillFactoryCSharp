
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace individualLesson1
{
    internal class Laptop
    {
        private String model;
        private int ram;
        private int hdd;
        private String os;
        private int displaySise;

        public Laptop(string model, int ram, int hdd, string os, int displaySise)
        {
            this.model = model;
            this.ram = ram;
            this.hdd = hdd;
            this.os = os;
            this.displaySise = displaySise;

        }

        public String getModel() { return model; }

        public int getRam() { return ram; }

        public int getHdd() { return hdd; }

        public String getOs() { return os; }

        public int getDisplaySise() { return displaySise; }











        public override string? ToString()
        {
            return "Laptop: " + model;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

}
