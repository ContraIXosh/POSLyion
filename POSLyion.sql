CREATE DATABASE POSLyion
GO

USE POSLyion
GO

CREATE TABLE Roles (
  id_rol INT IDENTITY(1, 1) NOT NULL,
  descripcion VARCHAR(60) NOT NULL,
  create_date DATETIME DEFAULT GETDATE() NULL,
  modify_date DATETIME NULL,
  CONSTRAINT PK_id_rol PRIMARY KEY (id_rol)
);
GO

CREATE TABLE Permisos (
  id_permiso INT IDENTITY(1, 1) NOT NULL,
  id_rol INT NOT NULL,
  nombre_menu VARCHAR(100) NOT NULL,
  create_date DATETIME DEFAULT GETDATE() NULL,
  CONSTRAINT PK_id_permiso PRIMARY KEY (id_permiso),
  CONSTRAINT FK_Permisos_Roles FOREIGN KEY (id_rol) REFERENCES Roles(id_rol) ON DELETE CASCADE
);
GO

CREATE TABLE Categorias (
	id_categoria INT IDENTITY(1, 1) NOT NULL,
	descripcion VARCHAR(60) NOT NULL,
	estado BIT DEFAULT 1 NULL,
	create_date DATETIME DEFAULT GETDATE() NULL,
	modify_date DATETIME NULL,
	CONSTRAINT PK_id_categoria PRIMARY KEY (id_categoria)
);
GO

CREATE TABLE Productos (
	id_producto INT IDENTITY(1, 1) NOT NULL,
	codigo_barras VARCHAR(60) NOT NULL,
	descripcion VARCHAR(60) NOT NULL,
	id_categoria INT NOT NULL,
	precio_costo DECIMAL(9, 2) NOT NULL,
	precio_venta DECIMAL(9, 2) NOT NULL,
	stock_actual INT DEFAULT 0 NULL,
	stock_minimo INT DEFAULT 0 NULL,
	estado BIT DEFAULT 1 NULL,
	create_date DATETIME DEFAULT GETDATE() NULL,
	modify_date DATETIME NULL,
	CONSTRAINT PK_id_producto PRIMARY KEY (id_producto),
	CONSTRAINT FK_Productos_Categorias FOREIGN KEY (id_categoria) REFERENCES Categorias(id_categoria)
);
GO

CREATE TABLE Proveedores (
	id_proveedor INT IDENTITY(1, 1) NOT NULL,
	cuit VARCHAR(40) NULL,
	descripcion VARCHAR(100) NOT NULL,
	correo VARCHAR(155) NULL,
	telefono VARCHAR(60) NULL,
	estado BIT DEFAULT 1 NULL,
	create_date DATETIME DEFAULT GETDATE() NULL,
	modify_date DATETIME NULL,
	CONSTRAINT PK_id_proveedor PRIMARY KEY (id_proveedor)
);
GO

CREATE TABLE Clientes (
	id_cliente INT IDENTITY(1, 1) NOT NULL,
	dni VARCHAR(40) NULL,
	nombre_completo VARCHAR(100) NOT NULL,
	correo VARCHAR(155) NULL,
	telefono VARCHAR(60) NULL,
	estado BIT DEFAULT 1 NULL,
	descuento INT DEFAULT 0 NULL,
	create_date DATETIME DEFAULT GETDATE() NULL,
	modify_date DATETIME NULL,
	CONSTRAINT PK_id_cliente PRIMARY KEY (id_cliente)
);
GO

CREATE TABLE Usuarios (
	id_usuario INT IDENTITY(1, 1) NOT NULL,
	dni VARCHAR(30) NULL,
	nombre_completo VARCHAR(100) NULL,
	correo VARCHAR(155) NULL,
	nombre_usuario VARCHAR(30) NOT NULL,
	clave VARCHAR(155) NOT NULL,
	id_rol INT NOT NULL,
	telefono VARCHAR(360) NULL,
	estado BIT DEFAULT 1 NULL,
	create_date DATETIME DEFAULT GETDATE() NULL,
	modify_date DATETIME NULL,
	CONSTRAINT PK_id_usuario PRIMARY KEY (id_usuario),
	CONSTRAINT FK_Usuarios_Roles FOREIGN KEY (id_rol) REFERENCES Roles(id_rol)
);
GO

CREATE TABLE Compras (
	id_compra INT IDENTITY(1, 1) NOT NULL,
	id_usuario INT NOT NULL,
	id_proveedor INT NOT NULL,
	total DECIMAL (12, 2) NOT NULL,
	tipo_documento VARCHAR(20) NOT NULL,
	numero_documento VARCHAR(50) NULL,
	fecha_documento DATETIME NULL,
	create_date DATETIME DEFAULT GETDATE() NULL,
	CONSTRAINT PK_id_compra PRIMARY KEY (id_compra),
	CONSTRAINT FK_Compras_Usuarios FOREIGN KEY (id_usuario) REFERENCES Usuarios(id_usuario),
	CONSTRAINT FK_Compras_Proveedores FOREIGN KEY (id_usuario) REFERENCES Proveedores(id_proveedor)
);
GO

CREATE TABLE Compras_Detalle (
	id_compra_detalle INT IDENTITY(1, 1) NOT NULL,
	id_compra INT NOT NULL,
	id_producto INT NOT NULL,
	precio DECIMAL(9, 2) DEFAULT 0 NOT NULL,
	cantidad INT NOT NULL,
	subtotal DECIMAL (12, 2) NOT NULL,
	CONSTRAINT PK_id_compra_detalle PRIMARY KEY (id_compra_detalle),
	CONSTRAINT FK_Compras_Detalle_Compras FOREIGN KEY (id_compra) REFERENCES Compras(id_compra),
	CONSTRAINT FK_Compras_Detalle_Productos FOREIGN KEY (id_producto) REFERENCES Productos(id_producto)
);	
GO

CREATE TABLE Ventas (
	id_venta INT IDENTITY(1, 1) NOT NULL,
	id_usuario INT NOT NULL,
	id_cliente INT NOT NULL,
	total DECIMAL(12, 2) NOT NULL,
	vuelto DECIMAL(6, 2) NOT NULL,
	create_date DATETIME DEFAULT GETDATE() NULL,
	modify_date DATETIME NULL,
	CONSTRAINT PK_id_venta PRIMARY KEY (id_venta),	
	CONSTRAINT FK_Ventas_Usuarios FOREIGN KEY (id_usuario) REFERENCES Usuarios(id_usuario),
	CONSTRAINT FK_Ventas_Clientes FOREIGN KEY (id_cliente) REFERENCES Clientes(id_cliente)
);
GO

CREATE TABLE Ventas_Detalle (
	id_venta_detalle INT IDENTITY(1, 1) NOT NULL,
	id_venta INT NOT NULL,
	id_producto INT NOT NULL,
	precio DECIMAL(12, 2) NOT NULL,
	cantidad INT NOT NULL,
	subtotal DECIMAL(12, 2) NOT NULL,
	CONSTRAINT PK_id_venta_detalle PRIMARY KEY (id_venta_detalle),
	CONSTRAINT FK_Ventas_Detalle_Ventas FOREIGN KEY (id_venta) REFERENCES Ventas(id_venta),
	CONSTRAINT FK_Ventas_Detalle_Productos FOREIGN KEY (id_producto) REFERENCES Productos(id_producto)
);
GO

CREATE TABLE Cierre_Caja (
	id_cierre INT IDENTITY(1, 1) NOT NULL,
	id_usuario INT NOT NULL,
	monto_ventas DECIMAL (12, 2) NOT NULL,
	monto_caja DECIMAL (12, 2) NOT NULL,
	fecha_inicio_turno DATETIME NOT NULL,
	fecha_fin_turno DATETIME NOT NULL,
	CONSTRAINT PK_id_cierre PRIMARY KEY (id_cierre),
	CONSTRAINT FK_Cierre_Caja_Usuarios FOREIGN KEY (id_usuario) REFERENCES Usuarios(id_usuario)
);
GO

CREATE TABLE UsuariosPOS(
	id_usuario_pos INT IDENTITY(1, 1) NOT NULL,
	nombre VARCHAR(60) NOT NULL,
	clave VARCHAR(60) NOT NULL,
	nombre_empresa VARCHAR(60) NOT NULL,
	cantidad_sucursales INT NOT NULL,
	email VARCHAR(100) NOT NULL,
	fecha_vencimiento DATETIME NOT NULL,
	CONSTRAINT PK_id_usuario_pos PRIMARY KEY (id_usuario_pos)
);
GO

INSERT INTO UsuariosPOS(nombre, clave, nombre_empresa, cantidad_sucursales, email, fecha_vencimiento)
VALUES
('lucas', '123', 'MiEmpresa1', 3, 'luks@hotmail.com', '2024-11-12'),
('mauricio', '123', 'MiEmpresa2', 3, 'mauricio@hotmail.com', '2024-11-13')
GO

INSERT INTO Roles(descripcion)
VALUES
('Administrador'),
('Cajero'),
('Gerente'),
('Gerente general')
GO

INSERT INTO Permisos(id_rol, nombre_menu)
VALUES
(1, 'Start'),
(1, 'tsmenu_compras'),
(1, 'tsmenu_prods'),
(1, 'tsmenu_users'),
(1, 'tsmenu_clientes'),
(1, 'tsmenu_cat'),
(1, 'tsmenu_proveedor'),
(1, 'tsmenu_reports'),
(1, 'tsmenu_config'),
(1, 'cerrarSesionToolStripMenuItem'),
(2, 'Start'),
(2, 'tsmenu_compras'),
(2, 'tsmenu_clientes'),
(2, 'tsmenu_reports'),
(2, 'tsmenu_config'),
(2, 'cerrarSesionToolStripMenuItem'),
(3, 'Start'),
(3, 'tsmenu_compras'),
(3, 'tsmenu_prods'),
(3, 'tsmenu_clientes'),
(3, 'tsmenu_proveedor'),
(3, 'tsmenu_reports'),
(3, 'tsmenu_config'),
(3, 'cerrarSesionToolStripMenuItem'),
(4, 'Start'),
(4, 'tsmenu_compras'),
(4, 'tsmenu_prods'),
(4, 'tsmenu_clientes'),
(4, 'tsmenu_cat'),
(4, 'tsmenu_proveedor'),
(4, 'tsmenu_reports'),
(4, 'tsmenu_config'),
(4, 'cerrarSesionToolStripMenuItem')
GO

UPDATE Permisos
SET nombre_menu = 'tsmenu_venta'
WHERE nombre_menu = 'tsmenu_ventas'

INSERT INTO Proveedores(descripcion)
VALUES('Sin asignar'),
('Arcor'),
('El dorado'),
('Speed')
GO

INSERT INTO Clientes(nombre_completo)
VALUES('Consumidor final'),
('Ramon'),
('Ester'),
('Jose'),
('Pedro')
GO

INSERT INTO Usuarios(dni, nombre_completo, correo, nombre_usuario, clave, id_rol, telefono)
VALUES
('11111111', 'Administrador', 'administrador@hotmail.com', 'admin', '123', 1, '3794111111'),
('22222222', 'Vendedor', 'vendedor@hotmail.com', 'vendedor', '123', 2, '3794222222'),
('33333333', 'Gerente', 'gerente@hotmail.com', 'gerente', '123', 3, '3794333333'),
('44444444', 'Gerente general', 'gerentegeneral@hotmail.com', 'gerentegeneral', '123', 4, '3794444444')
GO

INSERT INTO Categorias(descripcion)
VALUES('General'),
('Harinas'),
('No perecederos'),
('Bebidas'),
('Golosinas'),
('Helados')
GO

INSERT INTO Productos(codigo_barras, descripcion, id_categoria, precio_costo, precio_venta, stock_actual, stock_minimo)
VALUES
('111', 'Tatin', 5, 6.60, 6.66, 5, 3),
('222', 'Blancaflor 1kg', 2, 11.60, 7.66, 6, 2),
('333', 'Fideo', 3, 9.60, 10.33, 5, 3),
('444', 'Arroz', 3, 5.80, 8.66, 2, 4),
('555', 'Agua Villavicencio 500ml', 4, 6.70, 10.46, -5, 2),
('666', 'Pepsi 1,5L', 4, 4.55, 15.79, -4, 6),
('777', 'Garrafa', 1, 12.32, 13.66, 0, 3),
('888', 'Torta Helada familiar 1kg', 6, 5.75, 19.99, 4, 4),
('999', 'Chupetin MR.POP', 5, 7.13, 10.01, -10, 5)
GO

CREATE PROC SP_ALTA_PRODUCTO
	@codigo_barras VARCHAR(60),
	@descripcion VARCHAR(60),
	@id_categoria INT,
	@precio_costo DECIMAL(9, 2),
	@precio_venta DECIMAL(9, 2),
	@stock_actual INT,
	@stock_minimo INT,
	@mensaje VARCHAR(360) OUTPUT,
	@id_generada_producto INT OUTPUT
AS
BEGIN
	SET @mensaje = ''
	SET @id_generada_producto = 0
	IF NOT EXISTS(SELECT * FROM Productos WHERE codigo_barras = @codigo_barras)
	BEGIN
		INSERT INTO Productos(codigo_barras, descripcion, id_categoria, precio_costo, precio_venta, 
		stock_actual, stock_minimo)
		VALUES(@codigo_barras, @descripcion, @id_categoria, @precio_costo, @precio_venta,
		@stock_actual, @stock_minimo)
		SET @id_generada_producto = SCOPE_IDENTITY()
	END
	ELSE
	BEGIN
		SET @mensaje = 'Ya existe un producto con el mismo código de barras.'
	END
END
GO

CREATE PROC SP_MODIFICAR_PRODUCTO
	@id_producto INT,
	@codigo_barras VARCHAR(60),
	@descripcion VARCHAR(60),
	@id_categoria INT,
	@precio_costo DECIMAL(9, 2),
	@precio_venta DECIMAL(9, 2),
	@stock_actual INT,
	@stock_minimo INT,
	@estado BIT,
	@mensaje VARCHAR(360) OUTPUT,
	@resultado INT OUTPUT
AS
BEGIN
	SET @mensaje = ''
	SET @resultado = 0
	IF NOT EXISTS(SELECT descripcion FROM Productos WHERE codigo_barras = @codigo_barras AND id_producto != @id_producto)
	BEGIN
		UPDATE Productos
		SET
		codigo_barras = @codigo_barras,
		descripcion = @descripcion,
		id_categoria = @id_categoria,
		precio_costo = @precio_costo,
		precio_venta = @precio_venta,
		stock_actual = @stock_actual,
		stock_minimo = @stock_minimo,
		estado = @estado,
		modify_date = GETDATE()
		WHERE id_producto = @id_producto
		SET @resultado = 1
	END
	ELSE
	BEGIN
		SET @mensaje = 'Ya existe un producto con el mismo código de barras.'
	END
END
GO

CREATE PROC SP_BAJA_PRODUCTO
	@id_producto INT,
	@mensaje VARCHAR(360) OUTPUT,
	@resultado INT OUTPUT
AS
BEGIN
	SET @mensaje = ''
	SET @resultado = 0
	IF EXISTS (SELECT descripcion FROM Productos WHERE id_producto = @id_producto)
	BEGIN
		UPDATE Productos
		SET
		estado = 0
		WHERE id_producto = @id_producto
		SET @resultado = 1
	END
	ELSE
	BEGIN
		SET @mensaje = 'No se encuentra el producto solicitado.'
	END
END
GO

CREATE PROC SP_RESTAURAR_PRODUCTO
	@id_producto INT,
	@mensaje VARCHAR(360) OUTPUT,
	@resultado INT OUTPUT
AS
BEGIN
	SET @mensaje = ''
	SET @resultado = 0
	IF EXISTS (SELECT descripcion FROM Productos WHERE id_producto = @id_producto)
	BEGIN
		UPDATE Productos
		SET
		estado = 1
		WHERE id_producto = @id_producto
		SET @resultado = 1
	END
	ELSE
	BEGIN
		SET @mensaje = 'No se encuentra el producto solicitado.'
	END
END
GO

CREATE PROC SP_ALTA_CATEGORIA
	@descripcion VARCHAR(60),
	@mensaje VARCHAR(360) OUTPUT,
	@id_generada_categoria INT OUTPUT
AS
BEGIN
	SET @mensaje = ''
	SET @id_generada_categoria = 0
	IF NOT EXISTS (SELECT descripcion, estado FROM Categorias WHERE descripcion = @descripcion)
	BEGIN
		INSERT INTO Categorias(descripcion)
		VALUES(@descripcion)
		SET @id_generada_categoria = SCOPE_IDENTITY()
	END
	ELSE
	BEGIN
		SET @mensaje = 'Ya existe una categoría con la misma descripción.'
	END
END
GO

CREATE PROC SP_MODIFICAR_CATEGORIA
	@id_categoria INT,
	@descripcion VARCHAR(60),
	@estado BIT,
	@mensaje VARCHAR(360) OUTPUT,
	@resultado BIT OUTPUT
AS
BEGIN
	SET @mensaje = ''
	SET @resultado = 0
	IF NOT EXISTS (SELECT descripcion FROM Categorias WHERE descripcion = @descripcion
	AND id_categoria != @id_categoria)
	BEGIN
		UPDATE Categorias
		SET
		descripcion = @descripcion,
		estado = @estado,
		modify_date = GETDATE()
		WHERE id_categoria = @id_categoria
		SET @resultado = 1
	END
	ELSE
	BEGIN
		SET @mensaje = 'Ya existe una categoría con la misma descripción.'
	END
END
GO

CREATE PROC SP_BAJA_CATEGORIA
	@id_categoria INT,
	@mensaje VARCHAR(360) OUTPUT,
	@resultado BIT OUTPUT
AS
BEGIN
	SET @mensaje = ''
	SET @resultado = 0
	IF EXISTS (SELECT id_categoria FROM Categorias WHERE id_categoria = @id_categoria)
	BEGIN
		UPDATE Categorias
		SET
		estado = 0,
		modify_date = GETDATE()
		WHERE id_categoria = @id_categoria
		SET @resultado = 1
	END
	ELSE
	BEGIN
		SET @mensaje = 'No se encuentra la categoría solicitada.'
	END
END
GO

CREATE PROC SP_RESTAURAR_CATEGORIA
	@id_categoria INT,
	@mensaje VARCHAR(360) OUTPUT,
	@resultado BIT OUTPUT
AS
BEGIN
	SET @mensaje = ''
	SET @resultado = 0
	IF EXISTS (SELECT id_categoria FROM Categorias WHERE id_categoria = @id_categoria)
	BEGIN
		UPDATE Categorias
		SET
		estado = 1,
		modify_date = GETDATE()
		WHERE id_categoria = @id_categoria
		SET @resultado = 1
	END
	ELSE
	BEGIN
		SET @mensaje = 'No se encuentra la categoría solicitada.'
	END
END
GO

CREATE PROC SP_ALTA_USUARIO
@dni VARCHAR(30),
@nombre_completo VARCHAR(100),
@correo VARCHAR(155),
@nombre_usuario VARCHAR(30),
@clave VARCHAR(155),
@id_rol INT,
@telefono VARCHAR(60),
@estado BIT,
@mensaje VARCHAR(360) OUTPUT,
@id_generada_usuario INT OUTPUT
AS
BEGIN
	SET @mensaje = ''
	SET @id_generada_usuario = 0
	IF NOT EXISTS (SELECT dni, nombre_usuario FROM Usuarios WHERE dni = @dni OR nombre_usuario = @nombre_usuario)
	BEGIN
		INSERT INTO Usuarios (dni, nombre_completo, correo, nombre_usuario, clave, id_rol, telefono, estado)
		VALUES (@dni, @nombre_completo, @correo, @nombre_usuario, @clave, @id_rol, @telefono, @estado)
		SET @id_generada_usuario = SCOPE_IDENTITY()
	END
	ELSE
	BEGIN
		SET @mensaje = 'Ya existe un usuario con el mismo DNI o nombre de usuario. Por favor, verificar nuevamente.'
		SET @id_generada_usuario = 0
	END
END
GO

CREATE PROC SP_MODIFICAR_USUARIO
@id_usuario INT,
@dni VARCHAR(30),
@nombre_completo VARCHAR(100),
@correo VARCHAR(155),
@nombre_usuario VARCHAR(30),
@clave VARCHAR(155),
@id_rol INT,
@telefono VARCHAR(60),
@estado BIT,
@mensaje VARCHAR(360) OUTPUT,
@resultado BIT OUTPUT
AS
BEGIN
	IF NOT EXISTS (SELECT id_usuario, dni, nombre_usuario FROM Usuarios WHERE id_usuario != @id_usuario AND (dni = @dni OR nombre_usuario = @nombre_usuario))
	BEGIN
		UPDATE Usuarios SET
		dni = @dni,
		nombre_completo = @nombre_completo,
		correo = @correo,
		nombre_usuario = @nombre_usuario,
		clave = @clave,
		id_rol = @id_rol,
		telefono = @telefono,
		estado = @estado,
		modify_date = GETDATE()
		WHERE id_usuario = @id_usuario
		SET @resultado = 1
	END
	ELSE
	BEGIN
		SET @mensaje = 'Ya existe un usuario con el mismo DNI o nombre de usuario. Por favor, verificar nuevamente.'
		SET @resultado = 0
	END
END
GO

CREATE PROC SP_BAJA_USUARIO
@id_usuario INT,
@mensaje VARCHAR(360) OUTPUT,
@resultado BIT OUTPUT
AS
BEGIN
	IF EXISTS (SELECT id_usuario FROM Usuarios WHERE id_usuario = @id_usuario)
	BEGIN
		UPDATE Usuarios
		SET estado = 0
		WHERE id_usuario = @id_usuario
		SET @resultado = 1
	END
	ELSE
	BEGIN
		SET @mensaje = 'No se encuentra el usuario solicitado'
		SET @resultado = 0
	END
END
GO

CREATE PROC SP_RESTAURAR_USUARIO
@id_usuario INT,
@mensaje VARCHAR(360) OUTPUT,
@resultado INT OUTPUT
AS
BEGIN
	SET @mensaje = ''
	IF EXISTS(SELECT id_usuario FROM Usuarios WHERE id_usuario = @id_usuario)
	BEGIN
		UPDATE Usuarios
		SET estado = 1
		WHERE id_usuario = @id_usuario
		SET @resultado = 1
	END
	ELSE
	BEGIN
		SET @mensaje = 'No se encuentra el usuario solicitado'
		SET @resultado = 0
	END
END
GO

CREATE PROC SP_ALTA_CLIENTE
	@dni VARCHAR(40),
	@nombre_completo VARCHAR(100),
	@correo VARCHAR(155),
	@telefono VARCHAR(60),
	@descuento INT,
	@mensaje VARCHAR(360) OUTPUT,
	@id_generada_cliente INT OUTPUT
AS
BEGIN
	SET @mensaje = ''
	SET @id_generada_cliente = 0
	IF NOT EXISTS (SELECT * FROM Clientes WHERE nombre_completo = @nombre_completo)
	BEGIN
		INSERT INTO Clientes(dni, nombre_completo, correo, telefono, descuento)
		VALUES(@dni, @nombre_completo, @correo, @telefono, @descuento)
		SET @id_generada_cliente = SCOPE_IDENTITY()
	END
	ELSE
	BEGIN
		SET @mensaje = 'Ya existe un cliente con el mismo nombre.'
	END
END
GO

CREATE PROC SP_MODIFICAR_CLIENTE
	@id_cliente INT,
	@dni VARCHAR(40),
	@nombre_completo VARCHAR(100),
	@correo VARCHAR(155),
	@telefono VARCHAR(60),
	@estado BIT,
	@descuento INT,
	@mensaje VARCHAR(360) OUTPUT,
	@resultado BIT OUTPUT
AS
BEGIN
	SET @mensaje = ''
	SET @resultado = 0
	IF NOT EXISTS (SELECT * FROM Clientes WHERE nombre_completo = @nombre_completo AND id_cliente != @id_cliente)
	BEGIN
		UPDATE Clientes
		SET
		dni = @dni,
		nombre_completo = @nombre_completo,
		correo = @correo,
		telefono = @telefono,
		estado = @estado,
		descuento = @descuento,
		modify_date = GETDATE()
		WHERE id_cliente = @id_cliente
		SET @resultado = 1
	END
	ELSE
	BEGIN
		SET @mensaje = 'Ya existe un cliente con el mismo nombre.'
	END
END
GO

CREATE PROC SP_BAJA_CLIENTE
	@id_cliente INT,
	@mensaje VARCHAR(360) OUTPUT,
	@resultado BIT OUTPUT
AS
BEGIN
	SET @mensaje = ''
	SET @resultado = 0
	IF EXISTS (SELECT * FROM Clientes WHERE id_cliente = @id_cliente)
	BEGIN
		UPDATE Clientes
		SET
		estado = 0
		WHERE id_cliente = @id_cliente
		SET @resultado = 1
	END
	ELSE
	BEGIN
		SET @mensaje = 'No se encuentra el cliente solicitado.'
	END
END
GO

CREATE PROC SP_RESTAURAR_CLIENTE
	@id_cliente INT,
	@mensaje VARCHAR(360) OUTPUT,
	@resultado BIT OUTPUT
AS
BEGIN
	SET @mensaje = ''
	SET @resultado = 0
	IF EXISTS (SELECT * FROM Clientes WHERE id_cliente = @id_cliente)
	BEGIN
		UPDATE Clientes
		SET
		estado = 1
		WHERE id_cliente = @id_cliente
		SET @resultado = 1
	END
	ELSE
	BEGIN
		SET @mensaje = 'No se encuentra el cliente solicitado.'
	END
END
GO

CREATE PROC SP_ALTA_PROVEEDOR
	@cuit VARCHAR(40),
	@descripcion VARCHAR(100),
	@correo VARCHAR(155),
	@telefono VARCHAR(60),
	@mensaje VARCHAR(360) OUTPUT,
	@id_generada_proveedor INT OUTPUT
AS
BEGIN
	SET @mensaje = ''
	SET @id_generada_proveedor = 0
	IF NOT EXISTS (SELECT * FROM Proveedores WHERE descripcion = @descripcion)
	BEGIN
		INSERT INTO Proveedores(cuit, descripcion, correo, telefono)
		VALUES(@cuit, @descripcion, @correo, @telefono)
		SET @id_generada_proveedor = SCOPE_IDENTITY()
	END
	ELSE
	BEGIN
		SET @mensaje = 'Ya existe un proveedor con el mismo nombre.'
	END
END
GO

CREATE PROC SP_MODIFICAR_PROVEEDOR
	@id_proveedor INT,
	@cuit VARCHAR(40),
	@descripcion VARCHAR(100),
	@correo VARCHAR(155),
	@telefono VARCHAR(60),
	@estado BIT,
	@mensaje VARCHAR(360) OUTPUT,
	@resultado BIT OUTPUT
AS
BEGIN
	SET @mensaje = ''
	SET @resultado = 0
	IF NOT EXISTS (SELECT * FROM Proveedores WHERE descripcion = @descripcion AND id_proveedor != @id_proveedor)
	BEGIN
		UPDATE Proveedores
		SET
		cuit = @cuit,
		descripcion = @descripcion,
		correo = @correo,
		telefono = @telefono,
		estado = @estado,
		modify_date = GETDATE()
		WHERE id_proveedor = @id_proveedor
		SET @resultado = 1
	END
	ELSE
	BEGIN
		SET @mensaje = 'Ya existe un proveedor con el mismo nombre.'
	END
END
GO

CREATE PROC SP_BAJA_PROVEEDOR
	@id_proveedor INT,
	@mensaje VARCHAR(360) OUTPUT,
	@resultado BIT OUTPUT
AS
BEGIN
	IF EXISTS (SELECT * FROM Proveedores WHERE id_proveedor = @id_proveedor)
	BEGIN
		UPDATE Proveedores
		SET estado = 0
		WHERE id_proveedor = @id_proveedor
		SET @resultado = 1
	END
	ELSE
	BEGIN
		SET @mensaje = 'No se encuentra el proveedor solicitado.'
	END
END
GO

CREATE PROC SP_RESTAURAR_PROVEEDOR
	@id_proveedor INT,
	@mensaje VARCHAR(360) OUTPUT,
	@resultado BIT OUTPUT
AS
BEGIN
	IF EXISTS (SELECT * FROM Proveedores WHERE id_proveedor = @id_proveedor)
	BEGIN
		UPDATE Proveedores
		SET estado = 1
		WHERE id_proveedor = @id_proveedor
		SET @resultado = 1
	END
	ELSE
	BEGIN
		SET @mensaje = 'No se encuentra el proveedor solicitado.'
	END
END
GO

CREATE TYPE [dbo].[ECompra_Detalle] AS TABLE(
	[Id_Producto] INT NULL,
	[Precio] DECIMAL(12, 2) NULL,
	[Cantidad] INT NULL,
	[Subtotal] DECIMAL(12, 2) NULL
)
GO

CREATE PROC SP_ALTA_COMPRA(
	@id_usuario INT,
	@id_proveedor INT,
	@total DECIMAL(12, 2),
	@tipo_documento VARCHAR(20),
	@numero_documento VARCHAR(50),
	@fecha_documento DATETIME,
	@CompraDetalle [ECompra_Detalle] READONLY,
	@resultado BIT OUTPUT,
	@mensaje VARCHAR(360) OUTPUT
)
AS
BEGIN
	BEGIN TRY
		DECLARE @id_compra INT = 0
		SET @resultado = 1
		SET @mensaje = ''

		BEGIN TRANSACTION REGISTRO_COMPRA
			INSERT INTO Compras(id_usuario, id_proveedor, total, tipo_documento, numero_documento, fecha_documento)
			VALUES(@id_usuario, @id_proveedor, @total, @tipo_documento, @numero_documento, @fecha_documento)
			SET @id_compra = SCOPE_IDENTITY()

			INSERT INTO Compras_Detalle(id_compra, id_producto, precio, cantidad, subtotal)
			SELECT @id_compra, Id_Producto, Precio, Cantidad, Subtotal FROM @CompraDetalle

			UPDATE p
			SET p.stock_actual = p.stock_actual + cd.Cantidad
			FROM Productos p
			INNER JOIN @CompraDetalle cd ON cd.Id_Producto = p.id_producto
		COMMIT TRANSACTION REGISTRO_COMPRA
	END TRY
	BEGIN CATCH
		SET @resultado = 0
		SET @mensaje = ERROR_MESSAGE()
		ROLLBACK TRANSACTION REGISTRO_COMPRA
	END CATCH
END
GO

CREATE TYPE [dbo].[EVenta_Detalle] AS TABLE(
	[Id_Producto] INT NULL,
	[Precio] DECIMAL(9, 2) NULL,
	[Cantidad] INT NULL,
	[Subtotal] DECIMAL(12, 2) NULL
)
GO

CREATE PROC SP_ALTA_VENTA(
	@id_usuario INT,
	@id_cliente INT,
	@total DECIMAL(12, 2),
	@vuelto DECIMAL(6, 2),
	@VentaDetalle [EVenta_Detalle] READONLY,
	@resultado BIT OUTPUT,
	@id_venta_generado INT OUTPUT,
	@mensaje VARCHAR(360) OUTPUT
)
AS
BEGIN
	BEGIN TRY
		DECLARE @id_venta INT = 0
		SET @resultado = 1
		SET @mensaje = ''

		BEGIN TRANSACTION REGISTRO_VENTA
			INSERT INTO Ventas(id_usuario, id_cliente, total, vuelto)
			VALUES(@id_usuario, @id_cliente, @total, @vuelto)
			SET @id_venta = SCOPE_IDENTITY()
			SET @id_venta_generado = @id_venta

			INSERT INTO Ventas_Detalle(id_venta, Id_Producto, Precio, Cantidad, Subtotal)
			SELECT @id_venta, Id_Producto, Precio, Cantidad, Subtotal FROM @VentaDetalle

		COMMIT TRANSACTION REGISTRO_VENTA
	END TRY
	BEGIN CATCH
		SET @resultado = 0
		SET @mensaje = ERROR_MESSAGE()
		ROLLBACK TRANSACTION REGISTRO_VENTA
	END CATCH
END
GO

CREATE PROC SP_HISTORIAL_COMPRAS(
	@fecha_desde VARCHAR(10),
	@fecha_hasta VARCHAR(10),
	@id_compra INT,
	@id_usuario INT,
	@id_proveedor INT,
	@nombre_producto VARCHAR(60)
)
AS
BEGIN
	SELECT
		c.id_compra[NumeroCompra],
		p.codigo_barras[CodigoBarras],
		p.descripcion[NombreProducto],
		ca.descripcion[NombreCategoria],
		cd.precio[PrecioUnitario],
		cd.cantidad[Cantidad],
		pr.descripcion[NombreProveedor],
		cd.subtotal[Subtotal],
		u.nombre_completo[UsuarioRegistro],
		c.fecha_documento[FechaDocumento],
		c.create_date[FechaRegistro]
	FROM Compras c
	INNER JOIN Usuarios u ON u.id_usuario = c.id_usuario
	INNER JOIN Proveedores pr ON pr.id_proveedor = c.id_proveedor
	INNER JOIN Compras_Detalle cd ON cd.id_compra = c.id_compra
	INNER JOIN Productos p ON p.id_producto = cd.id_producto
	INNER JOIN Categorias ca ON ca.id_categoria = p.id_categoria
	WHERE (CONVERT(DATE, c.create_date) BETWEEN @fecha_desde AND @fecha_hasta)
	AND (c.id_compra = IIF(@id_compra = 0, c.id_compra, @id_compra))
	AND (u.id_usuario = IIF(@id_usuario = 0, u.id_usuario, @id_usuario))
	AND (pr.id_proveedor = IIF(@id_proveedor = 0, pr.id_proveedor, @id_proveedor))
	AND (p.descripcion LIKE '%' + @nombre_producto + '%' OR @nombre_producto = '')
END
GO

CREATE PROC SP_HISTORIAL_VENTAS(
	@fecha_desde VARCHAR(10),
	@fecha_hasta VARCHAR(10),
	@id_venta INT,
	@id_usuario INT,
	@id_cliente INT,
	@nombre_producto VARCHAR(60)
)
AS
BEGIN
	SELECT
		v.id_venta[NumeroVenta],
		p.codigo_barras[CodigoBarras],
		p.descripcion[NombreProducto],
		ca.descripcion[NombreCategoria],
		vd.precio[PrecioUnitario],
		vd.cantidad[Cantidad],
		c.nombre_completo[NombreCliente],
		vd.subtotal[Subtotal],
		u.nombre_completo[UsuarioRegistro],
		v.create_date[FechaRegistro]
	FROM Ventas v
	INNER JOIN Usuarios u ON u.id_usuario = v.id_usuario
	INNER JOIN Clientes c ON c.id_cliente = v.id_cliente
	INNER JOIN Ventas_Detalle vd ON v.id_venta = vd.id_venta
	INNER JOIN Productos p ON p.id_producto = vd.id_producto
	INNER JOIN Categorias ca ON ca.id_categoria = p.id_categoria
	WHERE (CONVERT(DATE, v.create_date) BETWEEN @fecha_desde AND @fecha_hasta)
	AND (v.id_venta = IIF(@id_venta = 0, v.id_venta, @id_venta))
	AND (u.id_usuario = IIF(@id_usuario = 0, u.id_usuario, @id_usuario))
	AND (c.id_cliente = IIF(@id_cliente = 0, c.id_cliente, @id_cliente))
	AND (p.descripcion LIKE '%' + @nombre_producto + '%' OR @nombre_producto = '')
END
GO

CREATE PROC SP_ALTA_CAJA (
	@id_usuario INT,
	@monto_ventas DECIMAL(12, 2),
	@monto_caja DECIMAL(12, 2),
	@fecha_inicio_turno DATETIME,
	@fecha_fin_turno DATETIME,
	@id_generado_cierre_caja BIT OUTPUT,
	@mensaje VARCHAR(360) OUTPUT
)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION ALTA_CAJA
			SET @id_generado_cierre_caja = 0
			SET @mensaje = ''

			INSERT INTO Cierre_Caja(id_usuario, monto_ventas, monto_caja, fecha_inicio_turno, fecha_fin_turno)
			VALUES(@id_usuario, @monto_ventas, @monto_caja, @fecha_inicio_turno, @fecha_fin_turno)

			SET @id_generado_cierre_caja = SCOPE_IDENTITY()
		COMMIT TRANSACTION ALTA_CAJA
	END TRY
	BEGIN CATCH
		SET @mensaje = ERROR_MESSAGE()
		ROLLBACK TRANSACTION ALTA_CAJA
	END CATCH
END
GO

CREATE PROC SP_HISTORIAL_CIERRES_CAJA(
	@fecha_desde VARCHAR(10),
	@fecha_hasta VARCHAR(10),
	@id_usuario INT
)
AS
BEGIN
	SELECT id_cierre, nombre_usuario, monto_ventas, monto_caja, fecha_inicio_turno, fecha_fin_turno FROM Cierre_Caja c
	INNER JOIN Usuarios u ON c.id_usuario = u.id_usuario
	WHERE (CONVERT(DATE, fecha_inicio_turno) >= @fecha_desde)
	AND (CONVERT(DATE, fecha_fin_turno) <= @fecha_hasta)
	AND (u.id_usuario = IIF(@id_usuario = 0, u.id_usuario, @id_usuario))
END
GO
