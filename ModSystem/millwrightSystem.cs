namespace Millwright.ModSystem
{
    using Vintagestory.API.Common;
    using Millwright.ModConfig;

    public class MillwrightSystem : ModSystem
    {
        public void RegisterClasses(ICoreAPI api)
        {
            api.RegisterBlockClass("BlockWindmillRotorEnhanced", typeof(BlockWindmillRotorEnhanced));
            api.RegisterBlockEntityBehaviorClass("BEBehaviorWindmillRotorEnhanced", typeof(BEBehaviorWindmillRotorEnhanced));
        }
        public override void Start(ICoreAPI api)
        {
            base.Start(api);
            this.RegisterClasses(api);
        }

        public override void StartPre(ICoreAPI api)
        {
            var cfgFileName = "millwright.json";
            try
            {
                ModConfig fromDisk;
                if ((fromDisk = api.LoadModConfig<ModConfig>(cfgFileName)) == null)
                { api.StoreModConfig(ModConfig.Loaded, cfgFileName); }
                else
                { ModConfig.Loaded = fromDisk; }
            }
            catch
            { api.StoreModConfig(ModConfig.Loaded, cfgFileName); }
            base.StartPre(api);
        }
    }
}
