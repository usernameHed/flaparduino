using UnityEngine;
using Sirenix.OdinInspector;
using TMPro;
using System;
using System.Collections.Generic;

/// <summary>
/// LevelManager Description
/// </summary>
public class LevelManager : MonoBehaviour
{
    #region Attributes

    #endregion

    #region Initialization

    private void Awake()
    {
        GameManager.GetSingleton.LevelManager = this;
    }
    #endregion

    #region Core
    /// <summary>
    /// appelé depuis le gameManager quand tout semble bon
    /// </summary>
    public void StartGame()
    {
        Debug.Log("start game from level Manager");
    }

    #endregion

    #region Unity ending functions

    #endregion
}
