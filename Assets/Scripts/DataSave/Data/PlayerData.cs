using System;

namespace Assets.Scripts.DataSave.Data
{
    [Serializable]
    public class PlayerData
    {
        public int Coins { get; set; }
        public PlayerData()
        {
            Coins = 0;
        }
    }
}




