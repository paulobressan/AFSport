create database afsportdb;
use afsportdb;

create table estado(
	idEstado int unsigned auto_increment primary key,
    nome varchar(50) not null,
    sigla char(2) not null,
	isAtivo bool not null
);

create table cidade(
	idCidade int unsigned auto_increment primary key,
    idEstado int unsigned not null,
    nome varchar(50) not null,
    isAtivo bool not null,
    foreign key(idEstado) references estado(idEstado)
);

create table cliente(
	idCliente int unsigned auto_increment primary key,
    idCidade int unsigned not null,
    nome varchar(100) not null,
    logradouro varchar(255) not null,
    bairro varchar(50) not null,
    numero int,
    email varchar(255),
	foreign key(idCidade) references cidade(idCidade)
);

create table usuario(
	idUsuario int unsigned auto_increment primary key,
    nome varchar(50) not null,
    email varchar(255),
    login varchar(30) not null,
    senha varchar(30) not null,
    isAtivo bool not null
);

insert into usuario(nome, login, senha, isAtivo) values ('Administrador', 'admin', 'admin', 1);

create table categoria(
	idCategoria int unsigned auto_increment primary key,
	nome varchar(50) not null,
    descricao varchar(255),
    isAtivo bool not null
);

create table produto(
	idProduto int unsigned auto_increment primary key,
    idCategoria int unsigned not null,
    nome varchar(100) not null,
    descricao varchar(255),
    valorCompra decimal(12,2) not null,
    valorVenda decimal(12,2) not null,
    isAtivo bool,
    foreign key(idCategoria) references categoria(idCategoria)
);

create table preco(
	  idPreco int unsigned auto_increment primary key,
    idProduto int unsigned not null,
    dataInicio date not null,
    dataFinal date not null,
    valor decimal(12,2) not null,
    isAtivo bool,
    foreign key(idProduto) references produto(idProduto)
);

create table estoque(
	  idEstoque int unsigned auto_increment primary key,
    idProduto int unsigned not null,
    idUsuario int unsigned not null,
    quantidade int not null,
    foreign key(idProduto) references produto(idProduto),
    foreign key (idUsuario) references usuario(idUsuario)
);

create table pedido(
	idPedido int unsigned auto_increment primary key,
  idUsuario int unsigned not null,
  idCliente int unsigned,
  status int,
  data datetime not null,
  foreign key(idUsuario) references usuario(idUsuario),
	foreign key(idCliente) references cliente(idCliente)
);

create table itemPedido(
	idItemPedido int unsigned auto_increment primary key,
    idPedido int unsigned not null,
    idProduto int unsigned not null,
    quantidade int not null,
    foreign key(idPedido) references pedido(idPedido),
    foreign key (idProduto) references  produto(idProduto)
);

create table operacao(
	idOperacao int unsigned auto_increment primary key,
    nome varchar(60) not null,
    descricao varchar(255),
    isAtivo bool
);

insert into operacao(nome, descricao, isAtivo)  values ('Entrada Pedido', 'Movimentação gerada por pedido.', 1);
insert into operacao(nome, descricao, isAtivo)  values ('Estorno Pedido', 'Movimentação gerada por estorno de pedido.', 1);

create table caixa(
	idCaixa int unsigned auto_increment primary key,
    idUsuario int unsigned not null,
    data datetime not null,
    valorInicial decimal(12,2) not null,
    foreign key(idUsuario) references usuario(idUsuario)
);

create table movimentacao(
	idMovimentacao int unsigned auto_increment primary key,
    idUsuario int unsigned not null,
    idOperacao int unsigned,
    valor decimal(12,2) not null,
    data datetime not null,
    foreign key(idUsuario) references usuario(idUsuario),
    foreign key (idOperacao) references operacao(idOperacao)
);

create database questionario;
use questionario;

create table participantes(
  idParticipante int unsigned auto_increment primary key ,
  nome varchar(100),
  Telefone varchar(20)
);

create table perguntas(
  idPergunta int unsigned auto_increment primary key ,
  descricao varchar(500),
  sequencia int
);

create table tiposRespostas(
  idTipoResposta int unsigned auto_increment primary key,
  idPergunta int unsigned,
  descricao varchar(50),
  foreign key (idPergunta) references perguntas(idPergunta)
);

create table respostas (
  idRespota int unsigned auto_increment primary key,
  idParticipante int unsigned,
  idTipoResposta int unsigned null,
  idPergunta int unsigned,
  observacao varchar(500),
  foreign key (idParticipante) references participantes(idParticipante),
  foreign key (idTipoResposta) references tiposRespostas(idTipoResposta),
  foreign key (idPergunta) references perguntas(idPergunta)
);