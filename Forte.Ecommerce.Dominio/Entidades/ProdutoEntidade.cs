﻿namespace Forte.Ecommerce.Dominio.Entidades;

public class ProdutoEntidade : Entidade
{
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public decimal ValorProduto { get; set; }
    public Guid PedidoId { get; set; }
    public PedidoEntidade? Pedido { get; set; }
}
