CREATE PROC SP_CREATE_PRODUCTCATEGORY
	@description VARCHAR(60),
	@message VARCHAR(360) OUTPUT,
	@created_productcategory_id INT OUTPUT
AS
BEGIN
	SET @message = ''
	SET @created_productcategory_id = 0
	IF NOT EXISTS (SELECT description, state FROM ProductCategories WHERE description = @description)
	BEGIN
		INSERT INTO ProductCategories(description)
		VALUES(@description)
		SET @created_productcategory_id = SCOPE_IDENTITY()
	END
	ELSE
	BEGIN
		SET @message = 'Ya existe una categoría con la misma descripción.'
	END
END
GO

CREATE PROC SP_UPDATE_PRODUCTCATEGORY
	@product_category_id INT,
	@description VARCHAR(60),
	@state BIT,
	@message VARCHAR(360) OUTPUT,
	@result BIT OUTPUT
AS
BEGIN
	SET @message = ''
	SET @result = 0
	IF NOT EXISTS (SELECT description FROM ProductCategories WHERE description = @description
	AND product_category_id != @product_category_id)
	BEGIN
		UPDATE ProductCategories
		SET
		description = @description,
		state = @state,
		modify_date = GETDATE()
		WHERE product_category_id = @product_category_id
		SET @result = 1
	END
	ELSE
	BEGIN
		SET @message = 'Ya existe una categoría con la misma descripción.'
	END
END
GO

CREATE PROC SP_DELETE_PRODUCTCATEGORY
	@product_category_id INT,
	@message VARCHAR(360) OUTPUT,
	@result BIT OUTPUT
AS
BEGIN
	SET @message = ''
	SET @result = 0
	IF EXISTS (SELECT product_category_id FROM ProductCategories WHERE product_category_id = @product_category_id)
	BEGIN
		UPDATE ProductCategories
		SET
		state = 0,
		modify_date = GETDATE()
		WHERE product_category_id = @product_category_id
		SET @result = 1
	END
	ELSE
	BEGIN
		SET @message = 'No se encuentra la categoría solicitada.'
	END
END
GO

CREATE PROC SP_RESTORE_PRODUCTCATEGORY
	@product_category_id INT,
	@message VARCHAR(360) OUTPUT,
	@result BIT OUTPUT
AS
BEGIN
	SET @message = ''
	SET @result = 0
	IF EXISTS (SELECT product_category_id FROM ProductCategories WHERE product_category_id = @product_category_id)
	BEGIN
		UPDATE ProductCategories
		SET
		state = 1,
		modify_date = GETDATE()
		WHERE product_category_id = @product_category_id
		SET @result = 1
	END
	ELSE
	BEGIN
		SET @message = 'No se encuentra la categoría solicitada.'
	END
END