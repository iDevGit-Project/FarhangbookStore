using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FarhangbookStore.DataModel.Migrations
{
    /// <inheritdoc />
    public partial class MIG_DbInit14021005_fixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBLProductCategory_TBLProductCategory_SubCategory",
                table: "TBLProductCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_TBLProductFaviorate_TBLProducts_Productid",
                table: "TBLProductFaviorate");

            migrationBuilder.DropForeignKey(
                name: "FK_TBLProductGallery_TBLProducts_Productid",
                table: "TBLProductGallery");

            migrationBuilder.DropForeignKey(
                name: "FK_TBLProductPrice_TBLProducts_Productid",
                table: "TBLProductPrice");

            migrationBuilder.DropForeignKey(
                name: "FK_TBLProductReating_TBLProducts_Productid",
                table: "TBLProductReating");

            migrationBuilder.DropForeignKey(
                name: "FK_TBLProductReating_TBLPropertyName_PropertyNameId",
                table: "TBLProductReating");

            migrationBuilder.DropForeignKey(
                name: "FK_TBLProductReview_TBLProducts_Productid",
                table: "TBLProductReview");

            migrationBuilder.DropForeignKey(
                name: "FK_TBLProducts_TBLProductCategory_Categoryid",
                table: "TBLProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_TBLPropertyName_Category_TBLProductCategory_Categoryid",
                table: "TBLPropertyName_Category");

            migrationBuilder.DropForeignKey(
                name: "FK_TBLPropertyName_Category_TBLPropertyName_PropertyNameId",
                table: "TBLPropertyName_Category");

            migrationBuilder.DropForeignKey(
                name: "FK_TBLPropertyValue_TBLProducts_Productid",
                table: "TBLPropertyValue");

            migrationBuilder.DropForeignKey(
                name: "FK_TBLPropertyValue_TBLPropertyName_PropertyNameId",
                table: "TBLPropertyValue");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBLPropertyValue",
                table: "TBLPropertyValue");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBLPropertyName_Category",
                table: "TBLPropertyName_Category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBLPropertyName",
                table: "TBLPropertyName");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBLProductReview",
                table: "TBLProductReview");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBLProductReating",
                table: "TBLProductReating");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBLProductPrice",
                table: "TBLProductPrice");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBLProductGallery",
                table: "TBLProductGallery");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBLProductFaviorate",
                table: "TBLProductFaviorate");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBLProductCategory",
                table: "TBLProductCategory");

            migrationBuilder.RenameTable(
                name: "TBLPropertyValue",
                newName: "TBLPropertyValueies");

            migrationBuilder.RenameTable(
                name: "TBLPropertyName_Category",
                newName: "TBLPropertyNameCategories");

            migrationBuilder.RenameTable(
                name: "TBLPropertyName",
                newName: "TBLPropertyNames");

            migrationBuilder.RenameTable(
                name: "TBLProductReview",
                newName: "TBLProductReviews");

            migrationBuilder.RenameTable(
                name: "TBLProductReating",
                newName: "TBLProductReatings");

            migrationBuilder.RenameTable(
                name: "TBLProductPrice",
                newName: "TBLProductPrices");

            migrationBuilder.RenameTable(
                name: "TBLProductGallery",
                newName: "TBLProductGalleries");

            migrationBuilder.RenameTable(
                name: "TBLProductFaviorate",
                newName: "TBLProductFaviorates");

            migrationBuilder.RenameTable(
                name: "TBLProductCategory",
                newName: "TBLProductCategories");

            migrationBuilder.RenameIndex(
                name: "IX_TBLPropertyValue_PropertyNameId",
                table: "TBLPropertyValueies",
                newName: "IX_TBLPropertyValueies_PropertyNameId");

            migrationBuilder.RenameIndex(
                name: "IX_TBLPropertyValue_Productid",
                table: "TBLPropertyValueies",
                newName: "IX_TBLPropertyValueies_Productid");

            migrationBuilder.RenameIndex(
                name: "IX_TBLPropertyName_Category_PropertyNameId",
                table: "TBLPropertyNameCategories",
                newName: "IX_TBLPropertyNameCategories_PropertyNameId");

            migrationBuilder.RenameIndex(
                name: "IX_TBLPropertyName_Category_Categoryid",
                table: "TBLPropertyNameCategories",
                newName: "IX_TBLPropertyNameCategories_Categoryid");

            migrationBuilder.RenameIndex(
                name: "IX_TBLProductReview_Productid",
                table: "TBLProductReviews",
                newName: "IX_TBLProductReviews_Productid");

            migrationBuilder.RenameIndex(
                name: "IX_TBLProductReating_PropertyNameId",
                table: "TBLProductReatings",
                newName: "IX_TBLProductReatings_PropertyNameId");

            migrationBuilder.RenameIndex(
                name: "IX_TBLProductReating_Productid",
                table: "TBLProductReatings",
                newName: "IX_TBLProductReatings_Productid");

            migrationBuilder.RenameIndex(
                name: "IX_TBLProductPrice_Productid",
                table: "TBLProductPrices",
                newName: "IX_TBLProductPrices_Productid");

            migrationBuilder.RenameIndex(
                name: "IX_TBLProductGallery_Productid",
                table: "TBLProductGalleries",
                newName: "IX_TBLProductGalleries_Productid");

            migrationBuilder.RenameIndex(
                name: "IX_TBLProductFaviorate_Productid",
                table: "TBLProductFaviorates",
                newName: "IX_TBLProductFaviorates_Productid");

            migrationBuilder.RenameIndex(
                name: "IX_TBLProductCategory_SubCategory",
                table: "TBLProductCategories",
                newName: "IX_TBLProductCategories_SubCategory");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBLPropertyValueies",
                table: "TBLPropertyValueies",
                column: "PropertyValueId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBLPropertyNameCategories",
                table: "TBLPropertyNameCategories",
                column: "pncId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBLPropertyNames",
                table: "TBLPropertyNames",
                column: "PropertyNameId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBLProductReviews",
                table: "TBLProductReviews",
                column: "Reviewid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBLProductReatings",
                table: "TBLProductReatings",
                column: "Reatingid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBLProductPrices",
                table: "TBLProductPrices",
                column: "Productpriceid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBLProductGalleries",
                table: "TBLProductGalleries",
                column: "galleryid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBLProductFaviorates",
                table: "TBLProductFaviorates",
                column: "Faviorateid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBLProductCategories",
                table: "TBLProductCategories",
                column: "Categoryid");

            migrationBuilder.AddForeignKey(
                name: "FK_TBLProductCategories_TBLProductCategories_SubCategory",
                table: "TBLProductCategories",
                column: "SubCategory",
                principalTable: "TBLProductCategories",
                principalColumn: "Categoryid");

            migrationBuilder.AddForeignKey(
                name: "FK_TBLProductFaviorates_TBLProducts_Productid",
                table: "TBLProductFaviorates",
                column: "Productid",
                principalTable: "TBLProducts",
                principalColumn: "Productid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TBLProductGalleries_TBLProducts_Productid",
                table: "TBLProductGalleries",
                column: "Productid",
                principalTable: "TBLProducts",
                principalColumn: "Productid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TBLProductPrices_TBLProducts_Productid",
                table: "TBLProductPrices",
                column: "Productid",
                principalTable: "TBLProducts",
                principalColumn: "Productid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TBLProductReatings_TBLProducts_Productid",
                table: "TBLProductReatings",
                column: "Productid",
                principalTable: "TBLProducts",
                principalColumn: "Productid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TBLProductReatings_TBLPropertyNames_PropertyNameId",
                table: "TBLProductReatings",
                column: "PropertyNameId",
                principalTable: "TBLPropertyNames",
                principalColumn: "PropertyNameId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TBLProductReviews_TBLProducts_Productid",
                table: "TBLProductReviews",
                column: "Productid",
                principalTable: "TBLProducts",
                principalColumn: "Productid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TBLProducts_TBLProductCategories_Categoryid",
                table: "TBLProducts",
                column: "Categoryid",
                principalTable: "TBLProductCategories",
                principalColumn: "Categoryid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TBLPropertyNameCategories_TBLProductCategories_Categoryid",
                table: "TBLPropertyNameCategories",
                column: "Categoryid",
                principalTable: "TBLProductCategories",
                principalColumn: "Categoryid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TBLPropertyNameCategories_TBLPropertyNames_PropertyNameId",
                table: "TBLPropertyNameCategories",
                column: "PropertyNameId",
                principalTable: "TBLPropertyNames",
                principalColumn: "PropertyNameId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TBLPropertyValueies_TBLProducts_Productid",
                table: "TBLPropertyValueies",
                column: "Productid",
                principalTable: "TBLProducts",
                principalColumn: "Productid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TBLPropertyValueies_TBLPropertyNames_PropertyNameId",
                table: "TBLPropertyValueies",
                column: "PropertyNameId",
                principalTable: "TBLPropertyNames",
                principalColumn: "PropertyNameId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBLProductCategories_TBLProductCategories_SubCategory",
                table: "TBLProductCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_TBLProductFaviorates_TBLProducts_Productid",
                table: "TBLProductFaviorates");

            migrationBuilder.DropForeignKey(
                name: "FK_TBLProductGalleries_TBLProducts_Productid",
                table: "TBLProductGalleries");

            migrationBuilder.DropForeignKey(
                name: "FK_TBLProductPrices_TBLProducts_Productid",
                table: "TBLProductPrices");

            migrationBuilder.DropForeignKey(
                name: "FK_TBLProductReatings_TBLProducts_Productid",
                table: "TBLProductReatings");

            migrationBuilder.DropForeignKey(
                name: "FK_TBLProductReatings_TBLPropertyNames_PropertyNameId",
                table: "TBLProductReatings");

            migrationBuilder.DropForeignKey(
                name: "FK_TBLProductReviews_TBLProducts_Productid",
                table: "TBLProductReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_TBLProducts_TBLProductCategories_Categoryid",
                table: "TBLProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_TBLPropertyNameCategories_TBLProductCategories_Categoryid",
                table: "TBLPropertyNameCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_TBLPropertyNameCategories_TBLPropertyNames_PropertyNameId",
                table: "TBLPropertyNameCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_TBLPropertyValueies_TBLProducts_Productid",
                table: "TBLPropertyValueies");

            migrationBuilder.DropForeignKey(
                name: "FK_TBLPropertyValueies_TBLPropertyNames_PropertyNameId",
                table: "TBLPropertyValueies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBLPropertyValueies",
                table: "TBLPropertyValueies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBLPropertyNames",
                table: "TBLPropertyNames");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBLPropertyNameCategories",
                table: "TBLPropertyNameCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBLProductReviews",
                table: "TBLProductReviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBLProductReatings",
                table: "TBLProductReatings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBLProductPrices",
                table: "TBLProductPrices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBLProductGalleries",
                table: "TBLProductGalleries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBLProductFaviorates",
                table: "TBLProductFaviorates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBLProductCategories",
                table: "TBLProductCategories");

            migrationBuilder.RenameTable(
                name: "TBLPropertyValueies",
                newName: "TBLPropertyValue");

            migrationBuilder.RenameTable(
                name: "TBLPropertyNames",
                newName: "TBLPropertyName");

            migrationBuilder.RenameTable(
                name: "TBLPropertyNameCategories",
                newName: "TBLPropertyName_Category");

            migrationBuilder.RenameTable(
                name: "TBLProductReviews",
                newName: "TBLProductReview");

            migrationBuilder.RenameTable(
                name: "TBLProductReatings",
                newName: "TBLProductReating");

            migrationBuilder.RenameTable(
                name: "TBLProductPrices",
                newName: "TBLProductPrice");

            migrationBuilder.RenameTable(
                name: "TBLProductGalleries",
                newName: "TBLProductGallery");

            migrationBuilder.RenameTable(
                name: "TBLProductFaviorates",
                newName: "TBLProductFaviorate");

            migrationBuilder.RenameTable(
                name: "TBLProductCategories",
                newName: "TBLProductCategory");

            migrationBuilder.RenameIndex(
                name: "IX_TBLPropertyValueies_PropertyNameId",
                table: "TBLPropertyValue",
                newName: "IX_TBLPropertyValue_PropertyNameId");

            migrationBuilder.RenameIndex(
                name: "IX_TBLPropertyValueies_Productid",
                table: "TBLPropertyValue",
                newName: "IX_TBLPropertyValue_Productid");

            migrationBuilder.RenameIndex(
                name: "IX_TBLPropertyNameCategories_PropertyNameId",
                table: "TBLPropertyName_Category",
                newName: "IX_TBLPropertyName_Category_PropertyNameId");

            migrationBuilder.RenameIndex(
                name: "IX_TBLPropertyNameCategories_Categoryid",
                table: "TBLPropertyName_Category",
                newName: "IX_TBLPropertyName_Category_Categoryid");

            migrationBuilder.RenameIndex(
                name: "IX_TBLProductReviews_Productid",
                table: "TBLProductReview",
                newName: "IX_TBLProductReview_Productid");

            migrationBuilder.RenameIndex(
                name: "IX_TBLProductReatings_PropertyNameId",
                table: "TBLProductReating",
                newName: "IX_TBLProductReating_PropertyNameId");

            migrationBuilder.RenameIndex(
                name: "IX_TBLProductReatings_Productid",
                table: "TBLProductReating",
                newName: "IX_TBLProductReating_Productid");

            migrationBuilder.RenameIndex(
                name: "IX_TBLProductPrices_Productid",
                table: "TBLProductPrice",
                newName: "IX_TBLProductPrice_Productid");

            migrationBuilder.RenameIndex(
                name: "IX_TBLProductGalleries_Productid",
                table: "TBLProductGallery",
                newName: "IX_TBLProductGallery_Productid");

            migrationBuilder.RenameIndex(
                name: "IX_TBLProductFaviorates_Productid",
                table: "TBLProductFaviorate",
                newName: "IX_TBLProductFaviorate_Productid");

            migrationBuilder.RenameIndex(
                name: "IX_TBLProductCategories_SubCategory",
                table: "TBLProductCategory",
                newName: "IX_TBLProductCategory_SubCategory");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBLPropertyValue",
                table: "TBLPropertyValue",
                column: "PropertyValueId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBLPropertyName",
                table: "TBLPropertyName",
                column: "PropertyNameId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBLPropertyName_Category",
                table: "TBLPropertyName_Category",
                column: "pncId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBLProductReview",
                table: "TBLProductReview",
                column: "Reviewid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBLProductReating",
                table: "TBLProductReating",
                column: "Reatingid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBLProductPrice",
                table: "TBLProductPrice",
                column: "Productpriceid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBLProductGallery",
                table: "TBLProductGallery",
                column: "galleryid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBLProductFaviorate",
                table: "TBLProductFaviorate",
                column: "Faviorateid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBLProductCategory",
                table: "TBLProductCategory",
                column: "Categoryid");

            migrationBuilder.AddForeignKey(
                name: "FK_TBLProductCategory_TBLProductCategory_SubCategory",
                table: "TBLProductCategory",
                column: "SubCategory",
                principalTable: "TBLProductCategory",
                principalColumn: "Categoryid");

            migrationBuilder.AddForeignKey(
                name: "FK_TBLProductFaviorate_TBLProducts_Productid",
                table: "TBLProductFaviorate",
                column: "Productid",
                principalTable: "TBLProducts",
                principalColumn: "Productid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TBLProductGallery_TBLProducts_Productid",
                table: "TBLProductGallery",
                column: "Productid",
                principalTable: "TBLProducts",
                principalColumn: "Productid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TBLProductPrice_TBLProducts_Productid",
                table: "TBLProductPrice",
                column: "Productid",
                principalTable: "TBLProducts",
                principalColumn: "Productid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TBLProductReating_TBLProducts_Productid",
                table: "TBLProductReating",
                column: "Productid",
                principalTable: "TBLProducts",
                principalColumn: "Productid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TBLProductReating_TBLPropertyName_PropertyNameId",
                table: "TBLProductReating",
                column: "PropertyNameId",
                principalTable: "TBLPropertyName",
                principalColumn: "PropertyNameId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TBLProductReview_TBLProducts_Productid",
                table: "TBLProductReview",
                column: "Productid",
                principalTable: "TBLProducts",
                principalColumn: "Productid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TBLProducts_TBLProductCategory_Categoryid",
                table: "TBLProducts",
                column: "Categoryid",
                principalTable: "TBLProductCategory",
                principalColumn: "Categoryid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TBLPropertyName_Category_TBLProductCategory_Categoryid",
                table: "TBLPropertyName_Category",
                column: "Categoryid",
                principalTable: "TBLProductCategory",
                principalColumn: "Categoryid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TBLPropertyName_Category_TBLPropertyName_PropertyNameId",
                table: "TBLPropertyName_Category",
                column: "PropertyNameId",
                principalTable: "TBLPropertyName",
                principalColumn: "PropertyNameId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TBLPropertyValue_TBLProducts_Productid",
                table: "TBLPropertyValue",
                column: "Productid",
                principalTable: "TBLProducts",
                principalColumn: "Productid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TBLPropertyValue_TBLPropertyName_PropertyNameId",
                table: "TBLPropertyValue",
                column: "PropertyNameId",
                principalTable: "TBLPropertyName",
                principalColumn: "PropertyNameId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
