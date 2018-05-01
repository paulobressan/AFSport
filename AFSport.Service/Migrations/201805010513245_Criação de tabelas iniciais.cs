namespace AFSport.Service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Criaçãodetabelasiniciais : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Caixas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ValorInicial = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Data = c.DateTime(nullable: false),
                        Usuario_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.Usuario_Id)
                .Index(t => t.Usuario_Id);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Senha = c.String(),
                        Nome = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cidades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Estado_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Estadoes", t => t.Estado_Id)
                .Index(t => t.Estado_Id);
            
            CreateTable(
                "dbo.Estadoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Sigla = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Logradouro = c.String(),
                        Numero = c.Int(nullable: false),
                        Bairro = c.String(),
                        Nome = c.String(),
                        Email = c.String(),
                        Cidade_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cidades", t => t.Cidade_Id)
                .Index(t => t.Cidade_Id);
            
            CreateTable(
                "dbo.Estoques",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantidade = c.Int(nullable: false),
                        Produto_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Produtoes", t => t.Produto_Id)
                .Index(t => t.Produto_Id);
            
            CreateTable(
                "dbo.Produtoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Descricao = c.String(),
                        ValorCompra = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ValorVenda = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Categoria_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categorias", t => t.Categoria_Id)
                .Index(t => t.Categoria_Id);
            
            CreateTable(
                "dbo.ItemPedidoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantidade = c.Int(nullable: false),
                        Pedidio_Id = c.Int(),
                        Produto_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pedidoes", t => t.Pedidio_Id)
                .ForeignKey("dbo.Produtoes", t => t.Produto_Id)
                .Index(t => t.Pedidio_Id)
                .Index(t => t.Produto_Id);
            
            CreateTable(
                "dbo.Pedidoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Data = c.DateTime(nullable: false),
                        Cliente_Id = c.Int(),
                        Usuario_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.Cliente_Id)
                .ForeignKey("dbo.Usuarios", t => t.Usuario_Id)
                .Index(t => t.Cliente_Id)
                .Index(t => t.Usuario_Id);
            
            CreateTable(
                "dbo.Movimentacaos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Data = c.DateTime(nullable: false),
                        Operecao_Id = c.Int(),
                        Pedido_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Operacaos", t => t.Operecao_Id)
                .ForeignKey("dbo.Pedidoes", t => t.Pedido_Id)
                .Index(t => t.Operecao_Id)
                .Index(t => t.Pedido_Id);
            
            CreateTable(
                "dbo.Operacaos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Precoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataInicio = c.DateTime(nullable: false),
                        DataFinal = c.DateTime(nullable: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Produto_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Produtoes", t => t.Produto_Id)
                .Index(t => t.Produto_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Precoes", "Produto_Id", "dbo.Produtoes");
            DropForeignKey("dbo.Movimentacaos", "Pedido_Id", "dbo.Pedidoes");
            DropForeignKey("dbo.Movimentacaos", "Operecao_Id", "dbo.Operacaos");
            DropForeignKey("dbo.ItemPedidoes", "Produto_Id", "dbo.Produtoes");
            DropForeignKey("dbo.ItemPedidoes", "Pedidio_Id", "dbo.Pedidoes");
            DropForeignKey("dbo.Pedidoes", "Usuario_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Pedidoes", "Cliente_Id", "dbo.Clientes");
            DropForeignKey("dbo.Estoques", "Produto_Id", "dbo.Produtoes");
            DropForeignKey("dbo.Produtoes", "Categoria_Id", "dbo.Categorias");
            DropForeignKey("dbo.Clientes", "Cidade_Id", "dbo.Cidades");
            DropForeignKey("dbo.Cidades", "Estado_Id", "dbo.Estadoes");
            DropForeignKey("dbo.Caixas", "Usuario_Id", "dbo.Usuarios");
            DropIndex("dbo.Precoes", new[] { "Produto_Id" });
            DropIndex("dbo.Movimentacaos", new[] { "Pedido_Id" });
            DropIndex("dbo.Movimentacaos", new[] { "Operecao_Id" });
            DropIndex("dbo.Pedidoes", new[] { "Usuario_Id" });
            DropIndex("dbo.Pedidoes", new[] { "Cliente_Id" });
            DropIndex("dbo.ItemPedidoes", new[] { "Produto_Id" });
            DropIndex("dbo.ItemPedidoes", new[] { "Pedidio_Id" });
            DropIndex("dbo.Produtoes", new[] { "Categoria_Id" });
            DropIndex("dbo.Estoques", new[] { "Produto_Id" });
            DropIndex("dbo.Clientes", new[] { "Cidade_Id" });
            DropIndex("dbo.Cidades", new[] { "Estado_Id" });
            DropIndex("dbo.Caixas", new[] { "Usuario_Id" });
            DropTable("dbo.Precoes");
            DropTable("dbo.Operacaos");
            DropTable("dbo.Movimentacaos");
            DropTable("dbo.Pedidoes");
            DropTable("dbo.ItemPedidoes");
            DropTable("dbo.Produtoes");
            DropTable("dbo.Estoques");
            DropTable("dbo.Clientes");
            DropTable("dbo.Estadoes");
            DropTable("dbo.Cidades");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Caixas");
        }
    }
}
