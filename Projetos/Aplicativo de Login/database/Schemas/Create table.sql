use db_app_login;

create table if not exists tb_usuarios (
	usuarios_id int auto_increment not null primary key,
	usuarios_nome varchar(50) not null,
	usuarios_email varchar(80) not null unique,
	usuarios_senha_hash varchar(250) not null,
	usarios_data datetime default current_timestamp
);
