using Assets.Scripts.Architecture;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneConfig
{
    protected InteractorsBase interactors;

    public SceneConfig() 
    {
        interactors = new InteractorsBase();
    }

    public virtual void InitializeInteractors(){ }
}
