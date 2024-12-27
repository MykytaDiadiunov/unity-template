using Assets.Scripts.Architecture.BaseClasses.Abstractions;
using Assets.Scripts.Architecture.Facades;
using Assets.Scripts.Architecture.Repositories;
using TMPro.EditorUtilities;

namespace Assets.Scripts.Architecture.Interactors
{
    public class PlayerInteractor : Interactor
    {
        public int Coins => playerRepository.Coins;

        private PlayerRepository playerRepository;

        public PlayerInteractor()
        {
            playerRepository = new PlayerRepository();
            playerRepository.Initialize();
        }

        public override void Initialize()
        {
            PlayerFacade.Initialize(this);
        }

        public void SaveByDefault()
        {
            playerRepository.SaveByDefault();
        }

        public void AddCoins(int count)
        {
            playerRepository.Coins += count;
            playerRepository.Save();
        }

        public void SpendCoins(int count)
        {
            playerRepository.Coins -= count;
            playerRepository.Save();
        }
    }
}

