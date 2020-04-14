using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validaciones
{
    public class Validacion
    {


        public int validadornum(int teclanumeros)
        {
            switch (teclanumeros)
            {
                case 48:
                case 49:
                case 50:
                case 51:
                case 52:
                case 53:
                case 54:
                case 55:
                case 56:
                case 57:
                case 46:
                case 08:
                case 13:
                case 127:
                case 27:
                    return teclanumeros;

                default:
                    MessageBox.Show("porfavor no ingrese letras","advertencia de validacion", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    break;
            }
            return teclanumeros = 0;
        }

        public int validadoletra(int teclaletra)
        {
            switch (teclaletra)
            {
                case 65:
                case 66:
                case 67:
                case 68:
                case 69:
                case 70:
                case 71:
                case 72:
                case 73:
                case 74:
                case 75:
                case 76:
                case 77:
                case 27:

                case 78:
                case 79:
                case 80:
                case 81:
                case 82:
                case 83:
                case 84:
                case 85:
                case 86:
                case 87:
                case 88:
                case 89:
                case 90:


                case 96:
                
                case 97:
                case 98:
                case 99:
                case 100:
                case 101:
                case 102:
                case 103:
                case 104:
                case 105:
                case 106:
                case 107:


                case 108:
                case 109:
                case 110:
                case 111:
                case 112:
                case 113:
                case 114:
                case 115:
                case 116:
                case 117:
                case 118:
                case 119:
                case 120:


                case 121:

                case 122:
                case 160:
                case 161:
                case 162:
                case 163:
                case 164:
                case 165:
                case 166:
                case 08:
                case 13:
                case 32:
                case 127:

                    return teclaletra;

                default:
                    MessageBox.Show("porfavor no ingrese numeros", "advertencia de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            return teclaletra = 0;
        }


    }
}
