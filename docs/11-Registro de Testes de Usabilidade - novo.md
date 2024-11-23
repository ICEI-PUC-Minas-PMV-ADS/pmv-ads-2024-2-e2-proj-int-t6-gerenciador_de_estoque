# Registro de Testes de Usabilidade

Para realizar os testes recorremos a colegas de trabalho na empresa de um dos membros do grupo.

<b>Escala de 03 pontos: </b>A escala de 03 pontos possui 03 possíveis escolhas de resposta, tornando de forma simples e muito compreensível o entendimento do feedback recebido, dentre elas as respostas são:

01. Abaixo da expectativas ou (“não atende às expectativas”)
02. Dentro das expectativas ou (“atende às expectativas”)
03. Acima das expectativas ou (“excede as expectativas”)


| Caso de Teste    | CT-01 - Registrar-se na plataforma |
|:---|:---|
| Requisitos Associados                     | RF-01  Registro na plataforma |
| Em uma escala de 01 a 03, quão fácil e intuitivo foi Registrar-se na plataforma ?|
| **Critério de Êxito** | **O registro é finalizado com êxito, redirecionando o usuário para a página de login.** |
|<li> Usuário |<li> Escala |
| Usuário 01    (Desenvolvedor)                 |  Escala 02 (Usuario não teve muito dificuldade na realizaçao do cadastro) |
| Usuário 02    (Suporte de TI)                    |  Escala 02 (Usuario não teve muito dificuldade na realizaçao do cadastro)|


| Caso de Teste    | CT-02 - Realizar login utilizando as credenciais cadastradas|
|:---|:---|
| Requisitos Associados                    | RF-02 Login |
| Em uma escala de 01 a 03, quão fácil e intuitivo foi Realizar login utilizando as credenciais cadastradas?|
| **Critério de Êxito** | **Realizar o login com êxito e ser redirecionado para a página principal.** |
|<li> Usuário |<li> Escala |
| Usuário 01                |  Escala 01 (O usuário ficou aguardando um tempo até que entendeu que o login não seria automatico após o cadastro) |
| Usuário 02                 |  Escala 01 (Mesmo caso do Usuario 2) |


| Caso de Teste    | CT-03 - Gerenciar dados do perfil|
|:---|:---|
| Requisitos Associados                    | RF-03  Gerenciar o perfil |
| Em uma escala de 01 a 03, quão fácil e intuitivo foi editar o perfil, alterando as informações como nome, usuário e senhha?|
| **Critério de Êxito** | **Usuário consegue alterar seus dados sem dificuldades.** |
|<li> Usuário |<li> Escala |
| Usuário 01    |  Escala 02 (Editou e salvou as alterações sem dificuldade ) |
| Usuário 02    |  Escala 01 (Editou e salvou as alteraçoes sem dificuldade) |


| Caso de Teste    | CT-04 - Gerenciar produtos |
|:---|:---|
| Requisitos Associados                    | RF-04  Gerenciar produtos |
| Em uma escala de 01 a 03, quão fácil e intuitivo foi gerenciar produtos, realizando operações como adicionar, editar e remover produtos?|
| **Critério de Êxito** | **Usuário consegue adicionar, editar e remover produtos** |
|<li> Usuário |<li> Escala |
| Usuário 01    |  Escala 01 (Com a tabela de produtos vazia após o cadastro, usuário clicou em “Pesquisar” na intenção de popular a tabela. ) |
| Usuário 02    |  Escala 02 (Usuário conseguiu fazer todas as operações no gerenciamento de produtos sem dificuldade.|


| Caso de Teste    | CT-05 - Acessar registros de entradas e saídas |
|:---|:---|
| Requisitos Associados                    | RF-05  Acesso aos registros de entrada e saída |
| Em uma escala de 01 a 03, quão fácil e intuitivo foi acessar os registros de entradas e saídas de produtos?|
| **Critério de Êxito** | **Usuário consegue visualizar o histórico de entradas/saídas de produtos** |
|<li> Usuário |<li> Escala |
| Usuário 01     |  Escala 01 (Usuário visualizou com facilidade os dados de entrada e saída, porém não há um relatório que apresente as duas informações ao mesmo tempo para um mesmo produto.) |
| Usuário 02     |  Escala 01 (O mesmo caso do Usuário 01) |

| Caso de Teste    | CT-06 - Acessar o relatório de estoque mínimo |
|:---|:---|
| Requisitos Associados                    | RF-05  Acesso ao relatório de estoque mínimo|
| Em uma escala de 01 a 03, quão fácil e intuitivo foi acessar os registros de entradas e saídas de produtos?|
| **Critério de Êxito** | **Usuário consegue acessar o relatório de estoque mínimo** |
|<li> Usuário |<li> Escala |
| Usuário 01     |  Escala 01 (Usuário visualizou com facilidade os dados do relatório.) |
| Usuário 02     |  Escala 01 (O mesmo caso do Usuário 01) |

| Caso de Teste    | CT-7 - Consultar a quantidade de produtos em estoque |
|:---|:---|
| Requisitos Associados                    | RF-05  Acesso ao relatório de estoque mínimo|
| Em uma escala de 01 a 03, quão fácil e intuitivo foi visualizar a quantidade atual de cada produtos?|
| **Critério de Êxito** | **Usuário consegue visualizar a quantidade atual de produtos** |
|<li> Usuário |<li> Escala |
| Usuário 01     |  Escala 02 (Usuário visualizou a quantidade atual dos produtos sem diiculdae.) |
| Usuário 02     |  Escala 02 (Usuário visualizou a quantidade atual dos produtos sem dificulade) |



 **Constatação final**  
O teste indicou alguns problemas de usabilidade que podem que dificultar o uso do sistema, ou fazer com que o usuário desista de utiliza-lo:
<ol>
<li>O primeiro deles, após o cadastro, o sistema deveria fazer login automático, ou avisar o usuário para fazer o login com os dados cadastrados. </li>
<li>Os usuários não sabiam o que fazer após realizarem o login. O sistema deveria redirecionar automaticamente para a página de produtos após o login bem-sucedido.</li>
<li>A página inicial deveria esconder os botões “Cadastre-se” e “Login” quando o usuár<io estiver logado</li>
<li>Na página de cadastro de produtos, Os usuários tentaram cadastrar o preço com centavos separados por vírgula. O campo preço não aceita vírgula para os centavos. Não há mensagem para informar o usuário de que deve utilizar ponto. </li>
<li>A mensagem de erro do preço está em está em inglês.</li>
<li>Também na página de cadastro, o texto dos  placeholders não desaparece quando o usuário clica no campo do formulário, atrapalhando a digitação. Um usuário tentou cadastrar um item de Saúde, utilizando o placeholder “Farmácia União”.</li>
<li>Os usuários tiveram dificuldade para localizar item no campo Categoria. O sistema deve ordenar os itens do campo Categoria em ordem alfabética.</li>
<li>Ao deixar de selecionar o valor para fornecedor, os usuários ficaram sem saber porque o formulário não era submetido. Fig.8
Falta mensagem de erro para o campo “Fornecedor” vazio.</li>
<li>Ao colocar um preço com centavos (utilizando o ponto) o sistema retira o ponto e produz um número inteiro maior. Ex.: 3.40 => R$ 340,00</li>
<li>Ao aceitar a adição de um produto com quantidade 0, o sistema inclui uma entrada com essa quantidade.</li>
<li>Adicionar uma nova entrada de produto, o formulário aceita 0 e valores negativos no campo quantidade. Não há mensagem de erro nem bloqueio do envio.</li>
</ol>

A resolução desses problemas será incluída numa nova versão do sistema, quando serão feitos novos testes para garantir que foram solucionados.






