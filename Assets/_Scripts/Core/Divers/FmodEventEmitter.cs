﻿using UnityEngine;
using System.Collections;

public class FmodEventEmitter : MonoBehaviour
{
    public string additionnalName = "";
    public Transform addIdOfObject;

    private FMODUnity.StudioEventEmitter emitter;   //l'emitter attaché à l'objet


    void Start()
    {
        emitter = gameObject.GetComponent<FMODUnity.StudioEventEmitter>();  //init l'emitter
        string addParent = (addIdOfObject) ? addIdOfObject.GetInstanceID().ToString() : "";
        if (emitter && emitter.Event != "")
            SoundManager.GetSingleton.AddKey(emitter.Event + additionnalName + addParent, this);
    }

    /// <summary>
    /// play l'emmiter
    /// </summary>
    public void play()
    {
        if (!gameObject || !emitter)
            return;
        SendMessage("Play");
    }

    /// <summary>
    /// stop l'emmiter
    /// </summary>
    public void stop()
    {
        if (!gameObject || !emitter)
            return;
        SendMessage("Stop");
    }

    /// <summary>
    /// change les paramettres de l'emmiter
    /// </summary>
    /// <param name="paramName"></param>
    /// <param name="value"></param>
    public void setParameterValue(string paramName, float value)
    {
        if (!gameObject || !emitter)
            return;
        emitter.SetParameter(paramName, value);
    }
}
