﻿using System.Globalization;
namespace Cap2._1
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;



        public Produto()
        {
            Quantidade = 10;
        }
        
        public Produto(string Nome, double Preco) : this()
        {
            this.Nome = Nome;
            this.Preco = Preco;
            //usando o this, os atributos e métodos do Produto default
            //serão herdados aqui. Então não seria necessário 
            //setar o valor para Quantidade
        }
        
        /*public Produto(string Nome, double Preco)
        {
            //esse this referencia o this do atributo
            this.Nome = Nome; 
            //esse nome o Nome do parâmetro do construtor
            this.Preco = Preco;
            Quantidade = 0;
        }
        */
        
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        
        
        public double ValorTotalEmEstoque() 
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade) 
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) 
        {
            Quantidade -= quantidade;
        }
        public override string ToString() 
        {
            return Nome
                   + ", $ "
                   + Preco.ToString("F2", CultureInfo.InvariantCulture)
                   + ", "
                   + Quantidade
                   + " unidades, Total: $ "
                   + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
        
    }
}