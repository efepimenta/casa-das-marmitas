/****** Object:  Table [dbo].[Contas]    Script Date: 10/16/2016 17:00:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Contas](
	[idConstas] [int] NOT NULL,
	[valorConta] [decimal](6, 2) NOT NULL,
	[dataVencConta] [date] NOT NULL,
	[statusConta] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idConstas] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 10/16/2016 17:00:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cliente](
	[idCliente] [int] NOT NULL,
	[nomeCliente] [varchar](30) NOT NULL,
	[telCliente] [varchar](11) NOT NULL,
	[dNascCliente] [date] NULL,
	[paisCliente] [varchar](20) NULL,
	[ufCliente] [char](2) NOT NULL,
	[cidadeCliente] [varchar](20) NOT NULL,
	[bairroCliente] [varchar](20) NOT NULL,
	[lograCliente] [varchar](20) NOT NULL,
	[numECliente] [varchar](10) NULL,
	[complCliente] [varchar](30) NULL,
	[referCliente] [varchar](30) NULL,
	[emailCliente] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Empresa]    Script Date: 10/16/2016 17:00:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empresa](
	[idEmpresa] [int] NOT NULL,
	[nomeEmpresa] [varchar](30) NOT NULL,
	[cnpjEmpresa] [int] NOT NULL,
	[paisEmpresa] [varchar](20) NOT NULL,
	[ufEmpresa] [char](2) NOT NULL,
	[cidadeEmpresa] [varchar](20) NOT NULL,
	[bairroEmpresa] [varchar](20) NOT NULL,
	[lograEmpresa] [varchar](20) NOT NULL,
	[numEEmpresa] [varchar](10) NOT NULL,
	[complEmpresa] [varchar](30) NULL,
	[referEmpresa] [varchar](30) NULL,
	[telEmpresa] [varchar](10) NOT NULL,
	[emailEmpresa] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[idEmpresa] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [unq_cnpEmpresa] UNIQUE NONCLUSTERED 
(
	[cnpjEmpresa] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Produto]    Script Date: 10/16/2016 17:00:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Produto](
	[idProduto] [int] NOT NULL,
	[nomeProduto] [varchar](20) NOT NULL,
	[descricaoProduto] [varchar](50) NOT NULL,
	[tamanhoProduto] [varchar](10) NOT NULL,
	[precoProduto] [decimal](3, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idProduto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Pedido]    Script Date: 10/16/2016 17:00:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pedido](
	[idPedido] [int] NOT NULL,
	[qtdPedido] [int] NOT NULL,
	[tamPedido] [varchar](30) NOT NULL,
	[idProduto] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idPedido] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Funcionario]    Script Date: 10/16/2016 17:00:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Funcionario](
	[idFuncionario] [int] NOT NULL,
	[nomeFuncionario] [varchar](30) NOT NULL,
	[idEmpresa] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idFuncionario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Entregador]    Script Date: 10/16/2016 17:00:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Entregador](
	[idEntregador] [int] NOT NULL,
	[nomeEntregador] [varchar](30) NOT NULL,
	[cpfEntregador] [int] NOT NULL,
	[rgEntregador] [int] NOT NULL,
	[celEntregador] [varchar](11) NOT NULL,
	[empresaEntregador] [varchar](30) NOT NULL,
	[idEmpresa] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idEntregador] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [unq_cpfEntregador] UNIQUE NONCLUSTERED 
(
	[cpfEntregador] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [unq_rgEntregador] UNIQUE NONCLUSTERED 
(
	[rgEntregador] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ContasReceber]    Script Date: 10/16/2016 17:00:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContasReceber](
	[idCliente] [int] NULL,
	[dataRecContasReceber] [date] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContasPagar]    Script Date: 10/16/2016 17:00:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContasPagar](
	[idEntregador] [int] NULL,
	[dataPagContasPagar] [date] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_idEntregador]    Script Date: 10/16/2016 17:00:05 ******/
ALTER TABLE [dbo].[ContasPagar]  WITH CHECK ADD  CONSTRAINT [FK_idEntregador] FOREIGN KEY([idEntregador])
REFERENCES [dbo].[Entregador] ([idEntregador])
GO
ALTER TABLE [dbo].[ContasPagar] CHECK CONSTRAINT [FK_idEntregador]
GO
/****** Object:  ForeignKey [fk_idCliente]    Script Date: 10/16/2016 17:00:05 ******/
ALTER TABLE [dbo].[ContasReceber]  WITH CHECK ADD  CONSTRAINT [fk_idCliente] FOREIGN KEY([idCliente])
REFERENCES [dbo].[Cliente] ([idCliente])
GO
ALTER TABLE [dbo].[ContasReceber] CHECK CONSTRAINT [fk_idCliente]
GO
/****** Object:  ForeignKey [fk_idEmpresa]    Script Date: 10/16/2016 17:00:05 ******/
ALTER TABLE [dbo].[Entregador]  WITH CHECK ADD  CONSTRAINT [fk_idEmpresa] FOREIGN KEY([idEmpresa])
REFERENCES [dbo].[Empresa] ([idEmpresa])
GO
ALTER TABLE [dbo].[Entregador] CHECK CONSTRAINT [fk_idEmpresa]
GO
/****** Object:  ForeignKey [FK_idFunEmpresa]    Script Date: 10/16/2016 17:00:05 ******/
ALTER TABLE [dbo].[Funcionario]  WITH CHECK ADD  CONSTRAINT [FK_idFunEmpresa] FOREIGN KEY([idEmpresa])
REFERENCES [dbo].[Empresa] ([idEmpresa])
GO
ALTER TABLE [dbo].[Funcionario] CHECK CONSTRAINT [FK_idFunEmpresa]
GO
/****** Object:  ForeignKey [FK_idProduto]    Script Date: 10/16/2016 17:00:05 ******/
ALTER TABLE [dbo].[Pedido]  WITH CHECK ADD  CONSTRAINT [FK_idProduto] FOREIGN KEY([idProduto])
REFERENCES [dbo].[Produto] ([idProduto])
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [FK_idProduto]
GO
