# Word Online
## Um projeto CRUD para demonstrar de forma simples, a criação e edição de projetos word na web.

Esse é um projeto acadêmico, para fins de estudo, aonde o objetivo era criar um sistema online, semelhante ao WORD, para criação de textos e edição dos mesmos

## Índice

- [Instalação](#instalação)
- [Como Usar](#como-usar)
- [Contribuindo](#contribuindo)
- [Equipe](#equipe)
- [Feedback e Contato](#feedback-e-contato)
- [Licença](#licença)

## Tecnologias Usadas

Liste as tecnologias, frameworks e bibliotecas utilizadas no projeto. Exemplo:
- .Net 8
- ASP NET MVC
- Entity Framework
- SQL Server

## Instalação
### Pré-requisitos

Antes de começar, verifique se tu  atendeu aos seguintes requisitos:
- Instalar o Runtime do ASP.NET Core 8.0.6 (para a correta visualização do Projeto.)
- Instalar os Pacotes: EntityFrameworkCore, EntityFrameworkCore.Design, EntityFrameworkCore.SqlServer, EntityFrameworkCore.Tools - version: 8.0.6
- Funciona tanto em `Windows/Linux/Mac`.
  

### Configuração

Para instalar o Word Online, siga estes passos:

É necessário ter o Visual Studio 2022 instalado, e de preferência nas ultimas versões de atualização.
O projeto no visual Studio roda sem problemas, e da mesma maneira no : Linux e macOS, Windows:


## Como Usar
Após a instalação, para usar o projeto no visual studio, inicie pelo menu do IIS Express, sem depuraação, para início mais rápido e leve.
É necessário ter o SQL Express na máquina para criação das tabelas do sistema.

Necessário mudar a string do banco no arquivo `appsettings.json`, altere apenas o Server, para o seu local, na sequência, utilize o comando abaixo paa criar o banco e as tabelas.
(Lembrando, necessário mudar a senha do SA, para a sua local, ou deixar com autenticação windows, basta apenas tirar o User ID e Password da string)

\`\`\`bash
Update-Database
\`\`\`

## Contribuindo

Contribuições são o que fazem a comunidade open source um lugar incrível para aprender, inspirar e criar. Quaisquer contribuições que tu fizer são **muito apreciadas**.

Se tu tem sugestões para melhorar este projeto, siga estes passos:

1. Bifurque o projeto
2. Crie uma Branch (`git checkout -b feature/AmazingFeature`)
3. Faça suas alterações no código
4. Confirme suas alterações (`git commit -m 'Add some AmazingFeature'`)
5. Envie para a Branch (`git push origin feature/AmazingFeature`)
6. Abra um Pull Request

Não se esqueça de ler o `CONTRIBUTING.md` para detalhes sobre o código de conduta, e o processo para enviar pull requests para nós.

## Equipe

Liste os membros da equipe que contribuíram para este projeto. Exemplo:
- [@fulano](https://github.com/fulano) - Ideia & Desenvolvimento inicial
- [@beltrano](https://github.com/beltrano) - Documentação
- [@sicrano](https://github.com/sicrano) - Manutenção

## Feedback e Contato

Para enviar feedback ou entrar em contato, por favor, envie um e-mail para `seu_email@example.com`.

## Licença

Este projeto está licenciado sob a Licença XYZ - veja o arquivo [LICENSE.md](LICENSE.md) para detalhes.
