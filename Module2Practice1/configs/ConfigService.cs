namespace Module2Practice1.Configs
{
    public class ConfigService
    {
        private static readonly ConfigService Self;
        static ConfigService()
        {
            Self = new ConfigService();
        }

        private ConfigService()
        {
            Config = new Config()
            {
                CartConfig = new CartConfig()
                {
                    Capasity = 7
                }
            };
        }

        public Config Config { get; private set; }
        public static ConfigService Instance => Self;
    }
}