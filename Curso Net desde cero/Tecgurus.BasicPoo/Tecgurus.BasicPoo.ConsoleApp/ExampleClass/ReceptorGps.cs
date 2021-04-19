using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tecgurus.BasicPoo.ConsoleApp.ExampleClass
{
    public class ReceptorGps
    {

        public ReceptorGps(string idReceptor)
        {
            // ASIGNASION DE VALOR A CAMPO DE SOLO LECTURA
            _id = idReceptor;
        }

        private double _lat;
        private double _lon;

        private readonly string _id;

        public string Id
        {
            get
            {
                return _id.ToUpper();
            }

        }
        public double Latitude
        {
            get { return Math.Round(_lat, 2); }
            set
            {
                if (value >= -90 && value <= 90)
                {
                    _lat = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        public double Longitude
        {
            get { return Math.Round(_lon, 2); }
            set
            {
                if (value >= -180 && value <= 180)
                {
                    _lon = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public void DescribePositio()
        {
            _lat = _lat - 1;
            Console.WriteLine($"LAT:{_lat } LNG {_lon}");
        }


        public void DescribePositioTwo()
        {
            Console.WriteLine($"LAT:{Latitude } LNG {Longitude}");

        }


        public Tuple<double, double> GetCurrentPosition()
        {
            var position = new Tuple<double, double>(_lat, _lon);

            return position;

        }

    }





}
