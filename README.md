# ProvaA1
Descrição
Este projeto foi desenvolvido como parte da disciplina de Desenvolvimento de Sistemas para a faculdade. O objetivo é implementar um sistema de gerenciamento de bicicletas utilizando o padrão de projeto MVC (Model-View-Controller) e a arquitetura de três camadas (DTO, BLL, DAL). O sistema permite operações CRUD (Create, Read, Update, Delete) em uma base de dados MySQL.

#Estrutura do Projeto
O projeto está dividido nas seguintes camadas:

- DTO (Data Transfer Object): Contém as classes de transferência de dados.
- DAL (Data Access Layer): Contém as classes para acesso ao banco de dados.
- BLL (Business Logic Layer): Contém as regras de negócio e lógica do aplicativo.
- UI (User Interface): Contém os formulários do Windows Forms e a interação com o usuário.
  
**Funcionalidades**
- Adicionar novas bicicletas.
- Atualizar informações de bicicletas existentes.
- Deletar bicicletas.
- Listar todas as bicicletas.
  
**Tecnologias Utilizadas**
- C# com Windows Forms.
- MySQL para o banco de dados.
- Biblioteca MySql.Data para comunicação com o banco de dados.
  
**Requisitos**
Visual Studio 2019 ou superior.
MySQL Server.
.NET Framework 4.7.2 ou superior.

**Configuração do Ambiente**
1- Clone o repositório

2- Com o projeto aberto no Visual Studio Code intale o pacote 'MySql.Data'

3- Configure a string de conexão no arquivo 'BicicletaDAL.cs':
private string connectionString = "Host=localhost;Database=provaA1;Username=root;Password=sua_senha;Convert Zero Datetime=True";


**Executando o Projeto**
1- Compile o projeto no Visual Studio.
2- Execute o projeto pressionando F5 ou selecionando Debug > Start Debugging.
**Autor:**
Maria Cecília Araujo Lemos
Observações
Este projeto é parte de uma avaliação para a faculdade e foi desenvolvido com fins educativos. Se encontrar algum problema ou tiver sugestões, por favor, entre em contato.
