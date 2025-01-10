using Assets.Scripts.Configs.Game;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Architecture
{
    public class InteractorsInitializer : MonoBehaviour
    {
        private SceneConfig config;

        private void Awake()
        {
            string currentSceneName = SceneManager.GetActiveScene().name;

            switch (currentSceneName)
            {
                case "Game":
                    config = new GameConfig();
                    config.InitializeInteractors();
                    break;
                default:
                    throw new System.Exception("Configuration does not exist!");
            }
            Debug.Log(currentSceneName);
        }
    }
}

