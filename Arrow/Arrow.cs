class Arrow
{
    // Properties with only getters (read-only outside constructor)
    private PriceList _priceList;
    public MaterialType Arrowhead { get; }
    public MaterialType Fletching { get; }
    public float Length { get; }

    public Arrow(MaterialType arrowhead, MaterialType flethcing, float length)
    {
        Arrowhead = arrowhead;
        Fletching = flethcing;
        Length = length;
    }
    public float GetCost()
    {
        float shaftCost = 0.05f * Length;
        return shaftCost + PriceList.GetPrice(Arrowhead) + PriceList.GetPrice(Fletching);
    }
    public static Arrow CreateEliteArrow()
    {
        return new Arrow(MaterialType.Steel, MaterialType.Plastic, 95f);
    }
    public static Arrow CreateBeginnerArrow()
    {
        return new Arrow(MaterialType.Wood, MaterialType.GooseFeathers, 75f);
    }
    public static Arrow CreateMarksmanArrow()
    {
        return new Arrow(MaterialType.Steel, MaterialType.GooseFeathers, 65f);
    }
}