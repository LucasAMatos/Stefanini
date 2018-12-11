using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DML
{
    class Produto
    {
        int pId;
        string pNome;

        public int Id
        {
            get { return pId; }
        }
        public string Nome
        {
            get { return pNome; }
            set { pNome = value; }
        }
    }
}
