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
	proveedor VARCHAR(100) NULL,
	total DECIMAL (12, 2) NOT NULL,
	tipo_documento VARCHAR(20) NOT NULL,
	numero_documento VARCHAR(50) NULL,
	fecha_documento DATETIME NULL,
	create_date DATETIME DEFAULT GETDATE() NULL,
	CONSTRAINT PK_id_compra PRIMARY KEY (id_compra),
	CONSTRAINT FK_Compras_Usuarios FOREIGN KEY (id_usuario) REFERENCES Usuarios(id_usuario),
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
	id_cliente INT NULL,
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

INSERT INTO Roles(descripcion)
VALUES
('Administrador'),
('Cajero'),
('Gerente'),
('Gerente general')
GO

INSERT INTO Permisos(id_rol, nombre_menu)
VALUES
(1, 'ventasToolStripMenuItem'),
(1, 'comprasToolStripMenuItem'),
(1, 'productosToolStripMenuItem'),
(1, 'usuariosToolStripMenuItem'),
(1, 'clientesToolStripMenuItem'),
(1, 'categoriasToolStripMenuItem'),
(1, 'proveedoresToolStripMenuItem'),
(1, 'reportesToolStripMenuItem'),
(1, 'configuracionToolStripMenuItem'),
(2, 'ventasToolStripMenuItem'),
(2, 'comprasToolStripMenuItem'),
(2, 'clientesToolStripMenuItem'),
(2, 'reportesToolStripMenuItem'),
(2, 'configuracionToolStripMenuItem'),
(3, 'ventasToolStripMenuItem'),
(3, 'comprasToolStripMenuItem'),
(3, 'productosToolStripMenuItem'),
(3, 'clientesToolStripMenuItem'),
(3, 'proveedoresToolStripMenuItem'),
(3, 'reportesToolStripMenuItem'),
(3, 'configuracionToolStripMenuItem'),
(4, 'ventasToolStripMenuItem'),
(4, 'comprasToolStripMenuItem'),
(4, 'productosToolStripMenuItem'),
(4, 'clientesToolStripMenuItem'),
(4, 'categoriasToolStripMenuItem'),
(4, 'proveedoresToolStripMenuItem'),
(4, 'reportesToolStripMenuItem'),
(4, 'configuracionToolStripMenuItem')
GO

INSERT INTO Usuarios(dni, nombre_completo, correo, nombre_usuario, clave, id_rol, telefono)
VALUES
('11111111', 'Administrador', 'administrador@hotmail.com', 'admin', '123', 1, '3794111111'),
('22222222', 'Vendedor', 'vendedor@hotmail.com', 'vendedor', '123', 2, '3794222222'),
('33333333', 'Gerente', 'gerente@hotmail.com', 'gerente', '123', 3, '3794333333'),
('44444444', 'Gerente general', 'gerentegeneral@hotmail.com', 'gerentegeneral', '123', 4, '3794444444')
GO

INSERT INTO Clientes(dni, nombre_completo, correo, telefono)
VALUES
('111', 'Cliente1', 'cliente1@hotmail.com', '3794111111'),
('222', 'Cliente2', 'cliente2@hotmail.com', '3794222222')

INSERT INTO Categorias(descripcion)
VALUES('General')
GO

INSERT INTO Productos(codigo_barras, descripcion, id_categoria, precio_costo, precio_venta, stock_actual, stock_minimo)
VALUES
('111', 'Comida', 1, 10.60, 6.66, 5, 3),
('222', 'Ropa', 1, 11.60, 7.66, 6, 2),
('333', 'Electronica', 1, 12.60, 8.66, 7, 1)
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
	@mensaje VARCHAR(360) OUTPUT,
	@id_generada_cliente INT OUTPUT
AS
BEGIN
	SET @mensaje = ''
	SET @id_generada_cliente = 0
	IF NOT EXISTS (SELECT * FROM Clientes WHERE dni = @dni)
	BEGIN
		INSERT INTO Clientes(dni, nombre_completo, correo, telefono)
		VALUES(@dni, @nombre_completo, @correo, @telefono)
		SET @id_generada_cliente = SCOPE_IDENTITY()
	END
	ELSE
	BEGIN
		SET @mensaje = 'Ya existe un cliente con el mismo DNI.'
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
	@mensaje VARCHAR(360) OUTPUT,
	@resultado BIT OUTPUT
AS
BEGIN
	SET @mensaje = ''
	SET @resultado = 0
	IF NOT EXISTS (SELECT * FROM Clientes WHERE dni = @dni AND id_cliente != @id_cliente)
	BEGIN
		UPDATE Clientes
		SET
		dni = @dni,
		nombre_completo = @nombre_completo,
		correo = @correo,
		telefono = @telefono,
		estado = @estado,
		modify_date = GETDATE()
		WHERE id_cliente = @id_cliente
		SET @resultado = 1
	END
	ELSE
	BEGIN
		SET @mensaje = 'Ya existe un cliente con el mismo DNI.'
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
	@proveedor VARCHAR(100),
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
			INSERT INTO Compras(id_usuario, proveedor, total, tipo_documento, numero_documento, fecha_documento)
			VALUES(@id_usuario, @proveedor, @total, @tipo_documento, @numero_documento, @fecha_documento)
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
	@id_cliente INT = NULL,
	@total DECIMAL(12, 2),
	@vuelto DECIMAL(6, 2),
	@VentaDetalle [EVenta_Detalle] READONLY,
	@resultado BIT OUTPUT,
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
