﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdStore.Catalogo.Domain.Events
{
    public class ProdutoEventHandler : INotificationHandler<ProdutoAbaixoEstoqueEvent>
    {
        private readonly IProdutoRepository produtoRepository;

        public ProdutoEventHandler(IProdutoRepository produtoRepository)
        {
            this.produtoRepository = produtoRepository;
        }

        public async Task Handle(ProdutoAbaixoEstoqueEvent mensagem, CancellationToken cancellationToken)
        {
            var produto = produtoRepository.ObterPorId(mensagem.AggregatedId);

            // Enviar um email para aquisição de mais produtos.
        }
    }
}
