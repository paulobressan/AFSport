namespace AFSport.Service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IsAtivoemtodastabelas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Caixas", "IsAtivo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Usuarios", "IsAtivo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Categorias", "IsAtivo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Cidades", "IsAtivo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Estadoes", "IsAtivo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Clientes", "IsAtivo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Estoques", "IsAtivo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Produtoes", "IsAtivo", c => c.Boolean(nullable: false));
            AddColumn("dbo.ItemPedidoes", "IsAtivo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pedidoes", "IsAtivo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Movimentacaos", "IsAtivo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Operacaos", "IsAtivo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Precoes", "IsAtivo", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Precoes", "IsAtivo");
            DropColumn("dbo.Operacaos", "IsAtivo");
            DropColumn("dbo.Movimentacaos", "IsAtivo");
            DropColumn("dbo.Pedidoes", "IsAtivo");
            DropColumn("dbo.ItemPedidoes", "IsAtivo");
            DropColumn("dbo.Produtoes", "IsAtivo");
            DropColumn("dbo.Estoques", "IsAtivo");
            DropColumn("dbo.Clientes", "IsAtivo");
            DropColumn("dbo.Estadoes", "IsAtivo");
            DropColumn("dbo.Cidades", "IsAtivo");
            DropColumn("dbo.Categorias", "IsAtivo");
            DropColumn("dbo.Usuarios", "IsAtivo");
            DropColumn("dbo.Caixas", "IsAtivo");
        }
    }
}
