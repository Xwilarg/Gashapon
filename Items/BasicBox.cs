using Terraria.ID;
using Terraria.ModLoader;

namespace Gashapon.Items
{
	public class BasicBox : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Basic Box");
			Tooltip.SetDefault("A cool box for all your basic needs");
		}

		public override void SetDefaults() 
		{
			item.value = 1;
			item.rare = ItemRarityID.Gray;
			item.useStyle = 0;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.consumable = true;
			// Item.createTile = ModContent.TileType<ExampleMusicBoxTile>();
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}