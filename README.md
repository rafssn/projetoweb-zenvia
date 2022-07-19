Desenvolvedor: Rafael Augusto Gonçalves

Documentação técnica: Projeto Desafio Zenvia : Aplicação Web.

Documentação da API (Swagger): disponível em: http://localhost:5000/swagger/index.html

Também está acessível em forma de JSON na raiz do projeto.



A API possui 5 endpoints listados no Swagger, com suas devidas configurações.
A base do projeto foi desenvolvida em um projeto de API em .NET 5. Utilizei o ORM Entity Framework para fazer a comunicação com a base de dados.
Os dados foram persistidos em um banco SQL Server 2019. O script da criação das tabelas se enconta na pasta raiz com o nome "DB scripts.txt".

Um desafio logo que recebi o projeto foi: "Como proporcionar aos avaliadores a possibilidade de gerar um banco que conecte-se com a API e possa sem mais delongas produzir nossa aplicação?". Então logo pensei em conteinerização e utilizei o Docker  Composer para criar uma composição do projeto da API e da base de dados que solucionasse este problema.
O arquivo "docker-compose.yml" está na raiz do projeto API e pode ser inicializado a partir do comando "docker compose up".

Para o Front-end opitei pelo uso do Angular.js juntamente com as linguagens HTML e CSS.
Não foi possível entregar todas as solicitações do projeto, mas criei a página inicial em poderemos listar os clientes cadastrados na API. Infelizmente por falta de tempo não pode ser concluído o restante.
