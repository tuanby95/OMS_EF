namespace OMS_EF
{
    [TestClass]
    public class UnitTest1
    {
        private MyDbContext _db;

        [TestInitialize]
        public void Init()
        {
            _db = new MyDbContext();
            _db.Database.EnsureCreated();
        }

        [TestMethod]
        public void GetCountryTest()
        {
            var country = _db.Countries.FirstOrDefault (e => e.Id == 1);
            Assert.IsNotNull(country);
        }

        [TestMethod]
        public void GetChannelTest()
        {
            var channel = _db.Channels.FirstOrDefault(e => e.Id == 1);
            Assert.IsNotNull(channel);
        }

        [TestCleanup]
        public void Dispose()
        {
            _db.Dispose();
        }
    }
}