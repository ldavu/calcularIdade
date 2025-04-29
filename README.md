# 📋 Descrição do Projeto

Este projeto é um programa em C# que realiza a coleta de **anos de nascimento** dos usuários, **calcula as idades** e **gera um relatório final** com todos os dados informados.

O sistema inclui **tratamento de erros**, **validações de entrada** e **controle de fluxo** para garantir uma interação segura e eficiente com o usuário.

---

# 🛠️ Funcionalidades

- 📥 Solicita o ano de nascimento do usuário.
- 🔎 Valida se a entrada é um número válido e dentro de uma faixa aceitável (a partir de 1900 e diferente de 2025).
- 🧮 Calcula a idade considerando o ano de 2025.
- 🗂️ Armazena os anos de nascimento e idades informadas.
- 🔄 Permite que o usuário decida se deseja continuar informando dados (tratamento para entradas "S"/"N").
- 📊 Ao final, exibe um resumo completo de todos os anos e idades registrados.

---

# ⚙️ Como Funciona

1. O programa inicia perguntando o **ano de nascimento**.
2. Faz validações:
   - Campo vazio;
   - Entrada não numérica;
   - Ano fora do intervalo aceito.
3. Calcula a idade (`2025 - ano de nascimento`).
4. Armazena o ano e a idade em listas.
5. Pergunta se o usuário deseja continuar:
   - **S** ou **SIM**: continua o programa;
   - **N** ou **NÃO/NAO**: encerra o programa e exibe o relatório.
6. Ao final:
   - Limpa a tela.
   - Exibe o número total de consultas feitas.
   - Lista todos os anos e idades registrados.

---

# 🧹 Tecnologias Utilizadas

- Linguagem: **C#**
- Estruturas:
  - `while`
  - `if/else`
  - `List<int>`
  - `TryParse`
  - `Console.Clear()`

---

# 📈 Exemplo de Saída Final

```text
Programa Encerrado!
Número de requisições ao todo: 3.

[Query 1] Ano: 2000 - Idade: 25
[Query 2] Ano: 1995 - Idade: 30
[Query 3] Ano: 2010 - Idade: 15
