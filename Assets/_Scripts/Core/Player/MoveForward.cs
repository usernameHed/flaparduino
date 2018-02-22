using UnityEngine;
using Sirenix.OdinInspector;
using System.Collections.Generic;
using System;

/// <summary>
/// PlayerController handle player movement
/// <summary>
public class MoveForward : MonoBehaviour
{
    #region Attributes

    [FoldoutGroup("GamePlay"), Tooltip("speed"), SerializeField]
    private float speed = 5f;

    [FoldoutGroup("Object"), Tooltip("rb"), SerializeField]
    private Rigidbody rb;
    
    #endregion

    #region Initialize

    #endregion

    #region Core


    /// <summary>
    /// move le player
    /// </summary>
    private void MoveObject()
    {
        
        if (rb)
            rb.MovePosition(transform.position + transform.forward * speed * Time.deltaTime);
        //else
          //  transform.Translate(Vector3.forward * speed * Time.deltaTime);
        //transform.position += Vector3.forward * speed * Time.deltaTime;

    }


    #endregion

    #region Unity ending functions
    /// <summary>
    /// input du joueur
    /// </summary>
    private void FixedUpdate()
	{
        MoveObject();
    }

    #endregion


    [FoldoutGroup("Debug"), Button("Kill")]
    public void Kill()
	{
		Debug.Log ("Player dead !");
        Destroy(gameObject);
	}
}