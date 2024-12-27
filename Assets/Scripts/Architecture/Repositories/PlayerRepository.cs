using Assets.Scripts.Architecture.BaseClasses.Interfaces;
using Assets.Scripts.DataSave;
using Assets.Scripts.DataSave.Data;

namespace Assets.Scripts.Architecture.Repositories
{
    public class PlayerRepository : IRepository
    {
        public int Coins { get; set; }

        private PlayerData playerData;
        private Storage storage;

        public void Initialize()
        {
            storage = new Storage("playerdata");
            playerData = (PlayerData)storage.Load(new PlayerData());
            LoadAllData();
        }

        public void Save()
        {
            SaveAllData();
            storage.Save(playerData);
        }

        public void SaveByDefault()
        {
            storage.Save(new PlayerData());
        }

        private void LoadAllData()
        {
            Coins = playerData.Coins;
        }

        private void SaveAllData()
        {
            playerData.Coins = Coins;
        }
    }
}

