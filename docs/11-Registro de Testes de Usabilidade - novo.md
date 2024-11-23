# Registro de Testes de Usabilidade

Para a realização desse teste foi, recorremos a amigos e familiares para testarem nossa aplicação, e nos darem feedbacks relacionados aos quatro pontos destacados por nossa equipe de analise. 
Após os testes de usuários, foram feitas algumas perguntas relacionadas aos pontos de usabilidade e designs e utilizamos o metodo de avaliação como a escala de 03 pontos. 

- Escala de 03 pontos A escala de 03 pontos possui 03 possíveis escolhas de resposta, tornando de forma simples e muito compreensível o entendimento do feedback recebido, dentre elas as respostas são:

01. Abaixo da expectativas ou (“não atende as expectativas”)
02. Dentro das expectativas ou (“atende as expectativas”)
03. Acima das expectativas ou (“excede as expectativas”)


| Caso de Teste    | CT-01 - Registrar-se na plataforma |
|:---|:---|
| Requisitos Associados                     | RF-01  Registro na plataforma |
| Em uma escala de 01 a 03, quão fácil e intuitivo foi Registrar-se na plataforma ?|
| **Critério de Êxito** | **O registro é finalizado com êxito, redirecionando o usuário para a página de login.** |
|<li> Usuário |<li> Escala |
| Usuário 01    (Viajantes Individuais)                 |  Escala 02 (Usuario não teve muito dificuldade na realizaçao do cadastro) |
| Usuário 02    (Grupos e Famílias )                    |  Escala 01 (Usuarios sem  dificuldade para resgsitrar na plataforma, porem com  duvidas entre o Username é o nome|
| Usuário 03    (Viajantes de Orçamento Limitado)       |  Escala 01 (Usuarios com dificuldades em registrar-se na plataforma, duvidas entre o Username é o nome, qual E-mail é padrão de senha/o que tinha que colocar ) |
| Usuário 04    (Viajantes Experientes)                 |  Escala 02 (Usuario não teve muito dificuldade na realizaçao do cadastro) |


| Caso de Teste    | CT-02 - Realizar login utilizando as credenciais cadastradas|
|:---|:---|
| Requisitos Associados                    | RF-02 Login |
| Em uma escala de 01 a 03, quão fácil e intuitivo foi Realizar login utilizando as credenciais cadastradas?|
| **Critério de Êxito** | **Realizar o login com êxito e ser redirecionado para a página principal.** |
|<li> Usuário |<li> Escala |
| Usuário 01    (Viajantes Individuais)                 |  Escala 02 (Usuario não teve muito dificuldade no login) |
| Usuário 02    (Grupos e Famílias )                    |  Escala 01 (Bastante Dificuldade Relacionado ao Username) |
| Usuário 03    (Viajantes de Orçamento Limitado)       |  Escala 02 (Duvida com o Username) |
| Usuário 04    (Viajantes Experientes)                 |  Escala 03 (Usuario fez login de boa) |

| Caso de Teste    | CT-03 - Adicionar uma viagem |
|:---|:---|
| Requisitos Associados                    | RF-03  A inclusão de uma viagem |
| Em uma escala de 01 a 03, quão fácil e intuitivo foi Incluir uma nova viagem e confirmar sua visualização de viagens na lista?|
| **Critério de Êxito** | **Incluir com êxito uma nova viagem e confirmar sua visualização de viagens na lista.** |
|<li> Usuário |<li> Escala |
| Usuário 01    (Viajantes Individuais)                 |  Escala 02 (Criou a viagem sem Dificuldade ) |
| Usuário 02    (Grupos e Famílias )                    |  Escala 01 (Criou a viagem com duvida no que seria o  "Número da Viagem" é "Link da Imagem") |
| Usuário 03    (Viajantes de Orçamento Limitado)       |  Escala 02 (Criou a viagem com duvida no que seria o  "Número da Viagem" é "Link da Imagem") |
| Usuário 04    (Viajantes Experientes)                 |  Escala 01 (Criou a viagem com duvida no  "Link da Imagem") |

| Caso de Teste    | CT-04 - Criar grupo de viagem |
|:---|:---|
| Requisitos Associados                    | RF-04  A criação de um grupo de viagem |
| Em uma escala de 01 a 03, quão fácil e intuitivo foi Criar grupo de viagem?|
| **Critério de Êxito** | **Adicionar mebros e visualizá-la na lista de membros** |
|<li> Usuário |<li> Escala |
| Usuário 01    (Viajantes Individuais)                 |  Escala 01 (Não foi Possível realizar essa função por diversos bugs é a falta de tempo para conclusão so Eixo) |
| Usuário 02    (Grupos e Famílias )                    |  Escala 01 (Não foi Possível realizar essa função por diversos bugs é a falta de tempo para conclusão so Eixo)|
| Usuário 03    (Viajantes de Orçamento Limitado)       |  Escala 01 (Não foi Possível realizar essa função por diversos bugs é a falta de tempo para conclusão so Eixo) |
| Usuário 04    (Viajantes Experientes)                 |  Escala 01 (Não foi Possível realizar essa função por diversos bugs é a falta de tempo para conclusão so Eixo) |

| Caso de Teste    | CT-05 - Gerar relatorio de gastos |
|:---|:---|
| Requisitos Associados                    | RF-05  Geração de relatório de gastos |
| Em uma escala de 01 a 03, quão fácil e intuitivo foi gerar relatorio de gastos?|
| **Critério de Êxito** | **Emissao de gastos em PDF** |
|<li> Usuário |<li> Escala |
| Usuário 01    (Viajantes Individuais)                 |  Escala 03 (Gerou o relatorio sem problema) |
| Usuário 02    (Grupos e Famílias )                    |  Escala 03 (Gerou o relatorio sem problema) |
| Usuário 03    (Viajantes de Orçamento Limitado)       |  Escala 03 (Gerou o relatorio sem problema) |
| Usuário 04    (Viajantes Experientes)                 |  Escala 03 (Gerou o relatorio sem problema) |

 **constatação final**  
O teste de usabilidade revelou alguns problemas críticos no sistema. Primeiramente, no cadastro de usuário, se as senhas digitadas forem diferentes, o usuário não é cadastrado e também não recebe nenhuma notificação sobre o erro, o que pode gerar confusão e frustração. Ao criar uma viagem, a digitação do número da viagem mostrou-se problemática, levantando questões sobre a gestão de números de viagens iguais. Além disso, muitos requisitos funcionais esperados não foram desenvolvidos, como a capacidade de compartilhar itinerário, dividir gastos e recomendar hospedagens. Por outro lado, os relatórios do sistema foram avaliados positivamente, com relatórios diários de gastos por viagem e o custo total da viagem funcionando conforme esperado.







