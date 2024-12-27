
using Assets.Scripts.Architecture.BaseClasses.Abstractions;
using Assets.Scripts.Architecture.Interactors;
using System;
using System.Collections.Generic;

namespace Assets.Scripts.Architecture
{
    public class InteractorsBase
    {
        private Dictionary<Type, Interactor> interactors = new();

        public void CreateInteractors()
        {
            CreateInteractor<PlayerInteractor>();
        }

        public void InitializeInteractors() 
        {
            foreach (var interactor in interactors.Values) 
            { 
                interactor.Initialize(); 
            }
        }

        private void CreateInteractor<T>() where T : Interactor, new()
        {
            var interactor = new T();
            interactors.Add(typeof(T), interactor);
        }
    }
}
