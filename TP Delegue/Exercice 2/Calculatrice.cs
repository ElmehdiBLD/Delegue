using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice_2
{
    
    class Calculatrice
    {
        PrototypeOperation dlgoperation = null;
        List<int> lesNombres;

        public Calculatrice()
        {
            
            lesNombres =  new List<int>();
        }

        public void Add(int n)
        {
            lesNombres.Add(n);
        }
        public int Additions(int n1, int n2)
        {
            int result;
            result = n1 + n2;
            lesNombres.Add(result);
            return result;
        }
        public int Calculer()
        {
            int i = 0;
            int e = 0;
            foreach (PrototypeOperation uneMethode in dlgoperation.GetInvocationList())
            {
                e=uneMethode.Invoke(lesNombres[i], lesNombres[i + 1]);
                i = i + 2;
            }
            return e;
            

        }
        
        public void ChoixOperation(operation choix)
        {
            if (choix == operation.addition)
            {
                dlgoperation += Additions;
            }
            else
            {
                dlgoperation += Soustraction;
            }
           
        }
        public int Soustraction(int n1, int n2)
        {
            int result;
            result = n2 - n1;
            lesNombres.Add(result);
            return result;

        }
       
    }
}
