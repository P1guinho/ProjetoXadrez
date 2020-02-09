﻿using System;
using System.Collections.Generic;
using System.Text;
using Tabuleiro;

namespace Tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdMovimentos { get; protected set; }
        public Tabuleiro tab { get; set; }

        public Peca(Posicao Posicao,Cor Cor, Tabuleiro Tab)
        {
            this.posicao = Posicao;
            this.cor = Cor;
            this.qtdMovimentos = 0;
            this.tab = Tab;
        }
    }
}