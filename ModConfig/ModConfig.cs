namespace Millwright.ModConfig
{
    public class ModConfig
    {
        public static ModConfig Loaded { get; set; } = new ModConfig();
        public double SailCenteredModifier { get; set; } = 2.0;
        public double SailAngledModifier { get; set; } = 2.0;
    }
}
