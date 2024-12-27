using UnityEngine;

namespace Assets.Scripts.Architecture
{
    public class InteractorsInitializer : MonoBehaviour
    {
        private InteractorsBase interactors;
        private void Awake()
        {
            interactors = new InteractorsBase();

            interactors.CreateInteractors();

            interactors.InitializeInteractors();
        }
    }
}

