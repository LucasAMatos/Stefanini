using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DML
{
    class Cliente
    {
        int pId;
        string pNome;
        string pSobrenome;
        DateTime pDtNasc;
        sexo pSexo;
        string pEmail;
        Boolean pAtivo;

        public int Id {
            get {   return pId;  }
        }
        public string Nome
        {
            get { return pNome; }
            set { pNome = value; }
        }
        public string Sobrenome
        {
            get { return pSobrenome; }
            set { pSobrenome = value; }
        }
        public DateTime DtNasc
        {
            get { return pDtNasc; }
            set { pDtNasc = value; }
        }
        public string Email
        {
            get { return pEmail; }
            set { pEmail = value; }
        }
        public bool Ativo
        {
            get { return pAtivo; }
            set { pAtivo = value; }
        }
        public sexo Sexo
        {
            get { return pSexo; }
            set { pSexo = value; }
        }

        public enum sexo { Masculino, Feminino };
    }
}
