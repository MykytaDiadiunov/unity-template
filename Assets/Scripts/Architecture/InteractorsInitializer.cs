using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Architecture
{
    public class InteractorsInitializer : MonoBehaviour
    {
        private const string SCENE_CONFIGS_PATH = "Configs/Scene/";

        [SerializeField] private string configName;

        private InteractorsBase interactorsBase;

        private void Awake()
        {
            try
            {
                SceneConfig sceneConfig = Resources.Load<SceneConfig>(SCENE_CONFIGS_PATH + configName);
                if (sceneConfig != null )
                    Debug.Log("Configuration loaded!");
                else
                    throw new Exception("Invalid configuration name or configuration does not exist!");

                interactorsBase = new InteractorsBase();
                interactorsBase.CreateAndInitializeInteractorsByTypeArray(sceneConfig.GetInteractorTypes());

            } 
            catch (Exception exp)
            {
                Debug.LogException(exp);
            }
        }
    }
}

