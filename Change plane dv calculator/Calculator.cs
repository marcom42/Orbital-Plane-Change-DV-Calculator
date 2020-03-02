using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_plane_dv_calculator
{
    class Calculator {
        // Values represent Radius, Mass 
        private readonly Dictionary<string, double[]> constants = new Dictionary<string, double[]>();
        // Gravitational constant
        private const double GRAV_CONST = 6.67e-11;
        public string Body { get; set; }

        public Calculator() {
            constants.Add("Mercury", new double[] { 2.44E+06, 3.30188E+23 } );
            constants.Add("Venus", new double[] { 6.05E+06, 4.86855E+24 });
            constants.Add("Earth", new double[] { 6.37E+06, 5.9737E+24 });
            constants.Add("Moon", new double[] { 1.74E+06, 7.35E+22 });
            constants.Add("Mars", new double[] { 3.39E+06, 6.41854E+23 });
            constants.Add("Jupiter", new double[] { 6.99E+07, 1.89861E+27 });
            constants.Add("Saturn", new double[] { 5.82E+07, 5.68463E+26 });
            constants.Add("Uranus", new double[] { 2.54E+07, 8.68321E+25 });
            constants.Add("Neptune", new double[] { 2.46E+07, 1.02E+26 });

            Body = "Earth";
        }
        
        /// <summary>
        /// Gets one of the two constant of a body (radius or mass)
        /// </summary>
        /// <param name="constantType">Assumes the value of 0 for radius and 1 for mass</param>
        /// <returns>The requested constant</returns>
        private double GetConstant(int constantType) {
            double[] constant;
            constants.TryGetValue(Body, out constant);
            return constant[constantType];
        }

        /// <summary>
        /// Converts to radians
        /// </summary>
        /// <param name="degrees">The value in degrees to convert</param>
        /// <returns>The result of the conversion</returns>
        private double ConvertToRadians(double degrees) {
            return (Math.PI / 180) * degrees;
        }

        /// <summary>
        /// Calculates velocity at periapsis in m/s
        /// </summary>
        /// <param name="apa">Apoapsis</param>
        /// <param name="pea">Periapsis</param>
        /// <returns>Velocity</returns>
        public double CalcPeAVelocity (double apa, double pea) {
            double peaVel = Math.Sqrt(2 * GRAV_CONST * GetConstant(1) * (GetConstant(0) + apa * 1000) / ((GetConstant(0) + pea * 1000) * ((GetConstant(0) + pea * 1000) + (GetConstant(0) + apa * 1000))));

            return peaVel;
        }
        
        /// <summary>
        /// Calculates velocity at apoapsis in m/s
        /// </summary>
        /// <param name="apa">Apoapsis</param>
        /// <param name="pea">Periapsis</param>
        /// <returns>Velocity</returns>
        public double CalcApAVelocity (double apa, double pea) {
            //= sqrt(2 * ConstantGrav * ConstantSelBodyMass * (ConstantSelBodyRadius  +PeA * 1000) / ((ConstantSelBodyRadius +ApA * 1000)*((ConstantSelBodyRadius +PeA * 1000)+(ConstantSelBodyRadius + ApA * 1000))))

            double apaVel = Math.Sqrt(2 * GRAV_CONST * GetConstant(1) * (GetConstant(0) + pea * 1000) / ((GetConstant(0) + apa * 1000) * ((GetConstant(0) + pea * 1000) + (GetConstant(0) + apa * 1000))));

            return apaVel;
        }

        /// <summary>
        /// Calculates the delta-v cost to align the plane at periapsis
        /// </summary>
        /// <param name="rInc">Relative inclination</param>
        /// <param name="peaVel">Velocity at periapsis</param>
        /// <returns>Delta-v cost at periapsis</returns>
        public double CalcDvPeA (double rInc, double peaVel) {
            //sin(radians($B$2/2))*2*B5

            double dvPeA = Math.Sin(ConvertToRadians(rInc / 2)) * 2 * peaVel;

            return dvPeA;
        }

        /// <summary>
        /// Calculates the delta-v cost to align the plane at apoapsis
        /// </summary>
        /// <param name="rInc">Relative inclination</param>
        /// <param name="apaVel">Velocity at apoapsis</param>
        /// <returns>Delta-v cost at apoapsis</returns>
        public double CalcDvApA (double rInc, double apaVel) {
            //sin(radians($B$2 / 2)) * 2 * B6
            double dvApA = Math.Sin(ConvertToRadians(rInc / 2)) * 2 * apaVel;
            return dvApA;
        }
        
        /// <summary>
        /// Gets the standard gravitational parameter of the body
        /// </summary>
        /// <returns>Standard gravitational parameter</returns>
        public double GetStdGravitationalParam() {
            return GetConstant(1) * GRAV_CONST;
        }
    }
}
