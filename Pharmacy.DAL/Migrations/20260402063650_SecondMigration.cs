using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pharmacy.DAL.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicines_Categories_CategoryId",
                table: "Medicines");

            migrationBuilder.DropForeignKey(
                name: "FK_Medicines_Suppliers_SupplierId",
                table: "Medicines");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleItems_Medicines_MedicineId",
                table: "SaleItems");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleItems_Sales_SaleId",
                table: "SaleItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Customers_CustomerId",
                table: "Sales");

            migrationBuilder.DropForeignKey(
                name: "FK_StockHistories_Medicines_MedicineId",
                table: "StockHistories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StockHistories",
                table: "StockHistories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SaleItems",
                table: "SaleItems");

            migrationBuilder.RenameTable(
                name: "StockHistories",
                newName: "StockHistory");

            migrationBuilder.RenameTable(
                name: "SaleItems",
                newName: "Saleltems");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Suppliers",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Suppliers",
                newName: "phone_number");

            migrationBuilder.RenameColumn(
                name: "CompanyName",
                table: "Suppliers",
                newName: "company_name");

            migrationBuilder.RenameColumn(
                name: "TotalAmount",
                table: "Sales",
                newName: "total_amount");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Sales",
                newName: "customer_id");

            migrationBuilder.RenameIndex(
                name: "IX_Sales_CustomerId",
                table: "Sales",
                newName: "IX_Sales_customer_id");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Medicines",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Medicines",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Manufacturer",
                table: "Medicines",
                newName: "manufacturer");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Medicines",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Barcode",
                table: "Medicines",
                newName: "barcode");

            migrationBuilder.RenameColumn(
                name: "SupplierId",
                table: "Medicines",
                newName: "supplier_id");

            migrationBuilder.RenameColumn(
                name: "QuantityInStock",
                table: "Medicines",
                newName: "quantity_in_stock");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Medicines",
                newName: "category_id");

            migrationBuilder.RenameIndex(
                name: "IX_Medicines_SupplierId",
                table: "Medicines",
                newName: "IX_Medicines_supplier_id");

            migrationBuilder.RenameIndex(
                name: "IX_Medicines_CategoryId",
                table: "Medicines",
                newName: "IX_Medicines_category_id");

            migrationBuilder.RenameColumn(
                name: "Salary",
                table: "Employees",
                newName: "salary");

            migrationBuilder.RenameColumn(
                name: "Position",
                table: "Employees",
                newName: "position");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Employees",
                newName: "phone_number");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Employees",
                newName: "full_name");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Customers",
                newName: "phone_number");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Customers",
                newName: "full_name");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Categories",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "QuantityChanged",
                table: "StockHistory",
                newName: "quantity_changed");

            migrationBuilder.RenameColumn(
                name: "MedicineId",
                table: "StockHistory",
                newName: "medicine_id");

            migrationBuilder.RenameColumn(
                name: "ActionType",
                table: "StockHistory",
                newName: "action_type");

            migrationBuilder.RenameIndex(
                name: "IX_StockHistories_MedicineId",
                table: "StockHistory",
                newName: "IX_StockHistory_medicine_id");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "Saleltems",
                newName: "quantity");

            migrationBuilder.RenameColumn(
                name: "UnitPrice",
                table: "Saleltems",
                newName: "unit_price");

            migrationBuilder.RenameColumn(
                name: "TotalPrice",
                table: "Saleltems",
                newName: "total_price");

            migrationBuilder.RenameColumn(
                name: "SaleId",
                table: "Saleltems",
                newName: "sale_id");

            migrationBuilder.RenameColumn(
                name: "MedicineId",
                table: "Saleltems",
                newName: "medicine_id");

            migrationBuilder.RenameIndex(
                name: "IX_SaleItems_SaleId",
                table: "Saleltems",
                newName: "IX_Saleltems_sale_id");

            migrationBuilder.RenameIndex(
                name: "IX_SaleItems_MedicineId",
                table: "Saleltems",
                newName: "IX_Saleltems_medicine_id");

            migrationBuilder.AlterColumn<string>(
                name: "phone_number",
                table: "Suppliers",
                type: "character varying(13)",
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "Medicines",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "phone_number",
                table: "Employees",
                type: "character varying(13)",
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "phone_number",
                table: "Customers",
                type: "character varying(13)",
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StockHistory",
                table: "StockHistory",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Saleltems",
                table: "Saleltems",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicines_Categories_category_id",
                table: "Medicines",
                column: "category_id",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Medicines_Suppliers_supplier_id",
                table: "Medicines",
                column: "supplier_id",
                principalTable: "Suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Saleltems_Medicines_medicine_id",
                table: "Saleltems",
                column: "medicine_id",
                principalTable: "Medicines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Saleltems_Sales_sale_id",
                table: "Saleltems",
                column: "sale_id",
                principalTable: "Sales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Customers_customer_id",
                table: "Sales",
                column: "customer_id",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StockHistory_Medicines_medicine_id",
                table: "StockHistory",
                column: "medicine_id",
                principalTable: "Medicines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicines_Categories_category_id",
                table: "Medicines");

            migrationBuilder.DropForeignKey(
                name: "FK_Medicines_Suppliers_supplier_id",
                table: "Medicines");

            migrationBuilder.DropForeignKey(
                name: "FK_Saleltems_Medicines_medicine_id",
                table: "Saleltems");

            migrationBuilder.DropForeignKey(
                name: "FK_Saleltems_Sales_sale_id",
                table: "Saleltems");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Customers_customer_id",
                table: "Sales");

            migrationBuilder.DropForeignKey(
                name: "FK_StockHistory_Medicines_medicine_id",
                table: "StockHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StockHistory",
                table: "StockHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Saleltems",
                table: "Saleltems");

            migrationBuilder.RenameTable(
                name: "StockHistory",
                newName: "StockHistories");

            migrationBuilder.RenameTable(
                name: "Saleltems",
                newName: "SaleItems");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "Suppliers",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "phone_number",
                table: "Suppliers",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "company_name",
                table: "Suppliers",
                newName: "CompanyName");

            migrationBuilder.RenameColumn(
                name: "total_amount",
                table: "Sales",
                newName: "TotalAmount");

            migrationBuilder.RenameColumn(
                name: "customer_id",
                table: "Sales",
                newName: "CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Sales_customer_id",
                table: "Sales",
                newName: "IX_Sales_CustomerId");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Medicines",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Medicines",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "manufacturer",
                table: "Medicines",
                newName: "Manufacturer");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Medicines",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "barcode",
                table: "Medicines",
                newName: "Barcode");

            migrationBuilder.RenameColumn(
                name: "supplier_id",
                table: "Medicines",
                newName: "SupplierId");

            migrationBuilder.RenameColumn(
                name: "quantity_in_stock",
                table: "Medicines",
                newName: "QuantityInStock");

            migrationBuilder.RenameColumn(
                name: "category_id",
                table: "Medicines",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Medicines_supplier_id",
                table: "Medicines",
                newName: "IX_Medicines_SupplierId");

            migrationBuilder.RenameIndex(
                name: "IX_Medicines_category_id",
                table: "Medicines",
                newName: "IX_Medicines_CategoryId");

            migrationBuilder.RenameColumn(
                name: "salary",
                table: "Employees",
                newName: "Salary");

            migrationBuilder.RenameColumn(
                name: "position",
                table: "Employees",
                newName: "Position");

            migrationBuilder.RenameColumn(
                name: "phone_number",
                table: "Employees",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "full_name",
                table: "Employees",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "phone_number",
                table: "Customers",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "full_name",
                table: "Customers",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Categories",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "quantity_changed",
                table: "StockHistories",
                newName: "QuantityChanged");

            migrationBuilder.RenameColumn(
                name: "medicine_id",
                table: "StockHistories",
                newName: "MedicineId");

            migrationBuilder.RenameColumn(
                name: "action_type",
                table: "StockHistories",
                newName: "ActionType");

            migrationBuilder.RenameIndex(
                name: "IX_StockHistory_medicine_id",
                table: "StockHistories",
                newName: "IX_StockHistories_MedicineId");

            migrationBuilder.RenameColumn(
                name: "quantity",
                table: "SaleItems",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "unit_price",
                table: "SaleItems",
                newName: "UnitPrice");

            migrationBuilder.RenameColumn(
                name: "total_price",
                table: "SaleItems",
                newName: "TotalPrice");

            migrationBuilder.RenameColumn(
                name: "sale_id",
                table: "SaleItems",
                newName: "SaleId");

            migrationBuilder.RenameColumn(
                name: "medicine_id",
                table: "SaleItems",
                newName: "MedicineId");

            migrationBuilder.RenameIndex(
                name: "IX_Saleltems_sale_id",
                table: "SaleItems",
                newName: "IX_SaleItems_SaleId");

            migrationBuilder.RenameIndex(
                name: "IX_Saleltems_medicine_id",
                table: "SaleItems",
                newName: "IX_SaleItems_MedicineId");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Suppliers",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(13)",
                oldMaxLength: 13);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Medicines",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Employees",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(13)",
                oldMaxLength: 13);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Customers",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(13)",
                oldMaxLength: 13);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StockHistories",
                table: "StockHistories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SaleItems",
                table: "SaleItems",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicines_Categories_CategoryId",
                table: "Medicines",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Medicines_Suppliers_SupplierId",
                table: "Medicines",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleItems_Medicines_MedicineId",
                table: "SaleItems",
                column: "MedicineId",
                principalTable: "Medicines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleItems_Sales_SaleId",
                table: "SaleItems",
                column: "SaleId",
                principalTable: "Sales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Customers_CustomerId",
                table: "Sales",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StockHistories_Medicines_MedicineId",
                table: "StockHistories",
                column: "MedicineId",
                principalTable: "Medicines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
