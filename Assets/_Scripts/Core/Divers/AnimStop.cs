using UnityEngine;

/// <summary>
/// AnimStop Description
/// </summary>
public class AnimStop : MonoBehaviour
{
    #region Attributes
    public Animator anim;
    public string boolToStop = "Jump";
    #endregion

    #region Initialization


    #endregion

    #region Core
    public void StopAnim()
    {
        anim.SetBool(boolToStop, false);
    }
    #endregion

    #region Unity ending functions


	#endregion
}
