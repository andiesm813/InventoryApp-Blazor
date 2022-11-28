using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Inventory_App_Final.Pages;

namespace TestInventory_App_Final
{
	public class TestChildView
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgniteUI.Blazor.Controls.IgbButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
				typeof(IgniteUI.Blazor.Controls.IgbDropdownModule),
				typeof(IgniteUI.Blazor.Controls.IgbDropdownItemModule));
			var componentUnderTest = ctx.RenderComponent<ChildView>();
			Assert.NotNull(componentUnderTest);
		}
	}
}