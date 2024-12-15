# StructureWebAPI

## PT 1
Instalar EntityFrameworkCore no gerenciador de pacotes NuGet
Instalar EntityFrameworkCore.SqlServer
Instalar EntityFrameworkCore.Design para criar migrations(criam o banco de dados a partir do código)
Instalar EntityFrameworkCore.Tools



  1. Criar pasta Data
  2. Em "Data" -> Criar classe AppDbContext : DbContext 
  3. Configurar appsettings
  4. “add-migration NomeDaMigration” → cria a migration para criar tabelas no banco de dados e até criar o mesmo.
  5. “update-database” → executa a migration anterior.

## PT 2
1. Usar o Design Pattern chamado “Repository Pattern” para não criar controllers enormes como criei no TCC.

2. Então criar pasta RepostiryPattern → ter serviços e interfaces. Controller conecta na interface que tem metodos desenvolvidos no services.

**Services** → Criar pasta service e dentro criar pasta para cada tabela no banco e uma classe service de tal.

1. Dentro de cada classe service, deve-se implementar os métodos da interface.

**Interfaces** → Criar uma interface para cada service e vincula-los no Program.cs a partir do AddScoped

1. Definir os métodos que normalmente eu defino no controller

**ResponseModel** → Criar model de resposta padrão para as requisições, declarando que é uma classe genérica, ou seja, pode receber dados de qualquer outra classe.

**Controller** → criar instancia da interface que representa o model especifico para o controller.  E criar os endpoints que apenas chamam os métodos da interface.

