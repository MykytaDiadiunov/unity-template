using Assets.Scripts.Architecture.Interactors;

namespace Assets.Scripts.Configs.Game
{
    class GameConfig: SceneConfig
    {
        public override void InitializeInteractors()
        {
            interactors.CreateAndInitializeInteractorByType<PlayerInteractor>();
        }
    }
}
