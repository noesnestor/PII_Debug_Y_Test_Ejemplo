using System;
using System.Collections.Generic;
using System.Runtime;

namespace UnitTestAndDebug
{
    public class BirthCheck
    {
        public static bool DateOfBirthIsValid(string dateOfBirth)
        {  
        string[] strD_O_B = dateOfBirth.Split("/");
        int dia = Convert.ToInt32(strD_O_B[0]);
        int mes = Convert.ToInt32(strD_O_B[1]);
        int ano = Convert.ToInt32(strD_O_B[2]);
        if ((dia <= 30 && 1<= dia) && (mes <= 12 && 1<= mes) && (ano>1900))
            {
                return true;
            }
        return false;
        }
        
    }
}
