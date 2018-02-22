using UnityEngine;
using Sirenix.OdinInspector;
using System.Collections.Generic;


/// <summary>
/// GameManager Description
/// </summary>
public class GameManager : MonoBehaviour
{
    #region Attributes

    [FoldoutGroup("Scenes"), Tooltip("liens du levelManager"), SerializeField]
    private MenuManager menuManager;
    public MenuManager MenuManagerScript { set { menuManager = value; InitMenulWhenLoaded(); } }

    [FoldoutGroup("Scenes"), Tooltip("liens du levelManager"), SerializeField]
    private LevelManager levelManager;
    public LevelManager LevelManager { set { levelManager = value; InitLevelWhenLoaded(); } }


    [FoldoutGroup("Debug"), Tooltip("opti fps"), SerializeField]
	private FrequencyTimer updateTimer;


    private static GameManager instance;
    public static GameManager GetSingleton
    {
        get { return instance; }
    }

    #endregion

    #region Initialization
    /// <summary>
    /// singleton
    /// </summary>
    public void SetSingleton()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }

    private void Awake()
    {
        SetSingleton();
    }

    /// <summary>
    /// est appelé quand le menu est chargé !
    /// </summary>
    private void InitMenulWhenLoaded()
    {
        Debug.Log("menu ready");
    }

    /// <summary>
    /// appelé lorsque le level viens de se charger
    /// </summary>
    private void InitLevelWhenLoaded()
    {
        ScoreManager.GetSingleton.ResetAll();   //reset les scores
        levelManager.StartGame();               //commence le jeu (spawn etc);
    }
    #endregion

    #region Core

    #endregion

    #region Unity ending functions

	#endregion
}
