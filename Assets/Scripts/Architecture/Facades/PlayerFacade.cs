using Assets.Scripts.Architecture.Interactors;

namespace Assets.Scripts.Architecture.Facades
{
    public static class PlayerFacade
    {
        public static int Coins {
            get
            {
                FacadeIsInitialized();
                return playerInteractor.Coins;
            }
            private set { }
        }


        private static PlayerInteractor playerInteractor;
        private static bool isInitialize;


        public static void AddCoins(int count)
        {
            FacadeIsInitialized();
            playerInteractor.AddCoins(count);
        }

        public static void SpendCoins(int count)
        {
            playerInteractor.SpendCoins(count);
        }

        public static void SaveByDefault()
        {
            playerInteractor.SaveByDefault();
        }

        public static void Initialize(PlayerInteractor interactor)
        {
            if(playerInteractor == null)
            {
                playerInteractor = interactor;
                isInitialize = true;
            }
        }

        private static void FacadeIsInitialized()
        {
            if(!isInitialize)
                throw new System.Exception("Facade not initialize!");
        }
    }
}
