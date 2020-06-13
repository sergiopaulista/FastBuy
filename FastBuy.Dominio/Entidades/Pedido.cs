﻿using FastBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace FastBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }

        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }



        // Pedido deve tyer pelo menos um item de pedido ou muitos itens de pedidos

        public ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validade()
        {
            LimparMensagemValidacao();

            if (!ItensPedido.Any())
                AdicionarCritica("Crítica Pedido não pode ficar sem item de pedido");

            if (string.IsNullOrEmpty(CEP))
                AdicionarCritica("Crítica - Cep deve estar preenchido ");



        }
    }
}
