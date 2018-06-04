Trabalho acadêmico - AFSport 
Desenvolvido por: 
Carlos Eduardo de Oliveira
Marcus Vinicius Nunes
Paulo Sérgio Bressan Júnior
Rafael Antonio Lopes Alves
Sidney de Souza Júnior

Instalação do Software AFSport.

1 -  Acessar a Pasta AFSport.

2 -  Acessar a pasta Fonts e instalar as fontes que são utilizadas pelo software:
2.2	- Instalar a fonte Font Awesome 5 Brands-Regular-400.
2.3	- Instalar a fonte Font Awesome 5 Free-Regular-400.
2.3	- Instalar a fonte Font Awesome 5 Free-Solid-900.

3 - Na pasta raiz, executar o arquivo PimSql_final. O script de criação do banco será carregado no MySql Workbench. Selecionar todas as linhas e executar. O banco estará criado e pronto apara utilização.

4 - Clicar com o botão direito no arquivo AFSport.WindowsForms.exe e selecionar abrir com bloco de notas e inserir a senha do banco nos seguintes locais: (linhas 8 e 9).

password=*SENHA* 
Exemplo: password=admin

Onde está escrito *SENHA* deverá ser substituído pela senha do banco de dados (os asteriscos também devem ser removidos).
Após estes passos, o software estará pronto para ser utilizado.
5	- Executar o software pelo executável AFSport.WindowsForms.
6	- Informar usuário e senha padrão:

Usuário padrão: admin
Senha padrão: admin

*** REQUISITOS PARA A INSTALAÇÃO DO SOFTWARE:
WINDOWS 10 COMO SISTEMA OPERACIONAL.
MYSQL WORKBENCH COMO SGBD.


----------------------------------------------------------------------------------------------------------------------------------------

UTILIZAÇÃO DO SOFTWARE

DEPENDÊNCIAS

Algumas categorias possuem dependências relacionadas umas as outras, ou seja, algumas dependem de outras para existir através de um relacionamento hierárquico, como por exemplo: para que um produto possa ser cadastrado, ele deve pertencer a uma categoria, e uma categoria não pode ser excluída se um produto pertencer a esta mesma, porém o sistema permite a inativação de uma categoria, fazendo assim com que os produtos pertencentes a esta categoria, também sejam inativados.

DEPENDÊNCIAS EXISTENTES

CATEGORIA > PRODUTO
Para que um produto possa ser cadastrado, ele deve possuir uma categoria, esta categoria deve estar criada para que o produto possa ser vinculado a ela.

PRODUTO > PREÇO
Para que um preço possa ser cadastrado, ele deve possuir um produto, e é necessário que o produto referente a este preço esteja previamente cadastrado.

PRODUTO – USUÁRIO > ESTOQUE
Para que um estoque seja cadastrado, é necessário que ele possua um produto e um usuário, produto e usuário devem estar previamente cadastrados para que o estoque possa ser cadastrado.

ESTADO > CIDADE
Para que uma cidade possa ser cadastrada, ela deve possuir um estado, o estado deve estar previamente cadastrado, para que a cidade possa ser vinculada a ele.

CIDADE > CLIENTE
Para que um cliente possa ser cadastrado, ele deve possuir uma cidade, para isso a cidade em que o cliente irá pertencer, deverá estar previamente cadastrada.

CLIENTE – USUÁRIO > PEDIDO
Para que um pedido possa ser cadastrado, ele deve possuir um cliente e um usuário, cliente e usuários devem estar previamente cadastrados.
OPERAÇÃO – CAIXA > MOVIMENTAÇÃO
Para que uma movimentação possa ser cadastrada, ela deve possuir uma operação e um caixa operação e caixa devem estar previamente cadastrados.

GERAÇÃO DE PEDIDOS
O usuário irá informar o cliente e os produtos e suas respectivas quantidades. Caso haja a quantidade necessária disponível, será perguntado a forma de pagamento, e então o pedido será gerado. Caso contrário em relação a quantidade de produtos disponíveis, será informado a impossibilidade de prosseguir devido a insuficiência de produtos disponíveis e o pedido será cancelado.
