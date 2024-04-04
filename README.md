# EventPassIn
# Pass In API
A PassIn API é uma aplicação desenvolvida em C# utilizando o framework ASP.NET Core MVC. Esta API foi criada para gerenciar eventos, oferecendo funcionalidades como registro de participantes, check-in de participantes em eventos e criação/recuperação de eventos.

# Recursos Principais
*Registro de Participantes em Eventos:* Esta API permite o registro de participantes em eventos por meio da rota /attendees. Os usuários podem registrar um novo participante em um evento específico ou recuperar a lista de participantes de um evento.

*Check-in de Participantes em Eventos:* Além do registro de participantes, a API oferece a funcionalidade de fazer o check-in de participantes em eventos por meio da rota /checkin. Isso permite marcar a presença de um participante em um evento específico.

*Criação e Recuperação de Eventos:* A API também suporta a criação de novos eventos e a recuperação de eventos existentes por meio da rota /events. Os usuários podem criar um novo evento fornecendo informações como título, descrição, data, hora e localização, além de recuperar detalhes de um evento específico com base em seu ID.

# Tecnologias Utilizadas
*ASP.NET Core MVC:* O projeto é construído com base no framework ASP.NET Core MVC, que fornece uma estrutura robusta para construção de aplicativos web e APIs RESTful.

*C#:* A linguagem de programação principal utilizada no projeto é o C#, que é amplamente utilizado no ecossistema do .NET Core.

*Microsoft.AspNetCore.Mvc:* A API faz uso extensivo do namespace Microsoft.AspNetCore.Mvc para definir controladores, rotas e a lógica de manipulação de solicitações HTTP.
