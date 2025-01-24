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

        public void CreateAndInitializeInteractorsByTypeArray(Type[] types)
        {
            foreach (Type interactorType in types)
            {
                if (!typeof(Interactor).IsAssignableFrom(interactorType))
                {
                    throw new ArgumentException($"Type {interactorType} does not inherit from Interactor");
                }

                Interactor interactor = (Interactor)Activator.CreateInstance(interactorType);
                if (!interactors.ContainsKey(interactorType))
                {
                    interactors.Add(interactorType, interactor);
                }

                interactor.Initialize();
            }
        }

        private Interactor CreateInteractor<T>() where T : Interactor, new()
        {
            var interactor = new T();
            interactors.Add(typeof(T), interactor);
            return interactor;
        }
    }
}
