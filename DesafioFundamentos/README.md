DesafioFundamentos
===================

Descrição curta
----------------
Aplicativo de console simples que simula um estacionamento (Estacionamento) escrito em C# e direcionado para .NET 8. O programa permite adicionar, listar e remover veículos, calculando o valor do estacionamento com base em um preço inicial e um valor por hora.

Requisitos
----------
- .NET 8 SDK
- IDE que suporte .NET (Visual Studio 2022/2024/2026, VS Code, etc.)

Compilar e executar
-------------------
Na pasta do projeto (DesafioFundamentos):

- Usando o CLI do dotnet:
  - dotnet build
  - dotnet run --project DesafioFundamentos.csproj

- Usando o Visual Studio:
  - Abra DesafioFundamentos.sln e execute o projeto.

Como funciona / Uso
-------------------
Ao iniciar o programa, ele solicita dois valores:
- Preço Inicial (valor fixo de entrada)
- Preço por Hora (valor cobrado por hora)

Em seguida, é exibido um menu simples (prompts em português):
1 - Adicionar veículos (pergunta quantos e, para cada um, solicita placa, modelo, marca e cor)
2 - Remover veículo (pergunta a placa e as horas estacionadas; exibe o preço total e remove o veículo)
3 - Listar veículos (exibe placa, modelo, marca e cor)
4 - Encerrar

Exemplo de sessão
-----------------
- Entrada preço inicial: 5
- Entrada preço por hora: 2
- Escolha 1 e adicione um veículo com placa ABC1234, modelo Fusca, marca VW, cor Azul
- Escolha 3 para listar veículos
- Escolha 2 e informe placa ABC1234 e horas 3 -> preço = 5 + 2*3 = 11

Estrutura do projeto
--------------------
- DesafioFundamentos/Program.cs                   - Entrada do programa e loop do menu
- DesafioFundamentos/Entities/Estacionamento.cs   - Lógica de gerenciamento do estacionamento (adicionar/listar/remover)
- DesafioFundamentos/Entities/Veiculo.cs          - Modelo de veículo
- DesafioFundamentos.sln                          - Arquivo de solução

Comportamentos conhecidos / Observações
---------------------------------------
- Mensagens e prompts estão em Português (pt-BR).
- Comparação de placas é feita sem diferenciar maiúsculas/minúsculas (as entradas são normalizadas para maiúsculas).
- Validação de entrada é mínima; entradas inválidas (por exemplo, texto onde se espera número) podem causar exceções.

Sugestões de melhoria
---------------------
- Adicionar validação de entrada (TryParse) e mensagens de erro amigáveis.
- Persistir os dados em arquivo ou banco de dados para manter veículos entre execuções.
- Melhorar a usabilidade do menu e adicionar suporte a internacionalização (ex.: modo inglês).
- Adicionar testes automatizados para a classe Estacionamento.

Licença
-------
Nenhuma licença especificada. Adicione uma se necessário.
