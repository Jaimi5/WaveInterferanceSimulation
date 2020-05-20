using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaveSimulatorV2 {
    public class Scenario {
        public float Distance { get; set; }
        public int NumberOfSlits { get; set; } = 1;
        public float SlitsWidth { get; set; }
        public int NumberOfLights { get; set; } = 1;
        public float Wavelenght { get; set; }
    }
}
