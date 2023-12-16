
using MonkeyLoader.Configuration;
using MonkeyLoader.Resonite;
using System;

namespace HelloWorld2
{
    public class HelloWorld2Monkey : ResoniteMonkey<HelloWorld2Monkey>, IHelloWorld2
    {
        public override string Name => "HelloWorld2";

        private HelloWorld2MonkeyConfig LoadedConfig;

        public bool Enabled => LoadedConfig.Enabled.GetValue();

        public void DoSomething()
        {
            Logger.Warn(() => "Hello World!");
        }

        protected override bool OnEngineReady()
        {
            LoadedConfig = Config.LoadSection<HelloWorld2MonkeyConfig>();
            PatchesHarmony.Apply(this);
            return base.OnEngineReady();
        }

        protected override void OnEngineShutdownRequested(string reason)
        {
            base.OnEngineShutdownRequested(reason);
        }

        protected override bool OnLoaded()
        {
            return base.OnLoaded();
        }

        protected override bool OnShutdown()
        {
            return base.OnShutdown();
        }

        private class HelloWorld2MonkeyConfig : ConfigSection
        {
            public DefiningConfigKey<bool> Enabled = new DefiningConfigKey<bool>("Enabled", "Enables a small message on each button click.", () => true);

            public override string Description => "MonkeyLoader flavor of sample mod's config";

            public override string Name => "HelloWorld2";

            public override Version Version => new Version(1, 0, 0);
        }
    }
}
