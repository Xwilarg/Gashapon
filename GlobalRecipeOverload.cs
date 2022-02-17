using Terraria.ModLoader;

namespace Gashapon
{
    public class GlobalRecipeOverload : GlobalRecipe
    {
        public override bool RecipeAvailable(Terraria.Recipe recipe)
        {
            return recipe.createItem.Name == "Basic Box";
        }
    }
}
