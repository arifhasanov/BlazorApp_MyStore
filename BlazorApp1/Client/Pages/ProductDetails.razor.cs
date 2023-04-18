using System.Runtime.CompilerServices;

namespace BlazorApp1.Client.Pages
{
    public partial class ProductDetails
    {
        [Inject] IProductService ProductService { get; set; }
        private Product? currentProduct = null;
        private string? message = string.Empty;
        private int currentTypeId = 1;

        [Parameter] public int Id { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            message = "Loading product...";

            var result = await ProductService.GetProduct(Id);
            if (!result.Success)
            {
                message = result.Message;
            }
            else
            {
                currentProduct = result.Data;
                if (currentProduct.Variants.Count > 0)
                {
                    currentTypeId = currentProduct.Variants[0].ProductTypeId;
                }
            }
        }

        private ProductVariant GetSelectedVariant()
        {
            var variant = currentProduct.Variants.FirstOrDefault(v => v.ProductTypeId == currentTypeId);
            return variant;
        }


        public ProductDetails()
        {
            
        }
    }
}
