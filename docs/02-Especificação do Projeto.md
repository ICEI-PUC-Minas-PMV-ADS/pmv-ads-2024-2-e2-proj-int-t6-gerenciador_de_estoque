# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

<h3>Perfis de usuários</h3>

|Perfis de usuários|  |                |
|--------------------|------------------------------------|----------------------------------------|
|Perfil 1: Famílias|
|Descrição  | Casal com a vida agitada, equilibrando carreira e responsabilidades familiares.     |
|Necessidades  | - Gerenciar eficientemente o estoque de alimentos para toda a família e manter um estoque adequado de produtos de limpeza e higiene. |   |
|Perfil 2: Indivíduos que vivem sozinhos|
|Descrição  | Mora sozinho(a) em apartamento na cidade, carreira em crescimento, com pouco tempo livre.     |
|Necessidades  |     Controlar gastos pessoais e evitar compras impulsivas;  Gerenciar estoque de alimentos para uma pessoa; Manter um estoque mínimo de itens essenciais; Otimizar tempo gasto com compras e organização doméstica. |   |
|Perfil 3: Estudantes|
|Descrição  | Jovem com orçamento limitado e pouca experiência em gestão doméstica.      |
|Necessidades  | Gerenciar suprimentos escolares e livros; Planejar compras dentro de um orçamento apertado; Organizar espaço limitado de forma eficiente.|   |
|Perfil 4: Idosos ou cuidadores|
|Descrição  | Pessoa acima de 65 anos ou cuidador responsável, pode ter limitações físicas ou de memória.      |
|Necessidades  | Planejar reposição de itens essenciais para saúde. |   |


## Personas
<b>Persona 1:</b> Pedro</br> 
<b>Idade:</b>   52 anos<br/> 
<b>Profissão:</b>  Supervisor de produção<br/> 
<b>Localização:</b>  Belo Horizonte, Brasil</br> 
<b>Objetivo: </b> Organizar as compras da semana e evitar o desperdício<br/> 
<p><img src="img/pedro.png"/></p>
<b>Descrição: </b> Solteiro, pai de um filho, mora sozinho. É supervisor de vendas de uma fábrica de autopeças. Trabalha até 12h por dia. Gosta de soluções práticas e simples. Utiliza smartphone Android e notebook Windows em casa e no trabalho. Não gosta de ler manuais extensos de configurações personalizadas em apps e softwares.</br>  
<b>Dores: </b> Tem dificuldade para gerenciar o estoque de casa, pois passa muito tempo fora. Vai às compras de supermercado sem lista e acaba comprando coisas supérfluas ou itens duplicados, que já se encontram na dispensa.<br/>  
<b>Expectativas: </b> Conseguir gerenciar o estoque da dispensa remotamente, de maneira objetiva e prática.</br> 
<br/>
<b>Persona 2: </b>  João<br/>
<b>Idade: </b>   28 anos<br/> 
<b>Profissão: </b>  Designer Gráfico<br/> 
<b>Localização: </b>  Belo Horizonte, Brasil<br/> 
<b>Objetivo: </b>  Organizar as compras e criar uma lista personalizada de alimentos veganos<br/> 
<p><img src="img/joao.png"/></p>
<b>Descrição:</b> Solteiro, mora com os pais. É vegano. Trabalha em home-office e um dia na semana se reúne com os colegas de trabalho na empresa. Gosta de soluções completas e customizáveis. Gosta de configurações personalizadas nos apps e softwares, e ler manuais quando precisa de informações detalhadas. Usa um iPhone e um MacBook.<br/>
<b>Dores:</b> Gasta muito tempo planejando sua dieta da semana.<br/>  
<b>Expectativas: </b>Gostaria de otimizar o seu tempo, criando dietas personalizadas de produtos veganos, e ir variando ao longo da semana. Gostaria de gerenciar o estoque.<br/> 

<br/>
<b>Persona 3:</b> Karla<br/> 
<b>Idade:</b>  42 anos<br/> 
<b>Profissão:</b> Vendedora<br/> 
<b>Localização:</b> Belo Horizonte, Brasil<br/> 
<b>Objetivo:</b> Organizar o estoque de alimentos de sua casa<br/> 
<p><img src="img/Karla.png"/></p>
<b>Descrição: </b>Karla é vendedora de uma concessionária de veículo. É casada e tem dois filhos. Trabalha até 10h por dia. Tem um smartphone Android, um computador desktop Windows, e um notebook Windows no trabalho. Gosta de configurar apps e softwares, porém é muito cautelosa e teme que algo dê errado.<br/> 
<b>Dores:  </b>Tem dificuldade de gerenciar o estoque de casa, por passar muito tempo fora. Não tem tempo para planejar as compras da semana, e acaba comprando muitos itens do mesmo produto, ou perdendo produtos vencidos. <br/>  
<b>Expectativas: </b>Um sistema que possibilite gerenciar o estoque de casa de maneira remota.<br/><br/> 


<p>Enumere e detalhe as personas da sua solução. Para tanto, baseie-se tanto nos documentos disponibilizados na disciplina e/ou nos seguintes links:</p>

> **Links Úteis**:
> 
> - [Rock Content](https://rockcontent.com/blog/personas/)
> - [Hotmart](https://blog.hotmart.com/pt-br/como-criar-persona-negocio/)
> - [O que é persona?](https://resultadosdigitais.com.br/blog/persona-o-que-e/)
> - [Persona x Público-alvo](https://flammo.com.br/blog/persona-e-publico-alvo-qual-a-diferenca/)
> - [Mapa de Empatia](https://resultadosdigitais.com.br/blog/mapa-da-empatia/)
> - [Mapa de Stalkeholders](https://www.racecomunicacao.com.br/blog/como-fazer-o-mapeamento-de-stakeholders/)
>
Lembre-se que você deve ser enumerar e descrever precisamente e personalizada todos os clientes ideais que sua solução almeja.

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Pedro  | Um aplicativo de que permita monitorar remotamente o que tenho em casa.     | Evitar desperdícios e compras desnecessárias, e economizar tempo nas minhas compras semanais.                |
|Pedro  | Aplicativo fácil de usar uso e com interface amigável.     | Evitar perda de tempo.   |
|João    | Um sistema que me permita criar listas personalizadas de produtos veganos.      | Ajudar a planejar minhas refeições de forma mais eficiente.    |
|João   | Que permita gerenciar meu estoque.      | Para otimizar meu tempo e manter minha dieta saudável.    |
|Karla  | Um sistema de gerenciamento de estoque que seja prático e seguro. | Me permitirá acompanhar os produtos da dispensa,evitar desperdícios, organizar melhor as compras e não perder tempo com configurações complexas     |

Apresente aqui as histórias de usuário que são relevantes para o projeto de sua solução. As Histórias de Usuário consistem em uma ferramenta poderosa para a compreensão e elicitação dos requisitos funcionais e não funcionais da sua aplicação. Se possível, agrupe as histórias de usuário por contexto, para facilitar consultas recorrentes à essa parte do documento.

> **Links Úteis**:
> - [Histórias de usuários com exemplos e template](https://www.atlassian.com/br/agile/project-management/user-stories)
> - [Como escrever boas histórias de usuário (User Stories)](https://medium.com/vertice/como-escrever-boas-users-stories-hist%C3%B3rias-de-usu%C3%A1rios-b29c75043fac)
> - [User Stories: requisitos que humanos entendem](https://www.luiztools.com.br/post/user-stories-descricao-de-requisitos-que-humanos-entendem/)
> - [Histórias de Usuários: mais exemplos](https://www.reqview.com/doc/user-stories-example.html)
> - [9 Common User Story Mistakes](https://airfocus.com/blog/user-story-mistakes/)

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| O usuário deve poder criar sua conta na aplicação. | ALTA | 
|RF-002| O usuário registrado deve poder fazer login utilizando suas credenciais (e-mail e senha). | ALTA |
|RF-003| O usuário deve poder gerenciar seus dados pessoais. | MÉDIA |
|RF-004| O usuário deve poder gerenciar seus produtos. | ALTA |
|RF-005| O usuário deve poder ter acesso aos registros de entradas e saídas. | MÉDIA |
|RF-006| O usuário deve poder acessar o relatório de estoque mínimo. | BAIXO |
|RF-007| O usuário deve poder consultar a quantidade de produtos em estoque. | ALTA |
|RF-008| O sistema deve cadastrar fornecedores, e o relacionar aos produtos. | MÉDIA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| A aplicação deve se adaptar a diferentes tamanhos de tela e dispositivos. | ALTA | 
|RNF-002| O site deve ser compatível com os principais navegadores da web, como Chrome, Firefox, Safari e Edge. |  ALTA |
|RNF-002| A aplicação deve processar requisições do usuário em no máximo 5 segundos. |  MÉDIA | 
|RNF-002| O backend do sistema deve ser desenvolvido em linguagem C# e rodar em servidor Windows ou Linux, com o framework Microsoft .NET 8 |  BAIXA | 

Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.
![Diagrama de caso de uso](https://github.com/user-attachments/assets/2497052d-5232-43ff-aa08-74d8f2c03fe2)


> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
