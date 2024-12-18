# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto". 

Por exemplo:
 
| **Caso de Teste** 	| **CT-01 – Cadastrar perfil** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - O usuário deve poder criar sua conta na aplicação. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://stockup.com/src/index.html<br> - Clicar em "Criar conta" <br> - Preencher os campos obrigatórios (e-mail, nome, senha, confirmação de senha) <br> - Clicar em "Continuar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-02 – Efetuar login	|
|Requisito Associado | RF-002	- O usuário registrado deve poder fazer login utilizando suas credenciais (e-mail e senha). |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://stockup.com/src/index.html<br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" |
|Critério de Êxito | - O login foi realizado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-03 – Alterar dados do usuário	|
|Requisito Associado | RF-003	- O usuário deve poder gerenciar seus dados pessoais. |
| Objetivo do Teste 	| Verificar se o usuário consegue alterar seus dados. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://stockup.com/src/index.html<br> - Clicar no botão de "Perfil" <br> - Alterar os dados que desejar <br> - Clicar em "Salvar" |
|Critério de Êxito | - Os dados foram alterados com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-04 – Buscar dados do usuário	|
|Requisito Associado | RF-003	- O usuário deve poder gerenciar seus dados pessoais. |
| Objetivo do Teste 	| Verificar se o usuário consegue ver seus dados. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://stockup.com/src/index.html<br> - Clicar no botão de "Perfil" |
|Critério de Êxito | - Os dados foram renderizados com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-05 – Deletar conta	|
|Requisito Associado | RF-003	- O usuário deve poder gerenciar seus dados pessoais. |
| Objetivo do Teste 	| Verificar se o usuário consegue ver seus dados. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://stockup.com/src/index.html<br> - Clicar no botão de "Perfil" <br> - Clicar em "Deletar conta"|
|Critério de Êxito | - A conta do usuário foi deletada com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-06 – Adicionar produto	|
|Requisito Associado | RF-004	- O usuário deve poder gerenciar seus produtos. |
| Objetivo do Teste 	| Verificar se o usuário consegue adicionar produtos ao estoque. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://stockup.com/src/index.html<br> - Clicar no botão de "Criar" <br> - Preencher o campo de nome, quantidade, preço <br> - Clicar em "Continuar"|
|Critério de Êxito | - As informações de produtos foram renderizadas com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-07 – Listar produtos	|
|Requisito Associado | RF-004	- O usuário deve poder gerenciar seus produtos. |
| Objetivo do Teste 	| Verificar se o usuário consegue adicionar produtos ao estoque. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://stockup.com/src/index.html<br> |
|Critério de Êxito | - As informações de produtos foram renderizadas com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-08 – Atualizar produtos	|
|Requisito Associado | RF-004	- O usuário deve poder gerenciar seus produtos. |
| Objetivo do Teste 	| Verificar se o usuário consegue atualizar produtos do estoque. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://stockup.com/src/index.html<br> - Clicar no botão de "Editar" <br> - Preencher o campo de nome, quantidade, preço <br> - Clicar em "Salvar"|
|Critério de Êxito | - As informações de produtos foram atualizados com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-09 – Excluir produtos	|
|Requisito Associado | RF-004	- O usuário deve poder deletar seus produtos. |
| Objetivo do Teste 	| Verificar se o usuário consegue deletar produtos do estoque. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://stockup.com/src/index.html<br> - Clicar no botão de "Deletar"|
|Critério de Êxito | - As informações de produtos foram deletados com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-10 – Criar entradas	|
|Requisito Associado | RF-005	- O usuário deve poder ter acesso aos registros de entradas. |
| Objetivo do Teste 	| Verificar se a entrada é criada corretamente. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://stockup.com/src/index.html<br> - Clicar no botão de "Adicionar nova entrada" <br> - Preencher o campo de produto e quantidade <br> - Clicar em "Adicionar" |
|Critério de Êxito | - As informações de entradas foram criadas corretamente. |
|  	|  	|
| Caso de Teste 	| CT-11 – Listar entradas	|
|Requisito Associado | RF-005	- O usuário deve poder ter acesso aos registros de entradas. |
| Objetivo do Teste 	| Verificar se as entradas são listadas corretamente. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://stockup.com/src/index.html<br> |
|Critério de Êxito | - As informações de entradas foram listadas corretamente. |
|  	|  	|
| Caso de Teste 	| CT-12 – Editar entrada	|
|Requisito Associado | RF-005	- O usuário deve poder ter acesso aos registros de entradas. |
| Objetivo do Teste 	| Verificar se a entrada é atualizada corretamente. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://stockup.com/src/index.html<br> - Clicar no botão de "Editar" <br> - Preencher o campo de produto e quantidade <br> - Clicar em "Salvar" |
|Critério de Êxito | - A entrada foi atualizada corretamente. |
|  	|  	|
| Caso de Teste 	| CT-13 – Deletar entrada	|
|Requisito Associado | RF-005	- O usuário deve poder ter acesso aos registros de entradas. |
| Objetivo do Teste 	| Verificar se a entrada é deletada corretamente. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://stockup.com/src/index.html<br> - Clicar no botão de "Deletar" <br> - Clicar em "Apagar" |
|Critério de Êxito | - A entrada foi deletada corretamente. |
|  	|  	|
| Caso de Teste 	| CT-14 – Criar saída	|
|Requisito Associado | RF-009	- O usuário deve poder ter acesso aos registros de saídas. |
| Objetivo do Teste 	| Verificar se a saída é criada corretamente. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://stockup.com/src/index.html<br> - Clicar no botão de "Adicionar nova saída" <br> - Preencher o campo de produto e quantidade <br> - Clicar em "Adicionar" |
|Critério de Êxito | - As informações de saídas foram criadas corretamente. |
|  	|  	|
| Caso de Teste 	| CT-15 – Listar saídas	|
|Requisito Associado | RF-009	- O usuário deve poder ter acesso aos registros de saídas. |
| Objetivo do Teste 	| Verificar se a saídas são listadas corretamente. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://stockup.com/src/index.html<br> |
|Critério de Êxito | - As informações de saídas foram listadas corretamente. |
|  	|  	|
| Caso de Teste 	| CT-16 – Editar saída	|
|Requisito Associado | RF-009	- O usuário deve poder ter acesso aos registros de saídas. |
| Objetivo do Teste 	| Verificar se a saída é atualizada corretamente. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://stockup.com/src/index.html<br> - Clicar no botão de "Editar" <br> - Preencher o campo de produto e quantidade <br> - Clicar em "Salvar" |
|Critério de Êxito | - A saída foi atualizada corretamente. |
|  	|  	|
| Caso de Teste 	| CT-17 – Deletar saída	|
|Requisito Associado | RF-009	- O usuário deve poder ter acesso aos registros de saídas. |
| Objetivo do Teste 	| Verificar se a saída é deletada corretamente. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://stockup.com/src/index.html<br> - Clicar no botão de "Deletar" <br> - Clicar em "Apagar" |
|Critério de Êxito | - A saída foi deletada corretamente. |
|  	|  	|
| Caso de Teste 	| CT-18 – Cadastrar fornecedor	|
|Requisito Associado | RF-008	- O sistema deve cadastrar fornecedores, e o relacionar aos produtos. |
| Objetivo do Teste 	| Verificar se o fornecedor é criado corretamente. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://stockup.com/src/index.html<br> - Clicar no botão de "Adicionar nova entrada" <br> - Preencher o campo de produto e quantidade <br> - Clicar em "Adicionar"  <br> - Vá até "Fornecedores"|
|Critério de Êxito | - O fornecedor foi criado corretamente. |
|  	|  	|
| Caso de Teste 	| CT-19 – Relatório de estoque mínimo	|
|Requisito Associado | RF-006	- O usuário deve poder acessar o relatório de estoque mínimo. |
| Objetivo do Teste 	| Verificar se o relatório de estoque mínimo renderizado corretamente. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://stockup.com/src/index.html<br> - Clicar no botão de "Relatório de estoque mínimo"|
|Critério de Êxito | - O relatório de estoque mínimo renderizado corretamente. |

> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
