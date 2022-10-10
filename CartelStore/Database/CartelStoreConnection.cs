using CartelStore.ADOApp;

namespace CartelStore.Database
{
    public static class CartelStoreConnection
    {
        private static CartelStoreEntitiesBulat _context = new CartelStoreEntitiesBulat();
        public static CartelStoreEntitiesBulat Connection => _context;
    }
}