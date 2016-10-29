CREATE TABLE [dbo].[Pessoa] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [telefone]     VARCHAR (15)  NOT NULL,
    [dtNascimento] DATE          NOT NULL,
    [pais]         VARCHAR (50)  DEFAULT ('Brasil') NOT NULL,
    [uf]           CHAR (2)      NOT NULL,
    [cidade]       VARCHAR (150) NOT NULL,
    [bairro]       VARCHAR (100) NOT NULL,
    [endereco]     VARCHAR (150) NOT NULL,
    [num]          INT           NOT NULL,
    [complemento]  VARCHAR (100) NULL,
    [referencia]   VARCHAR (300) NULL,
    [email]        VARCHAR (120) NOT NULL,
    PRIMARY KEY ([Id] ASC)
);

CREATE TABLE [dbo].[Cliente] (
    [id]       INT           IDENTITY (1, 1) NOT NULL,
    [nome]     VARCHAR (150) NOT NULL,
    [cpf]      VARCHAR (20)  NOT NULL,
    [idPessoa] INT           NOT NULL,
    PRIMARY KEY ([id] ASC),
    CONSTRAINT [fk_Cliente] FOREIGN KEY ([idPessoa]) REFERENCES [dbo].[Pessoa] ([Id])
);

CREATE TABLE [dbo].[Empresa] (
    [id]       INT           IDENTITY (1, 1) NOT NULL,
    [nome]     VARCHAR (150) NOT NULL,
    [cnpj]     VARCHAR (20)  NOT NULL,
    [idPessoa] INT           NOT NULL,
    PRIMARY KEY ([id] ASC),
    CONSTRAINT [unq_Empresa] UNIQUE NON([cnpj] ASC),
    CONSTRAINT [fk_Empresa] FOREIGN KEY ([idPessoa]) REFERENCES [dbo].[Pessoa] ([Id])
);

CREATE TABLE [dbo].[Funcionario] (
    [id]       INT           IDENTITY (1, 1) NOT NULL,
    [nome]     VARCHAR (150) NOT NULL,
    [cpf]      VARCHAR (20)  NOT NULL,
    [idPessoa] INT           NOT NULL,
    PRIMARY KEY ([id] ASC),
    CONSTRAINT [FK_Funcionario] FOREIGN KEY ([idPessoa]) REFERENCES [dbo].[Pessoa] ([Id])
);

CREATE TABLE [dbo].[Entregador] (
    [id]        INT          IDENTITY (1, 1) NOT NULL,
    [nome]      VARCHAR (30) NOT NULL,
    [cpf]       VARCHAR (20) NOT NULL,
    [rg]        VARCHAR (20) NOT NULL,
    [celular]   VARCHAR (15) NOT NULL,
    [idEmpresa] INT          NOT NULL,
    PRIMARY KEY ([id] ASC),
    CONSTRAINT [unq_cpfEntregador] UNIQUE NON([cpf] ASC),
    CONSTRAINT [unq_rgEntregador] UNIQUE NON([rg] ASC),
    CONSTRAINT [fk_Etregador] FOREIGN KEY ([idEmpresa]) REFERENCES [dbo].[Empresa] ([id])
);

CREATE TABLE [dbo].[Produto] (
    [id]        INT            IDENTITY (1, 1) NOT NULL,
    [nome]      VARCHAR (20)   NOT NULL,
    [descricao] VARCHAR (50)   NOT NULL,
    [preco]     DECIMAL (3, 2) NOT NULL,
    PRIMARY KEY ([id] ASC)
);

CREATE TABLE [dbo].[Pedido] (
    [id]         INT          IDENTITY (1, 1) NOT NULL,
    [quantidade] INT          NOT NULL,
    [tamanho]    VARCHAR (30) NOT NULL,
    [idProduto]  INT          NOT NULL,
    [status]     VARCHAR (10) NOT NULL,
    PRIMARY KEY ([id] ASC)
);

CREATE TABLE [dbo].[Produto_Pedido	] (
    [Id]      INT IDENTITY (1, 1) NOT NULL,
    [Pedido]  INT NOT NULL,
    [Produto] INT NOT NULL,
    PRIMARY KEY ([Id] ASC),
    CONSTRAINT [FK_Pedido] FOREIGN KEY ([Pedido]) REFERENCES [dbo].[Pedido] ([id]),
    CONSTRAINT [FK_Produto] FOREIGN KEY ([Produto]) REFERENCES [dbo].[Produto] ([id])
);

CREATE TABLE [dbo].[Contas] (
    [id]         INT            IDENTITY (1, 1) NOT NULL,
    [valor]      DECIMAL (6, 2) NOT NULL,
    [dataVencto] DATE           NOT NULL,
    [status]     VARCHAR (10)   NOT NULL,
    PRIMARY KEY ([id] ASC)
);

CREATE TABLE [dbo].[ContasPagar] (
    [id]            INT  IDENTITY (1, 1) NOT NULL,
    [idEntregador]  INT  NOT NULL,
    [dataPagamento] DATE NOT NULL,
    [idConta]       INT  NOT NULL,
    CONSTRAINT [PK_ContasPagar] PRIMARY KEY ([id] ASC),
    CONSTRAINT [fk_ContaPagar] FOREIGN KEY ([idConta]) REFERENCES [dbo].[Contas] ([id]),
    CONSTRAINT [fk_EntreContaPagar] FOREIGN KEY ([idEntregador]) REFERENCES [dbo].[Entregador] ([id])
);

CREATE TABLE [dbo].[ContasReceber] (
    [id]              INT  IDENTITY (1, 1) NOT NULL,
    [idCliente]       INT  NOT NULL,
    [dataRecebimento] DATE NOT NULL,
    [idConta]         INT  NOT NULL,
    CONSTRAINT [PK_ContasReceber] PRIMARY KEY ([id] ASC),
    CONSTRAINT [fk_ContaReceber] FOREIGN KEY ([idConta]) REFERENCES [dbo].[Contas] ([id]),
    CONSTRAINT [fk_CliContaPagar] FOREIGN KEY ([idCliente]) REFERENCES [dbo].[Cliente] ([id])
);