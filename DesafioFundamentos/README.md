# 🚗 Desafio Fundamentos: Sistema de Estacionamento

![.NET Version](https://shields.io)
![Language](https://shields.io)
![Type](https://shields.io)

Uma aplicação de console simples e interativa desenvolvida em **C#** e direcionada para o **.NET 8**. O sistema simula o gerenciamento de um estacionamento, controlando de forma dinâmica a entrada, saída e cobrança de veículos.

---

## 📋 Descrição do Projeto

O programa gerencia o fluxo de veículos de um estacionamento calculando o valor das estadias com base em uma fórmula simples:

Total = Preço Inicial + (Preço por Hora × Horas Estacionadas)

### ✨ Funcionalidades
* **Configuração de Tarifas:** Define os valores base na inicialização do sistema.
* **Cadastro de Veículos:** Permite adicionar múltiplos veículos detalhando Placa, Modelo, Marca e Cor.
* **Listagem Dinâmica:** Exibe todos os veículos atualmente estacionados.
* **Encerramento e Cobrança:** Remove o veículo pela placa, calcula o valor final da estadia e exibe o recibo no terminal.

---

## 🛠️ Requisitos e Tecnologias

Antes de rodar a aplicação, certifique-se de ter instalado:
* [SDK do .NET 8.0](https://microsoft.com)
* Uma IDE ou editor compatível (como [Visual Studio](https://microsoft.com), [VS Code](https://visualstudio.com) ou JetBrains Rider)

---

## 🚀 Como Executar a Aplicação

### Via Linha de Comando (CLI do .NET)
Abra o seu terminal na pasta raiz do projeto (onde está o arquivo `.sln`) e execute os comandos:

```bash
dotnet build
dotnet run --project DesafioFundamentos/DesafioFundamentos.csproj
```

### Via Visual Studio
1. Dê um duplo clique no arquivo `DesafioFundamentos.sln` para abrir a solução.
2. Certifique-se de que o projeto `DesafioFundamentos` está configurado como projeto de inicialização.
3. Clique no botão **Run / Start (F5)** na barra de ferramentas superior.

---

## 🕹️ Como Funciona (Fluxo de Uso)

1. **Configuração Inicial:** O sistema solicitará o **Preço Inicial** e o **Preço por Hora**.
2. **Menu Principal:** Um menu interativo com os seguintes comandos será exibido:

| Opção | Ação | Descrição |
| :---: | :--- | :--- |
| **1** | Adicionar Veículo | Pergunta a quantidade de veículos e solicita os dados (Placa, Modelo, Marca, Cor). |
| **2** | Remover Veículo | Solicita a placa do veículo e a quantidade de horas estacionado, gerando a cobrança. |
| **3** | Listar Veículos | Exibe uma lista formatada com todos os veículos estacionados no momento. |
| **4** | Encerrar | Fecha a execução do aplicativo de console. |

### 📝 Exemplo Prático de Sessão
```text
Digite o preço inicial: 5
Digite o preço por hora: 2

--- MENU ---
1 - Adicionar veículo
2 - Remover veículo
3 - Listar veículos
4 - Encerrar
Escolha uma opção: 1

[Cadastro] Placa: ABC1234 | Modelo: Fusca | Marca: VW | Cor: Azul

Escolha uma opção: 2
Digite a placa para remover: ABC1234
Digite a quantidade de horas que o veículo permaneceu estacionado: 3

> O veículo ABC1234 foi removido e o preço total foi de: R$ 11,00 (5 + 2 * 3)
```

---

## 📁 Estrutura do Projeto

O código está organizado seguindo boas práticas de separação de responsabilidades (Entidades e Execução):

```text
📂 DesafioFundamentos/
│
├── 📂 DesafioFundamentos/
│   ├── 📂 Entities/
│   │   ├── Estacionamento.cs  # Contém as regras de negócio (Add/Remover/Listar)
│   │   └── Veiculo.cs         # Modelo estrutural (propriedades do veículo)
│   └── Program.cs             # Arquivo de entrada principal e loop do menu
│
└── DesafioFundamentos.sln     # Arquivo de solução para vinculação de IDEs
```

---

## 🔍 Comportamentos Conhecidos & Regras de Validação

* **Idioma:** Interface e prompts de comando configurados totalmente em Português (`pt-BR`).
* **Normalização:** A busca e comparação de placas ignora diferenças entre letras maiúsculas e minúsculas (*Case-Insensitive*).
* **Tratamento de Dados:** As entradas de dados possuem validações simplificadas; dados inválidos (como letras digitadas em campos numéricos) podem interromper a execução do console.

---

## 💡 Próximos Passos & Sugestões de Melhorias

Para expandir o projeto e usá-lo como um diferencial técnico no portfólio, considere implementar:
- [ ] **Robustez de Input:** Trocar as leituras numéricas simples por métodos defensivos utilizando `int.TryParse` para evitar exceções inesperadas.
- [ ] **Persistência de Dados:** Implementar gravação dos dados em arquivos `.json`, `.txt` ou Banco de Dados (SQLite/SQL Server via EF Core) para manter o estado do estacionamento salvo ao fechar o programa.
- [ ] **Testes de Software:** Criar um projeto paralelo `DesafioFundamentos.Tests` usando **xUnit** ou **NUnit** para automatizar os testes das regras da classe `Estacionamento`.
- [ ] **Internacionalização (i18n):** Adaptar o sistema para dar suporte a múltiplos idiomas de maneira dinâmica.
