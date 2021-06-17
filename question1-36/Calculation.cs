using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question1_36
{
    class Calculation
    {
        int [,] Student = new int [50 , 4];
        public int [,] InsertMarks(int stuNo , int dm ,int rad, int os)
        {
            for (int i = 0; i < Student.GetLength(0); i++)
            {
                for (int j = 0; j < Student.GetLength(1); j++)
                {
                    Student[i, 0] = stuNo;
                    Student[i, 1] = dm;
                    Student[i, 2] = rad;
                    Student[i, 3] = os;

                }
            }

            return Student;
        }

        public double [] CalcAvg(int[,] StudentDetails)
        {


            int dmTotal = 0;
            int radTotal = 0;
            int osTotal = 0;


            for (int i = 0; i < 50; i++)

            {

                for (int j = 0; i < 4; j++)
                {
                    dmTotal += Student[i, 1];
                    radTotal += Student[i, 2];
                    osTotal += Student[i, 3];


                }



            }
            double dmAverage = dmTotal / 50;
            double radAverage = radTotal / 50;
            double osAverage = osTotal / 50;

            double[] average = new double[3];
            average[0] = dmAverage;
            average[1] = radAverage;
            average[2] = osAverage;

            return average;


        }
    }
}

    
