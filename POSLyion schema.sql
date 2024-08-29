CREATE TABLE Roles (
  role_id INT IDENTITY(1, 1) NOT NULL,
  description VARCHAR(60) NOT NULL,
  create_date DATETIME DEFAULT GETDATE() NOT NULL,
  modify_date DATETIME NULL,
  CONSTRAINT PK_rol_id PRIMARY KEY (role_id)
);
GO

CREATE TABLE Permissions (
  permission_id INT IDENTITY(1, 1) NOT NULL,
  role_id INT NOT NULL,
  menu_name VARCHAR(100) NOT NULL,
  create_date DATETIME DEFAULT GETDATE() NOT NULL,
  CONSTRAINT PK_permission_id PRIMARY KEY (permission_id),
  CONSTRAINT FK_Permissions_Roles FOREIGN KEY (role_id) REFERENCES Roles(role_id)
);
GO

CREATE TABLE ProductCategories (
	product_category_id INT IDENTITY(1, 1) NOT NULL,
	description VARCHAR(60) NOT NULL,
	state BIT NOT NULL,
	create_date DATETIME DEFAULT GETDATE() NOT NULL,
	modify_date DATETIME NULL,
	CONSTRAINT PK_product_category_id PRIMARY KEY (product_category_id)
);
GO

CREATE TABLE Products (
	product_id INT IDENTITY(1, 1) NOT NULL,
	bar_code VARCHAR(60) NOT NULL,
	description VARCHAR(60) NOT NULL,
	product_category_id INT NOT NULL,
	cost_price DECIMAL(9, 2) DEFAULT 0 NOT NULL,
	sale_price DECIMAL(9, 2) DEFAULT 0 NOT NULL,
	current_stock INT DEFAULT 0 NOT NULL,
	minimum_stock INT DEFAULT 0 NOT NULL,
	state BIT NOT NULL,
	create_date DATETIME DEFAULT GETDATE() NOT NULL,
	modify_date DATETIME NULL,
	CONSTRAINT PK_product_id PRIMARY KEY (product_id),
	CONSTRAINT FK_Products_ProductCategories FOREIGN KEY (product_category_id) REFERENCES ProductCategories(product_category_id)
);
GO

CREATE TABLE Vendors (
	vendor_id INT IDENTITY(1, 1) NOT NULL,
	cuit VARCHAR(40) NULL,
	company_name VARCHAR(100) NOT NULL,
	email VARCHAR(155) NULL,
	phone VARCHAR(60) NULL,
	state BIT NOT NULL,
	create_date DATETIME DEFAULT GETDATE() NOT NULL,
	modify_date DATETIME NULL,
	CONSTRAINT PK_provider_id PRIMARY KEY (vendor_id)
);
GO

CREATE TABLE Customers (
	customer_id INT IDENTITY(1, 1) NOT NULL,
	dni VARCHAR(40) NULL,
	full_name VARCHAR(100) NOT NULL,
	email VARCHAR(155) NULL,
	phone VARCHAR(60) NULL,
	state BIT NOT NULL,
	create_date DATETIME DEFAULT GETDATE() NOT NULL,
	modify_date DATETIME NULL,
	CONSTRAINT PK_customer_id PRIMARY KEY (customer_id)
);
GO

CREATE TABLE Users (
	user_id INT IDENTITY(1, 1) NOT NULL,
	dni VARCHAR(30) NULL,
	full_name VARCHAR(100) NOT NULL,
	email VARCHAR(155) NULL,
	username VARCHAR(30) NOT NULL,
	password VARCHAR(155) NOT NULL,
	role_id INT NOT NULL,
	state BIT NOT NULL,
	create_date DATETIME DEFAULT GETDATE() NOT NULL,
	modify_date DATETIME NULL,
	CONSTRAINT PK_user_id PRIMARY KEY (user_id),
	CONSTRAINT FK_Users_Roles FOREIGN KEY (role_id) REFERENCES Roles(role_id),
	CONSTRAINT UC_Username UNIQUE (username)
);
GO

CREATE TABLE PurchaseOrders (
	purchase_order_id INT IDENTITY(1, 1) NOT NULL,
	user_id INT NOT NULL,
	vendor_id INT NULL,
	total DECIMAL (12, 2) NOT NULL,
	document_type VARCHAR(20) NOT NULL,
	document_number VARCHAR(50) NULL,
	create_date DATETIME DEFAULT GETDATE() NOT NULL,
	CONSTRAINT PK_order_id PRIMARY KEY (purchase_order_id),
	CONSTRAINT FK_Orders_Users FOREIGN KEY (user_id) REFERENCES Users(user_id),
	CONSTRAINT FK_Vendors_PurchaseOrders FOREIGN KEY (vendor_id) REFERENCES Vendors(vendor_id)
);
GO

CREATE TABLE PurchaseOrderDetails (
	purchase_order_detail_id INT IDENTITY(1, 1) NOT NULL,
	order_id INT NOT NULL,
	product_id INT NOT NULL,
	price DECIMAL(9, 2) DEFAULT 0 NOT NULL,
	quantity INT NOT NULL,
	subtotal DECIMAL (12, 2) NOT NULL,
	CONSTRAINT PK_order_detail_id PRIMARY KEY (purchase_order_detail_id),
	CONSTRAINT FK_PurchaseOrderDetails_PurchaseOrders FOREIGN KEY (order_id) REFERENCES PurchaseOrders(purchase_order_id),
	CONSTRAINT FK_PurchaseOrderDetails_Products FOREIGN KEY (product_id) REFERENCES Products(product_id)
);	
GO

CREATE TABLE Sales (
	sale_id INT IDENTITY(1, 1) NOT NULL,
	user_id INT NOT NULL,
	customer_id INT NULL,
	total DECIMAL(12, 2) NOT NULL,
	change DECIMAL(6, 2) NOT NULL,
	create_date DATETIME DEFAULT GETDATE() NOT NULL,
	modify_date DATETIME NULL,
	CONSTRAINT PK_sale_id PRIMARY KEY (sale_id),	
	CONSTRAINT FK_Sales_Users FOREIGN KEY (user_id) REFERENCES Users(user_id),
	CONSTRAINT FK_Sales_Customers FOREIGN KEY (customer_id) REFERENCES Customers(customer_id)
);
GO

CREATE TABLE SaleDetails (
	sale_detail_id INT IDENTITY(1, 1) NOT NULL,
	sale_id INT NOT NULL,
	product_id INT NOT NULL,
	price DECIMAL(12, 2) NOT NULL,
	quantity INT NOT NULL,
	subtotal DECIMAL(12, 2) NOT NULL,
	CONSTRAINT PK_sale_detail_id PRIMARY KEY (sale_detail_id),
	CONSTRAINT FK_SaleDetails_Sales FOREIGN KEY (sale_id) REFERENCES Sales(sale_id),
	CONSTRAINT FK_SaleDetails_Products FOREIGN KEY (product_id) REFERENCES Products(product_id)
);