USE [CINDERELLA]
GO
ALTER TABLE [dbo].[PATENTES] DROP CONSTRAINT [FK__PATENTES__Id_Gru__498EEC8D]
GO
/****** Object:  Table [dbo].[PATENTES]    Script Date: 25/02/2017 06:11:48 p.m. ******/
DROP TABLE [dbo].[PATENTES]
GO
/****** Object:  Table [dbo].[PATENTES]    Script Date: 25/02/2017 06:11:48 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PATENTES](
	[id_Patente] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](255) NULL,
	[Id_Grupo] [int] NULL,
 CONSTRAINT [PK_PATENTES] PRIMARY KEY CLUSTERED 
(
	[id_Patente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[PATENTES] ON 

INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (1, N'Administración', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (2, N'Administración -> Cliente -> Mayorista -> Visualizar', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (3, N'Administración -> Cliente -> Mayorista -> Crear', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (4, N'Administración -> Cliente -> Mayorista -> Modificar', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (6, N'Administración -> Empleados -> Administración -> Visualizar', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (7, N'Administración -> Empleados -> Administración -> Crear', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (8, N'Administración -> Empleados -> Administración -> Modificar', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (9, N'Administración -> Empleados -> Administración -> Eliminar', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (10, N'Administración -> Empleados -> Estado Cuenta', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (11, N'Administración -> Empleados -> Pago Adicionales', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (12, N'Administración -> Empleados -> Sueldo Vacaciones Aguinaldo', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (13, N'Administración -> Empleados -> Registro', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (14, N'Administración -> Etiquetas', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (15, N'Administración -> Feriados', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (16, N'Administración -> Productos', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (17, N'Administración -> Productos -> Alta Masiva', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (18, N'Administración -> Productos -> Administración -> Visualizar', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (19, N'Administración -> Productos -> Administración -> Crear', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (20, N'Administración -> Productos -> Administración -> Modificar', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (21, N'Administración -> Productos -> Administración -> Eliminar', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (22, N'Administración -> Productos -> Administración -> Exportar', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (23, N'Administración -> Productos -> Administración -> Importar', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (24, N'Administración -> Productos -> Precios', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (25, N'Administración -> Productos -> Categorías -> Visualizar', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (26, N'Administración -> Productos -> Categorías -> Crear', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (27, N'Administración -> Productos -> Categorías -> Modificar', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (28, N'Administración -> Productos -> Categorías -> Eliminar', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (29, N'Administración -> Productos -> Subcategoría -> Visualizar', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (30, N'Administración -> Productos -> Subcategoría -> Crear', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (31, N'Administración -> Productos -> Subcategoría -> Modificar', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (32, N'Administración -> Productos -> Subcategoría -> Eliminar', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (34, N'Administración -> Proveedores -> Administración -> Visualizar', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (35, N'Administración -> Proveedores -> Administración -> Crear', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (36, N'Administración -> Proveedores -> Administración -> Modificar', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (37, N'Administración -> Proveedores -> Administración -> Eliminar', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (38, N'Administración -> Proveedores -> Cuenta Corriente -> Visualizar', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (39, N'Administración -> Proveedores -> Cuenta Corriente -> Detalle', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (40, N'Administración -> Proveedores -> Cuenta Corriente -> Mercadería', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (41, N'Administración -> Proveedores -> Cuenta Corriente -> Pagar', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (43, N'Administración -> Stock -> Administración -> Visualizar', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (44, N'Administración -> Stock -> Administración -> Crear', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (45, N'Administración -> Stock -> Administración -> Modificar', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (46, N'Administración -> Stock -> Administración -> Eliminar', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (47, N'Administración -> Stock -> Bitácora', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (48, N'Administración -> Stock -> Ingreso Mercadería -> Visualizar', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (49, N'Administración -> Stock -> Ingreso Mercadería -> Ingreso', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (50, N'Administración -> Stock -> Ingreso Mercadería -> Modificar', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (52, N'Administración -> Sucursales -> Administración -> Visualizar', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (53, N'Administración -> Sucursales -> Administración -> Crear', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (54, N'Administración -> Sucursales -> Administración -> Modificar', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (55, N'Administración -> Sucursales -> Administración -> Eliminar', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (56, N'Administración -> Sucursales -> Estado Cuenta', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (57, N'Administración -> Sucursales -> Historial Diferencia Caja', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (59, N'Administración -> Ventas -> Administración -> Visualizar', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (60, N'Administración -> Ventas -> Administración -> Detalle -> Visualizar', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (61, N'Administración -> Ventas -> Administración -> Detalle -> Anular', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (62, N'Administración -> Ventas -> Administración -> Detalle -> Facturar', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (63, N'Administración -> Ventas -> Administración -> Detalle -> Nota Crédito', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (64, N'Administración -> Ventas -> Venta', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (66, N'Administración -> Devoluciones -> Administración -> Visualizar', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (67, N'Administración -> Devoluciones -> Administración -> Detalle -> Anular', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (68, N'Administración -> Devoluciones -> Administración -> Detalle -> Nota Crédito', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (69, N'Administración -> Devoluciones -> Devolución', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (70, N'Administración -> Movimientos -> Listado de Movimientos', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (71, N'Administración -> Movimientos -> Gastos', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (72, N'Administración -> Movimientos -> Envió Otras Sucursales', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (73, N'Administración -> Movimientos -> Impuestos', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (74, N'Administración -> Movimientos -> Diferencia Caja', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (75, N'Administración -> Movimientos -> Retiro Socios', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (76, N'Administración -> Movimientos -> Caja Fuerte', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (77, N'Administración -> Cheques -> Administración -> Visualizar', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (78, N'Administración -> Cheques -> Administración -> Visualizar -> Exportar', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (79, N'Administración -> Cheques -> Administración -> Modificar', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (80, N'Administración -> Cheques -> Administración -> Modificar -> Salida', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (81, N'Administración -> Cheques -> Alta', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (83, N'Administración -> Nota Pedido -> Administración -> Visualizar', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (84, N'Administración -> Nota Pedido -> Administración -> Venta', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (85, N'Administración -> Nota Pedido -> Celular', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (86, N'Planillas', 2)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (87, N'Planillas -> Movimientos Sucursal -> Visualizar', 2)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (89, N'Planillas -> Movimientos Sucursal -> Exportar', 2)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (90, N'Planillas -> Movimientos Entre Sucursales', 2)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (91, N'Planillas -> Sueldo Empleados -> Visualizar', 2)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (93, N'Planillas -> Sueldo Empleados -> Exportar', 2)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (94, N'Planillas -> Listas de precios', 2)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (95, N'Seguridad', 3)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (96, N'Seguridad -> Perfiles -> Visualizar', 3)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (97, N'Seguridad -> Perfiles -> Crear', 3)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (98, N'Seguridad -> Perfiles -> Modificar', 3)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (99, N'Seguridad -> Usuarios -> Crear', 3)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (100, N'Seguridad -> Usuarios -> Visualizar', 3)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (102, N'Seguridad -> Usuarios -> modificar', 3)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (103, N'Seguridad -> Usuarios -> Eliminar', 3)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (104, N'Sistema', 4)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (105, N'Sistema -> Sincronización', 4)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (106, N'Sistema -> Configuración -> Sucursal -> Visualizar', 4)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (107, N'Sistema -> Configuración -> Sucursal -> Modificar', 4)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (108, N'Sistema -> Configuración -> Precio -> Visualizar', 4)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (109, N'Sistema -> Configuración -> Precio -> Modificar', 4)
GO
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (110, N'Sistema -> Configuración -> Mail -> Visualizar', 4)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (111, N'Sistema -> Configuración -> Mail -> Modificar', 4)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (112, N'Sistema -> Configuración -> Facturación -> Visualizar', 4)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (113, N'Sistema -> Configuración -> Facturación -> Modificar', 4)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (114, N'Sistema -> Configuración -> Alertas -> Visualizar', 4)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (115, N'Sistema -> Configuración -> Alertas -> Modificar', 4)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (116, N'Sistema -> Configuración -> Internet -> Visualizar', 4)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (117, N'Sistema -> Configuración -> Internet -> Modificar', 4)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (118, N'Sistema -> Configuración -> Host -> Visualizar', 4)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (119, N'Sistema -> Configuración -> Host -> Modificar', 4)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (120, N'Sistema -> Notificación -> Visualización', 4)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (121, N'Sistema -> Notificación -> Aceptar / Cancelar', 4)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (606, N'Administración -> Resumen Diario', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (607, N'Administración -> Cliente -> Mayorista -> Eliminar', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (608, N'Administración -> Nota Pedido -> Administración -> Eliminar', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (609, N'Administración -> Devoluciones -> Administración -> Detalle -> Facturar', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (610, N'Administración -> Devoluciones -> Administración -> Detalle -> Visualizar', 1)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (611, N'Seguridad -> Perfiles -> Eliminar', 3)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (612, N'Sistema -> Controlador Fiscal -> Emitir Cierre Z día', 4)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (613, N'Sistema -> Controlador Fiscal -> Emitir Cierre Z por rango de fechas', 4)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (614, N'Sistema -> Controlador Fiscal -> Buscar Tickets', 4)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (615, N'Sistema -> Controlador Fiscal -> Exportar Tickets', 4)
INSERT [dbo].[PATENTES] ([id_Patente], [Descripcion], [Id_Grupo]) VALUES (616, N'Administración -> Reservas -> Administración Reservas', 1)
SET IDENTITY_INSERT [dbo].[PATENTES] OFF
ALTER TABLE [dbo].[PATENTES]  WITH NOCHECK ADD FOREIGN KEY([Id_Grupo])
REFERENCES [dbo].[PATENTES_GRUPO] ([id_Patente_Grupo])
GO
