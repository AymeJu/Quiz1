create database quiz;
use quiz;
create table jogador(
Id integer primary key not null auto_increment,
Nome varchar(50));


 
select * from jogador;

alter table jogador add pontos int;