class PriceList
{
    public static float GetPrice(MaterialType material)
    {
        return material switch
        {
            MaterialType.Steel => 10f,
            MaterialType.Wood => 3f,
            MaterialType.Obsidian => 5f,
            MaterialType.Plastic => 10f,
            MaterialType.TurkeyFeathers => 5f,
            MaterialType.GooseFeathers => 3f
        };
    }
}