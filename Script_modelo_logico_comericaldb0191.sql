-------------------------------------------------------------------------------------------------INSERIR----------------------------------------------------------------------------------------------

-- drop PROCEDURE sp_cliente_inserir;
delimiter |
CREATE PROCEDURE sp_cliente_inserir(
_nome varchar (60),
_cpf varchar (11),
_email varchar (60)
)
BEGIN
	insert into clientes (nome,cpf,email, datacad, ativo)
    values (_nome, _cpf,_email, default, default);
    select * from clientes where id_cli = (select @@identity);
END
|
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

-- drop PROCEDURE sp_produtos_inserir;
 delimiter |
CREATE PROCEDURE sp_produtos_inserir(
_descrição varchar (100),
_unidade varchar (14),
_codbar char (13),
_valor decimal (10,2)
)
BEGIN
	insert into produtos (descrição, unidade, codbar, valor, desconto)
    values (_descrição, _unidade,_codbar, default, default);
    select * from produtos where id_prod = (select @@identity);
END
|
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

-- drop PROCEDURE sp_usuario_inserir;
 delimiter |
CREATE PROCEDURE sp_usuario_inserir(
_nome varchar (60),
_email varchar (60)
)
BEGIN
	insert into usuarios (nome, email, senha, nivel, ativo)
    values (_nome, _email, md5(_senha), default, default);
    select * from usuarios where id_user = (select @@identity);
END
|
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

-- drop PROCEDURE sp_itempedido_inserir;
 delimiter |
CREATE PROCEDURE sp_itempedido_inserir(
_idped_ip int,
_idprod_ip int,
_valor decimal (10,2),
_quantidade decimal (10,2),
_desconto decimal (10,2)
)
BEGIN
	insert into itempedido (idped_ip, idprod_ip, valor, quantidade, desconto)
    values (_idped_ip, _idprod_ip, _valor, _quantidade, _desconto);
END
|
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

-- drop PROCEDURE sp_caixas_inserir;
 delimiter |
CREATE PROCEDURE sp_caixas_inserir(
_data_abertura timestamp,
_saldo decimal (10,2),
_status_cx varchar (32),
_iduser_cx decimal (10,2)
)
BEGIN
	insert into caixas (data_abertura, saldo, status_cx, iduser_cx)
    values (_data_abertura, _saldo, _status_cx, iduser_cx);
    select * from caixas where idcx = (select @@identity);
END
|
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

-- drop PROCEDURE sp_vendas_inserir;
 delimiter |
CREATE PROCEDURE sp_vendas_inserir(
_data_vnd timestamp,
_status_vnd varchar (15),
_desconto decimal (10,2),
_idcx_vnd int,
_idped_vnd int
)
BEGIN
	insert into vendas (data_vnd, status_vnd, desconto, idcx_vnd, idped_vnd)
    values (_data_vnd, _status_vnd, _desconto, idcx_vnd, idped_vnd);
    select * from vendas where idvnd = (select @@identity);
END
|
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

-- drop PROCEDURE sp_pagamentos_inserir;
 delimiter |
CREATE PROCEDURE sp_pagamentos_inserir(
_valor decimal (10,2),
_idtipo int,
_idvnd_pag int
)
BEGIN
	insert into pagamentos (valor, idtipo, idvnd_pag)
    values (_valor, _idtipo, _idvnd_pag);
    select * from pagamentos where idpag = (select @@identity);
END
|
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

-- drop PROCEDURE sp_endereços_inserir;
 delimiter |
CREATE PROCEDURE sp_endereços_inserir(
_cep char (8),
_logradouro varchar (100),
_numero varchar (30),
_complemento varchar(100),
_bairro varchar (60),
_cidade varchar (100),
_estado varchar (45),
_uf char (2),
_iduser_end char (2)
)
BEGIN
	insert into usuarios (cep, logradouro, numero, complemento, bairro, cidade, estado, uf, iduser_end)
    values (_cep, _logradouro, _numero, _complemento, _bairro, _cidade, _estado, _uf, _iduser_end);
    select * from endereços where id_end = (select @@identity);
END
|
--------------------------------------------------------------------------------------------------ALTERAR-------------------------------------------------------------------------------------------

-- drop PROCEDURE sp_cliente_alterar;
delimiter |
CREATE PROCEDURE sp_cliente_alterar(
_id int,
_nome varchar(60),
_email varchar (60)
)
BEGIN
	update clientes set nome = _nome, email = _email where idcli = _id;
END
|
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-- drop PROCEDURE sp_produtos_alterar;
delimiter |
CREATE PROCEDURE sp_produtos_alterar(
_descricao varchar (100),
_valor decimal (10,2),
_desconto decimal (10,2)
)
BEGIN
	update produtos set descricao = _descricao, valor = _valor, desconto = _desconto where idprod = _id;
END
|
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

-- drop PROCEDURE sp_usuario_alterar;
delimiter |
CREATE PROCEDURE sp_usuario_alterar(
_nome int,
_email varchar(60),
_senha varchar (32)
)
BEGIN
	update usuarios set nome = _nome, email = _email, senha = _senha where iduser = _id;
END
|
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

-- drop PROCEDURE sp_pedidos_alterar;
delimiter |
CREATE PROCEDURE sp_pedidos_alterar(
_data timestamp,
_status_ped varchar(15),
_desconto decimal (10,2)
)
BEGIN
	update pedidos set data = _data, status_ped = _status_ped, desconto = _desconto where idped = _id;
END
|
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

-- drop PROCEDURE sp_itempedido_alterar;
delimiter |
CREATE PROCEDURE sp_itempedido_alterar(
_valor decimal (10,2),
_quantidade decimal (10,2),
_desconto decimal (10,2)
)
BEGIN
	update itempedido set valor = _valor, quantidade = _quantidade, desconto= _desconto where idprod = _id;
END
|
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

-- drop PROCEDURE sp_caixas_alterar;
delimiter |
CREATE PROCEDURE sp_caixas_alterar(
_data_abertura timestamp,
_saldo decimal (10,2),
_status_cx varchar (32)
)
BEGIN
	update caixas set data_abertura = _data_abertura, saldo = _saldo, status_cx = _status_cx where idcx = _id;
END
|
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

-- drop PROCEDURE sp_vendas_alterar;
delimiter |
CREATE PROCEDURE sp_vendas_alterar(
_data_vnd timestamp,
_status_vnd varchar(15),
_desconto decimal (10,2)
)
BEGIN
	update vendas set data_vnd = _data_vnd, status_vnd = _status_vnd, desconto = _desconto where idvnd = _id;
END
|
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

-- drop PROCEDURE sp_pagamentos_alterar;
delimiter |
CREATE PROCEDURE sp_pagamentos_alterar(
_valor decimal (10,2),
_idtipo int,
_idvnd_pag int
)
BEGIN
	update pagamentos set valor = _valor, idtipo = _idtipo, idvnd_pag = _idvnd_pag where idpag = _id;
END
|
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-- drop PROCEDURE sp_endereços_alterar;
delimiter |
CREATE PROCEDURE sp_endereços_alterar(
_cep char (8),
_logradouro varchar(100),
_numero varchar (30),
_complemento varchar (100),
_bairro varchar (60),
_cidade varchar (100),
_estado varchar (45),
_uf char (2),
_iduser_end char (2)
)
BEGIN
	update endereços set cep = _cep, logradouro = _logradouro, numero = _numero, complemento = _complemento, bairro = _bairro, cidade = _cidade, estado = _estado, uf = _uf, iduser_end = _iduser_end where idend = _id;
END
|
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------