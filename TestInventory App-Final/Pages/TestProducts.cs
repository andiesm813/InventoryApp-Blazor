using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Inventory_App_Final.Pages;
using Inventory_App_Final.InventoryApp;

namespace TestInventory_App_Final
{
	public class TestProducts
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgniteUI.Blazor.Controls.IgbButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
				typeof(IgniteUI.Blazor.Controls.IgbInputModule),
				typeof(IgniteUI.Blazor.Controls.IgbCardModule),
				typeof(IgniteUI.Blazor.Controls.IgbIconButtonModule));
			var mockHttpClient = new MockHttpClient().Create();
			ctx.Services.AddSingleton(new InventoryAppService(mockHttpClient));
			var componentUnderTest = ctx.RenderComponent<Products>();
			Assert.NotNull(componentUnderTest);
		}
	}
}