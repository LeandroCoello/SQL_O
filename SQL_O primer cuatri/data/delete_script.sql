use GD1C2014
go 

drop table [SQL_O].[Administrativo]
drop table [SQL_O].[Calificacion]
drop table [SQL_O].[Cliente]
drop table [SQL_O].[Compra]
drop table [SQL_O].[Empresa]
drop table [SQL_O].[Item_Factura]
drop table [SQL_O].[Oferta]
drop table [SQL_O].[Pregunta]
drop table [SQL_O].[Pub_Por_Rubro]
drop table [SQL_O].[Publicacion]
drop table [SQL_O].[Respuesta]
drop table [SQL_O].[Func_Por_Rol]
drop table [SQL_O].[Rubro]
drop table [SQL_O].[Visibilidad]
drop table [SQL_O].[Funcionalidad]
drop table [SQL_O].[Factura]
drop table [SQL_O].[Usuarios_Por_Rol]
drop table [SQL_O].[Usuario]
drop table [SQL_O].[Tipo]
drop table [SQL_O].[Rol]
drop table [SQL_O].[Forma_Pago]
go
drop procedure [SQL_O].[alta_cliente]
drop procedure [SQL_O].[alta_empresa]
drop procedure [SQL_O].[alta_funcionalidad_por_rol]
drop procedure [SQL_O].[alta_publicacion]
drop procedure [SQL_O].[alta_rol]
drop procedure [SQL_O].[alta_visibilidad]
drop procedure [SQL_O].[actualizar_reputacion]
drop procedure [SQL_O].[baja_cliente]
drop procedure [SQL_O].[baja_empresa]
drop procedure [SQL_O].[baja_rol]
drop procedure [SQL_O].[baja_visibilidad]
drop procedure [SQL_O].[calificar]
drop procedure [SQL_O].[crear_pregunta]
drop procedure [SQL_O].[editar_publicacion]
drop procedure [SQL_O].[generar_usuario]
drop procedure [SQL_O].[responder_pregunta]
drop procedure [SQL_O].[actualizar_subastas]
drop procedure [SQL_O].[setear_reputacion]
drop procedure [SQL_O].[generar_oferta]
drop procedure [SQL_O].[generar_compra]
drop procedure [SQL_O].[proc_login]
drop procedure [SQL_O].[rehabilitacion_rol]
drop procedure [SQL_O].[modificacion_cliente]
drop procedure [SQL_O].[modificacion_empresa]
drop procedure [SQL_O].[modificacion_visibilidad]
drop procedure [SQL_O].[quitar_funcionalidad]
drop procedure [SQL_O].[modificacion_rol]
drop procedure [SQL_O].[agregar_rubro]
drop procedure [SQL_O].[generar_factura]
drop procedure [SQL_O].[agregar_item]
drop procedure [SQL_O].[crear_item]
drop procedure [SQL_O].[inhabilitar_usuario]
drop procedure [SQL_O].[rehabilitar_usuario]
drop procedure [SQL_O].[finalizar_subasta]
drop procedure [SQL_O].[finalizar_publicacion]
drop procedure [SQL_O].[cargar_datos_tarjeta]
drop procedure [SQL_O].[calcular_trimestre]
go
drop function [SQL_O].[historial_compras]
drop function [SQL_O].[historial_ofertas]
drop function [SQL_O].[historial_calif]
go

drop schema SQL_O
go


