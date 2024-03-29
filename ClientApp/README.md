# B3

Este Projeto foi inicialmente construido com a versão 12.0.2 do Angular CLI, e backend .NET FRAMEWORK 4.7.2 com o propósito de testar cálculos baseados em um valor inicial e quantidade de meses.

## Ambiente de Desenvolvimento

Antes de testar, certifique-se de possuir o NodeJS (nodejs.org) devidamente instalado.
Pode ser necessário rodar o comando "npm install" no diretório raiz da aplicação Angular (/ClientApp).

***IMPORTANTE***
Para que o projeto rode corretamente, é necessário configurar para que o projeto em Angular e o projeto em .NET Framework 4.7.2 iniciem juntos.
Para isso, basta clicar com o botão direito na "Solution 'ClientApp'" > Properties > Startup Project > Marque a opção "Multiple startup projects" e em seguida, selecione a opção "Start" na coluna "Action" para os projetos "B3" e "ClientApp"
*A falta desta configuração acarretará no não-funcionamento da aplicação.

Este software foi desenvolvido utilizando a IDE Visual Studio Enterprise. Recomenda-se utilizar a mesma IDE ou equivalente para maior chance de sucesso nos testes.
A porta utilizada para o ambiente AngularCLI é "http://localhost:4200/", enquanto para chamadas REST (.NET CORE), utiliza-se o "https://localhost:44309/"
Também é possível testar, servindo-se do comando `ng serve` no propósito de testes em um ambiente DEV.
Para rodar os testes unitários do Angular, por favor rode o comando "ng test", certificando-se de que esteja na pasta raiz (/ClientApp)

## Estruturas desenvolvidas
Considerando que o teste será realizado utilizando a IDE Visual Studio/PRO/Enterprise/Community, basta pressionar "F5" ou clicar no "PLAY" da IDE para que a aplicação seja iniciada.
No primeiro momento, aparecerá uma tela de "Loading" que redicionará a aplicação para o sistema de rotas do AngularCLI. Neste ponto, basta esperar até que a aplicação carregue completamente.

A interface carregada contempla dois inputs e dois botões:
1. Informar o valor inicial do investimento;
2. informar a quantidade desejada de meses para uma previsão de redimento baseado no valor/tempo considerando as regras para meses: > 1 e <= 360 e para valores: mínimo R$ 1,00 e máximo R$ 9.999.999.999,99;
3. Botão "Limpar", que reseta as informações previamente preenchidas nos inputs para um repreenchimento mas ágil;
4. Botão "Calcular", que deve ser acionado assim que os valores dos campos estiverem preenchidos conforme prestensão do usuário;
 
As validações de inputs consistem em checar campos vazios, nulos e numeros positivos, sempre informando ao usuário caso haja alguma intercorrência fora do esperado pelo sistema.
As validações de backend consistem em validar valores, impostos e rendimento

O resultado final esperado é devolver à tela para que o usuário visualize as seguintes informações calculadas:
 - Valor Aplicado;
 - Valor Bruto (Valor aplicado + rendimentos)
 - Valor Líquido (Valor Aplicado + (rendimentos - imposto))
 - Imposto (definido conforme documentação -> baseado no tempo informado)
 - Rendimento (base de cálculo informada na documentação)

 ## Informações Relevantes

 Para injeção de dependencia, foi utilizada a Library "Unity";
 IMPORTANTE ** O primeiro calculo realizado na aplicação, tende a demorar alguns segundos. Os demais cálculos são imediatos. **

 Devido às aplicações AngularCLI e .NET CORE estarem dentro da mesma solução, foi necessário fazer uma configuração no CORS para que o domínio "http://localhost:4200/" se comunique corretamente com "http://localhost:44309/".
 Por ser uma aplicação de teste, o quesito segurança não está sendo coniderado neste desenvolvimento inicial: o CORS aceita qualquer requisição (independente da origem), desde que respeite os critérios da validação.
 
 Para auxiliar no desenvolvimento, foi desenvolvido um diretório 'helper' (aplicação angular) que contempla métodos que poderão ser compartilhados por toda a aplicação front-end
 O sistema busca respeitar os conceitos do Pattern SOLID, portanto há segmentação para o conceito de responsabilidade unica, reaproveitamento de código, ajustes de inejção de dependencia (config: program.cs) e inversão de controle (para promover desacoplamentos) com uso de interfaces.

 ** TESTES ** Embora os testes unitários do Angular apareçam na aplicação de Teste NUNIT, eles devem ser feitos pelo comando "NG TEST", pois:
 1. Se a aplicação NÃO ESTIVER rodando, o Angular não conseguirá processar estes testes.
 2. Se a aplicação ESTIVER rodando, não será possível rodar os testes ANGULAR nesta aplicação de teste (NUNIT)
