using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classcalificaciones
{
    public class Classcalificacion
    {
       public string Nombrealumno { set; get; }


       public  float cali1;
        public float cali2;
        public float cali3;
        public double promedio;


        public string nombrealumno(string nomalumno)
        {
            Nombrealumno = nomalumno;
            
            return nomalumno;
        }

        public  void operaciones(string calii1, string calii2, string calii3)

        {
            string cad = "";

            cali1 = float.Parse(calii1);
            cali2 = float.Parse(calii2);
            cali3 = float.Parse(calii3);

           


            alumnopromedio();


           



        }
        public double alumnopromedio()

        {
            
            

            promedio = (cali1 + cali2 + cali3) / 3.0;

            MessageBox.Show("el alumno "+" "+ Nombrealumno+" ,"+"su promedio es "+""+promedio);

            MessageBox.Show("ya estoy hasta la madre de la cuarentena chingaaa");


            return promedio;


           
        }

       



        }
    }
  

