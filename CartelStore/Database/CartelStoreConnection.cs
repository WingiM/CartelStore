using CartelStore.ADOApp;

namespace CartelStore.Database
{
    public static class CartelStoreConnection
    {
        private static CartelStoreEntities _context = new CartelStoreEntities();
        public static CartelStoreEntities Connection => _context;
    }
}