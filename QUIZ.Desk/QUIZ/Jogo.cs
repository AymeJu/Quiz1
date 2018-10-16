using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZ
{
    class Jogo
    {
        // 1. Atributos da classe
        #region Atributos
        private int _perguntas;
        private string _fase;
        private bool _respostas;

        #endregion

        // 2. Método imprimir
        #region método imp
        public string Imprimir()
        {
            string mensa = "";
         
            if (_perguntas <= 10)
            {
                
                mensa += "Fase Fácil";
            }
            else if (_perguntas <= 20)
            {
                mensa += "Fase Média";
            }
            else if (_perguntas <= 30)
            {
                mensa += "Fase Difícil";
            }

            if (_respostas == true)
            {
                mensa += "Próxima pergunta";
            }

            else if (_respostas == false)
            {
                mensa += "Voltar ao início";
            }

            return mensa;
           
        }
        #endregion

        // 3. Método construtor
        #region método const
        public Jogo() { }
        public Jogo(int _perguntas, string _fase, bool _respostas)

        {
            this._perguntas = _perguntas;
            this._fase = _fase;
            this._respostas = _respostas;
        }
        #endregion




    }
}
