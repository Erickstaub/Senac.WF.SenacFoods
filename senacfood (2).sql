-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 21/05/2025 às 02:45
-- Versão do servidor: 10.4.24-MariaDB
-- Versão do PHP: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `senacfood`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `cardapio_item`
--

CREATE TABLE `cardapio_item` (
  `ID` int(11) NOT NULL,
  `TITULO` varchar(200) NOT NULL,
  `DESCRIÇÃO` varchar(200) NOT NULL,
  `PRECO` decimal(10,2) NOT NULL,
  `POSSUI_PREPARO` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Despejando dados para a tabela `cardapio_item`
--

INSERT INTO `cardapio_item` (`ID`, `TITULO`, `DESCRIÇÃO`, `PRECO`, `POSSUI_PREPARO`) VALUES
(1, 'Xis Salada', 'Bife 180 Gaucho\r\nAlface Gaucho\r\nTomate Gaucho\r\nQueijo Cheddar\r\nMaionese Gaucha\r\nPão de brioche', '25.00', 1),
(2, 'Coca-Cola Lata 360Ml', 'Coca-Cola Lata 360Ml', '7.00', 0);

-- --------------------------------------------------------

--
-- Estrutura para tabela `comanda`
--

CREATE TABLE `comanda` (
  `ID` int(11) NOT NULL,
  `numero_mesa` int(11) NOT NULL,
  `nome_cliente` varchar(150) NOT NULL,
  `situacao` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Despejando dados para a tabela `comanda`
--

INSERT INTO `comanda` (`ID`, `numero_mesa`, `nome_cliente`, `situacao`) VALUES
(1, 100, 'Joao reidopvp123', 1),
(2, 101, 'natasha ', 1);

-- --------------------------------------------------------

--
-- Estrutura para tabela `comanda_item`
--

CREATE TABLE `comanda_item` (
  `ID` int(11) NOT NULL,
  `cardapio_item_id` int(11) NOT NULL,
  `comanda_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Despejando dados para a tabela `comanda_item`
--

INSERT INTO `comanda_item` (`ID`, `cardapio_item_id`, `comanda_id`) VALUES
(1, 1, 1),
(2, 2, 1);

-- --------------------------------------------------------

--
-- Estrutura para tabela `mesa`
--

CREATE TABLE `mesa` (
  `ID` int(11) NOT NULL,
  `numero_mesa` int(11) NOT NULL,
  `situação_mesa` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Despejando dados para a tabela `mesa`
--

INSERT INTO `mesa` (`ID`, `numero_mesa`, `situação_mesa`) VALUES
(1, 100, 1),
(2, 101, 1),
(3, 102, 0),
(4, 103, 0),
(5, 104, 0),
(6, 105, 0);

-- --------------------------------------------------------

--
-- Estrutura para tabela `pedidio_cozinha`
--

CREATE TABLE `pedidio_cozinha` (
  `ID` int(11) NOT NULL,
  `comanda_id` int(11) NOT NULL,
  `situacao_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura para tabela `pedido_cozinha_item`
--

CREATE TABLE `pedido_cozinha_item` (
  `id` int(11) NOT NULL,
  `pedido_cozinha_id` int(11) NOT NULL,
  `comanda_item_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura para tabela `usuarios`
--

CREATE TABLE `usuarios` (
  `ID` int(11) NOT NULL,
  `NOME` varchar(100) NOT NULL,
  `EMAIL` varchar(100) NOT NULL,
  `SENHA` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Despejando dados para a tabela `usuarios`
--

INSERT INTO `usuarios` (`ID`, `NOME`, `EMAIL`, `SENHA`) VALUES
(1, 'admin', 'admin@admin.com', '123'),
(2, 'Erick Staub', 'erickstaub@gmail.com', '1');

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `cardapio_item`
--
ALTER TABLE `cardapio_item`
  ADD PRIMARY KEY (`ID`);

--
-- Índices de tabela `comanda`
--
ALTER TABLE `comanda`
  ADD PRIMARY KEY (`ID`);

--
-- Índices de tabela `comanda_item`
--
ALTER TABLE `comanda_item`
  ADD PRIMARY KEY (`ID`);

--
-- Índices de tabela `mesa`
--
ALTER TABLE `mesa`
  ADD PRIMARY KEY (`ID`);

--
-- Índices de tabela `pedidio_cozinha`
--
ALTER TABLE `pedidio_cozinha`
  ADD PRIMARY KEY (`ID`);

--
-- Índices de tabela `pedido_cozinha_item`
--
ALTER TABLE `pedido_cozinha_item`
  ADD PRIMARY KEY (`id`);

--
-- Índices de tabela `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `cardapio_item`
--
ALTER TABLE `cardapio_item`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `comanda`
--
ALTER TABLE `comanda`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `comanda_item`
--
ALTER TABLE `comanda_item`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `mesa`
--
ALTER TABLE `mesa`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de tabela `pedidio_cozinha`
--
ALTER TABLE `pedidio_cozinha`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `pedido_cozinha_item`
--
ALTER TABLE `pedido_cozinha_item`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
