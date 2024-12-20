CREATE DATABASE POSLyion
GO

USE POSLyion
GO

CREATE TABLE Lock(
	id INT PRIMARY KEY
);

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
	precio_mayorista DECIMAL(9, 2) NOT NULL,
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

CREATE TABLE Tipo_Venta(
	id_tipo_venta INT IDENTITY(1, 1) NOT NULL,
	descripcion VARCHAR(30) NOT NULL,
	CONSTRAINT PK_id_tipo_venta PRIMARY KEY (id_tipo_venta)
);

CREATE TABLE Ventas (
	id_venta INT IDENTITY(1, 1) NOT NULL,
	id_usuario INT NOT NULL,
	id_cliente INT NOT NULL,
	id_tipo_venta INT NOT NULL,
	total DECIMAL(12, 2) NOT NULL,
	vuelto DECIMAL(6, 2) NOT NULL,
	notas_venta VARCHAR(365) NULL,
	create_date DATETIME DEFAULT GETDATE() NULL,
	modify_date DATETIME NULL,
	CONSTRAINT PK_id_venta PRIMARY KEY (id_venta),	
	CONSTRAINT FK_Ventas_Usuarios FOREIGN KEY (id_usuario) REFERENCES Usuarios(id_usuario),
	CONSTRAINT FK_Ventas_Clientes FOREIGN KEY (id_cliente) REFERENCES Clientes(id_cliente),
	CONSTRAINT FK_Ventas_TipoVenta FOREIGN KEY (id_tipo_Venta) REFERENCES Tipo_Venta(id_tipo_venta)
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

CREATE TABLE Abono_Ventas (
	id_abono INT IDENTITY(1, 1) NOT NULL,
	id_cliente INT NOT NULL,
	monto_abono DECIMAL(12, 2) NOT NULL,
	fecha_abono DATETIME DEFAULT GETDATE() NULL,
	CONSTRAINT PK_id_abono PRIMARY KEY (id_abono),
	CONSTRAINT FK_id_cliente FOREIGN KEY (id_cliente) REFERENCES Clientes(id_cliente)
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

INSERT INTO Tipo_Venta(descripcion)
VALUES
('Efectivo'),
('A credito')

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
(1, 'tsmenu_venta'),
(1, 'tsmenu_compras'),
(1, 'tsmenu_prods'),
(1, 'tsmenu_users'),
(1, 'tsmenu_clientes'),
(1, 'tsmenu_cat'),
(1, 'tsmenu_proveedor'),
(1, 'tsmenu_reports'),
(1, 'tsmenu_config'),
(1, 'cerrarSesionToolStripMenuItem'),
(2, 'tsmenu_venta'),
(2, 'tsmenu_compras'),
(2, 'tsmenu_clientes'),
(2, 'tsmenu_reports'),
(2, 'tsmenu_config'),
(2, 'cerrarSesionToolStripMenuItem'),
(3, 'tsmenu_venta'),
(3, 'tsmenu_compras'),
(3, 'tsmenu_prods'),
(3, 'tsmenu_clientes'),
(3, 'tsmenu_proveedor'),
(3, 'tsmenu_reports'),
(3, 'tsmenu_config'),
(3, 'cerrarSesionToolStripMenuItem'),
(4, 'tsmenu_venta'),
(4, 'tsmenu_compras'),
(4, 'tsmenu_prods'),
(4, 'tsmenu_clientes'),
(4, 'tsmenu_cat'),
(4, 'tsmenu_proveedor'),
(4, 'tsmenu_reports'),
(4, 'tsmenu_config'),
(4, 'cerrarSesionToolStripMenuItem')
GO

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
VALUES('Analgesicos'),
('Higiene/Cuidado personal')
GO

INSERT INTO Productos(codigo_barras, descripcion, id_categoria, precio_costo, precio_venta, precio_mayorista, stock_actual, stock_minimo)
VALUES
('1000000001', 'AC 400', 1, 1500, 2200, 1895, 50, 10),
('1000000002', 'AC 600', 1, 4000, 5000, 4545, 40, 8),
('1000000003', 'AC Mujer', 1, 1800, 2600, 2225, 35, 7),
('1000000004', 'AC Plus', 1, 2200, 3000, 2735, 60, 12),
('1000000005', 'Alik cl�sico / naranja X1', 1, 350, 500, 481, 55, 15),
('1000000006', 'Alikal Caja cl�sico / naranja 30u.', 1, 12000, 15500, 14135, 20, 5),
('1000000007', 'Almaximo 50mg x2 comprimidos', 1, 700, 1000, 860, 70, 10),
('1000000008', 'Amox Fbx', 1, 1000, 1400, 1215, 80, 20),
('1000000009', 'Amoxidal 500 x7 comprimidos', 1, 1600, 2200, 2000, 45, 9),
('1000000010', 'Aspirineta', 1, 400, 700, 560, 100, 20),
('1000000011', 'Ib 600 Fabogesic', 1, 500, 900, 700, 75, 15),
('1000000012', 'Ib 600 Siend', 1, 500, 900, 700, 60, 10),
('1000000013', 'Ib 600 Labsyna', 1, 400, 800, 600, 55, 12),
('1000000014', 'IbuE Com�n', 1, 1200, 1800, 1572, 50, 8),
('1000000015', 'Jarabe Ibuxin ibuprofeno 4%', 1, 1200, 1600, 1500, 40, 10),
('1000000016', 'Ketorolac', 1, 350, 500, 417, 80, 15),
('1000000017', 'Loratatadina Vannier 10mg', 1, 300, 500, 450, 70, 12),
('1000000018', 'Loperamida Lovoprem', 1, 300, 550, 430, 50, 10),
('1000000019', 'Mejoral Ni�os', 1, 1200, 1800, 1660, 35, 8),
('1000000020', 'Mig Compuesto', 1, 2200, 3300, 2975, 25, 5),
('1000000021', 'Novalgina', 1, 3000, 4500, 4000, 30, 8),
('1000000022', 'Omeprazol 20mg X14', 1, 400, 700, 597, 45, 12),
('1000000023', 'Paracetamol 500mg Rolfita', 1, 350, 600, 500, 60, 15),
('1000000024', 'Qplus', 1, 2000, 3000, 2575, 55, 15),
('1000000025', 'Sertal Compuesto', 1, 3500, 4500, 4110, 20, 8),
('1000000026', 'Sertal Perla', 1, 2600, 3500, 3185, 35, 10),
('1000000027', 'Solucion Fisiologica Sanadrog 100ml', 1, 300, 600, 460, 85, 20),
('1000000028', 'Taf 1 G', 1, 1000, 1500, 1340, 40, 8),
('1000000029', 'Te Rolfita x1', 1, 300, 550, 465, 50, 10),
('1000000030', 'Tafi 500', 1, 1000, 1500, 1350, 35, 7),
('1000000031', 'Tafi 650', 1, 1200, 1700, 1595, 30, 6),
('1000000032', 'Tafi Plus', 1, 1500, 2000, 1850, 25, 5),
('1000000033', 'Te Vick forte x1', 1, 1000, 1500, 1410, 40, 8),
('1000000034', 'Te Vent3 plus x1', 1, 500, 800, 656, 55, 12),
('1000000035', 'Te Vent3 verde x1', 1, 400, 750, 590, 70, 15),
('1000000036', 'Uvasal x2', 1, 400, 750, 590, 90, 20),
('1000000037', 'Uvasal caja 15x2 sobres', 1, 7000, 9500, 8670, 20, 5),
('2000000001', 'Afeita BIC Comfort 2 filos x12u.', 2, 7000, 9500, 8990, 30, 10),
('2000000002', 'Agua Oxig 10vol.', 2, 200, 300, 265, 50, 15),
('2000000003', 'Algodon Caress X 75g', 2, 350, 550, 450, 45, 12),
('2000000004', 'Cepillo Colgate', 2, 500, 750, 695, 60, 15),
('2000000005', 'Cortau Trim Gde', 2, 500, 750, 670, 35, 10),
('2000000006', 'Gasa Suez X10', 2, 1200, 1700, 1660, 40, 12),
('2000000007', 'Hisopo Dismar x100u.', 2, 900, 1300, 1280, 55, 15),
('2000000008', 'Hisopo Qsoft x100u.', 2, 1000, 1450, 1395, 50, 12),
('2000000009', 'Manteca de cacao Luyagus', 2, 450, 700, 590, 70, 20),
('2000000010', 'Pa�uelo Elite x 6', 2, 500, 750, 660, 45, 10),
('2000000011', 'Pa�uelo Candela x 6', 2, 700, 1000, 955, 35, 8),
('2000000012', 'Prime x3u.', 2, 1200, 1700, 1515, 30, 8),
('2000000013', 'Repelente aerosol 811 de 150g', 2, 2000, 2800, 2680, 25, 8),
('2000000014', 'Rexona bolilla mujer/hombre', 2, 1000, 1500, 1373, 50, 12),
('2000000015', 'Sedal shampoo/acondicionador x24', 2, 2600, 3400, 3130, 20, 5),
('2000000016', 'Quitaesmalte Algabo 50cm x1', 2, 700, 900, 875, 60, 15),
('2000000017', 'Talco Algabo 200g x1', 2, 1000, 1400, 1270, 45, 10),
('2000000018', 'Tela Hipoalerg�nica 2,5cm', 2, 600, 900, 880, 70, 18),
('2000000019', 'Test De Embarazo', 2, 1200, 1800, 1700, 25, 5),
('2000000020', 'Toallita Calipso con alas', 2, 400, 600, 527, 80, 20),
('2000000021', 'Toallita Humeda BB X 100', 2, 600, 900, 780, 60, 15),
('2000000022', 'Toallita Lion con alas', 2, 400, 600, 510, 85, 18),
('2000000023', 'Tulipan x1 simple/color cajita', 2, 900, 1300, 1150, 50, 10);
GO

CREATE PROC SP_ALTA_PRODUCTO
	@codigo_barras VARCHAR(60),
	@descripcion VARCHAR(60),
	@id_categoria INT,
	@precio_costo DECIMAL(9, 2),
	@precio_venta DECIMAL(9, 2),
	@precio_mayorista DECIMAL(9, 2),
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
		precio_mayorista, stock_actual, stock_minimo)
		VALUES(@codigo_barras, @descripcion, @id_categoria, @precio_costo, @precio_venta,
		@precio_mayorista, @stock_actual, @stock_minimo)
		SET @id_generada_producto = SCOPE_IDENTITY()
	END
	ELSE
	BEGIN
		SET @mensaje = 'Ya existe un producto con el mismo c�digo de barras.'
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
	@precio_mayorista DECIMAL(9, 2),
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
		precio_mayorista = @precio_mayorista,
		stock_actual = @stock_actual,
		stock_minimo = @stock_minimo,
		estado = @estado,
		modify_date = GETDATE()
		WHERE id_producto = @id_producto
		SET @resultado = 1
	END
	ELSE
	BEGIN
		SET @mensaje = 'Ya existe un producto con el mismo c�digo de barras.'
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
		SET @mensaje = 'Ya existe una categor�a con la misma descripci�n.'
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
		SET @mensaje = 'Ya existe una categor�a con la misma descripci�n.'
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
		SET @mensaje = 'No se encuentra la categor�a solicitada.'
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
		SET @mensaje = 'No se encuentra la categor�a solicitada.'
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
	[Subtotal] DECIMAL(12, 2) NULL,
	[NuevoCosto] DECIMAL(12,2) NULL
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
			SET 
				p.stock_actual = p.stock_actual + cd.Cantidad,
				p.precio_costo = cd.NuevoCosto
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
	@id_tipo_venta INT,
	@total DECIMAL(12, 2),
	@vuelto DECIMAL(6, 2),
	@notas_venta VARCHAR(365),
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
			INSERT INTO Ventas(id_usuario, id_cliente, id_tipo_venta, total, vuelto, notas_venta)
			VALUES(@id_usuario, @id_cliente, @id_tipo_venta, @total, @vuelto, @notas_venta)
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

CREATE PROC SP_SUMAR_STOCK(
	@id_producto INT,
	@cantidad INT,
	@resultado BIT OUTPUT
)
AS
BEGIN
	SET @resultado = 1
	BEGIN TRY
		BEGIN TRANSACTION SUMAR_STOCK
		INSERT INTO Lock (id) VALUES (1);

		UPDATE Productos SET stock_actual = stock_actual + @cantidad WHERE id_producto = @id_producto;

		DELETE FROM Lock WHERE id = 1;
    
		COMMIT TRANSACTION SUMAR_STOCK

	END TRY
	BEGIN CATCH
		SET @resultado = 0
		IF @@TRANCOUNT > 0
		BEGIN
			ROLLBACK TRANSACTION SUMAR_STOCK
		END
	END CATCH;
END
GO

CREATE PROC SP_RESTAR_STOCK(
	@id_producto INT,
	@cantidad INT,
	@resultado BIT OUTPUT
)
AS
BEGIN
SET @resultado = 1
	BEGIN TRY
		BEGIN TRANSACTION RESTAR_STOCK
		INSERT INTO Lock (id) VALUES (1);

		UPDATE Productos SET stock_actual = stock_actual - @cantidad WHERE id_producto = @id_producto

		DELETE FROM Lock WHERE id = 1;
    
		COMMIT TRANSACTION SUMAR_STOCK

	END TRY
	BEGIN CATCH
		SET @resultado = 0
		IF @@TRANCOUNT > 0
		BEGIN
			ROLLBACK TRANSACTION SUMAR_STOCK
		END
	END CATCH;
END
GO

CREATE PROC SP_ABONO_VENTA(
	@id_cliente INT,
	@monto_abono DECIMAL(12, 2),
	@resultado BIT OUTPUT,
	@id_abono_generado INT OUTPUT,
	@mensaje VARCHAR(360) OUTPUT
)
AS
BEGIN
	BEGIN TRY
		DECLARE @id_abono INT = 0
		SET @resultado = 1
		SET @mensaje = ''

		BEGIN TRANSACTION ABONO_VENTA
			INSERT INTO Abono_Ventas(id_cliente, monto_abono)
			VALUES(@id_cliente, @monto_abono)
			SET @id_abono = SCOPE_IDENTITY()
			SET @id_abono_generado = @id_abono
		COMMIT TRANSACTION ABONO_VENTA
	END TRY
	BEGIN CATCH
		SET @resultado = 0
		SET @mensaje = ERROR_MESSAGE()
		ROLLBACK TRANSACTION ABONO_VENTA
	END CATCH
END
GO