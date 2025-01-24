using System;
using UnityEngine;

[CreateAssetMenu(fileName = "SceneConfig", menuName = "Configs/New Scene config")]
public class SceneConfig: ScriptableObject
{
    private const string INTERACTOR_TYPE_BASE = "Assets.Scripts.Architecture.Interactors.";
    public string[] InteractorTypeNames => interactorTypeNames;

    [SerializeField] private string[] interactorTypeNames;

    public Type[] GetInteractorTypes()
    {
        Type[] types = new Type[InteractorTypeNames.Length];
        for (int i = 0; i < InteractorTypeNames.Length; i++)
        {
            types[i] = Type.GetType(INTERACTOR_TYPE_BASE + InteractorTypeNames[i]);
        }
        return types;
    }
}
