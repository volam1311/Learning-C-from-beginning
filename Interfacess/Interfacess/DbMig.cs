namespace Interfacess
{
    public class DbMig
    {
        private readonly ILogger _logger;
        public DbMig(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo("Migrating started at {0}" + DateTime.Now);
            _logger.LogInfo("Migrating finised at {0}" + DateTime.Now);
        }
    }
}
