# Sistema de Estacionamento

Este é um sistema de gerenciamento de estacionamento desenvolvido em **C#** como um projeto de Console Application. Ele permite gerenciar veículos estacionados, realizar operações como adicionar, remover veículos e listar os veículos presentes no estacionamento.

## Funcionalidades

- **Adicionar veículo:** Registra um novo veículo no sistema.
- **Remover veículo:** Remove um veículo e calcula o valor a ser cobrado com base no tempo estacionado.
- **Listar veículos:** Exibe todos os veículos atualmente estacionados.

## Como executar o projeto

1. Certifique-se de que você possui o **.NET SDK** instalado. Caso não tenha, baixe e instale a partir de [https://dotnet.microsoft.com/](https://dotnet.microsoft.com/).

2. Clone este repositório em sua máquina local:
   ```bash
   git clone https://github.com/matheusphb/SistemaEstacionamento.git
   cd SistemaEstacionamento


3. Compile e execute o projeto:
   ```bash
   dotnet run
   ```

## Estrutura do Código

O projeto contém as seguintes partes principais:

1. **Menu Principal:** Exibe opções para o usuário interagir com o sistema.
2. **Gerenciamento de Veículos:** Funções para adicionar, remover e listar os veículos.
3. **Cálculo de Cobrança:** Aplica um valor fixo e um valor por hora estacionada.

## Exemplo de Uso

Ao executar o programa, o menu principal será exibido:

```
Bem-vindo ao Sistema de Estacionamento!
Escolha uma opção:
1. Adicionar veículo
2. Remover veículo
3. Listar veículos
4. Sair
```

- **Opção 1 (Adicionar veículo):** Informe a placa do veículo.
- **Opção 2 (Remover veículo):** Informe a placa e veja o valor a ser cobrado.
- **Opção 3 (Listar veículos):** Exibe uma lista de todos os veículos estacionados.
- **Opção 4 (Sair):** Encerra o programa.

## Tecnologias Utilizadas

- **Linguagem:** C#
- **Framework:** .NET

## Contribuindo

Sinta-se à vontade para contribuir com melhorias ou novas funcionalidades. Para isso:

1. Faça um fork do projeto.
2. Crie uma branch para sua feature ou correção:
   ```bash
   git checkout -b minha-feature
   ```
3. Realize suas alterações e faça o commit:
   ```bash
   git commit -m "Minha nova feature"
   ```
4. Envie para o repositório remoto:
   ```bash
   git push origin minha-feature
   ```
5. Abra um Pull Request.

## Licença

Este projeto está licenciado sob a **MIT License**. Para mais detalhes, consulte o arquivo [LICENSE](LICENSE).

---

Desenvolvido com 💙 por [Matheus PHB](https://github.com/matheusphb).
```

---

### **Como adicionar ao seu repositório**
1. Crie um arquivo chamado `README.md` no diretório raiz do seu projeto.
2. Cole o conteúdo acima no arquivo.
3. Adicione e envie o arquivo ao repositório:
   ```bash
   git add README.md
   git commit -m "Adiciona README ao projeto"
   git push origin main
   ``` 
