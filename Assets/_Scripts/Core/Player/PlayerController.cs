using UnityEngine;
using Sirenix.OdinInspector;
using System.Collections.Generic;
using System;

/// <summary>
/// PlayerController handle player movement
/// <summary>
public class PlayerController : MonoBehaviour, IKillable
{
    #region Attributes

    [FoldoutGroup("GamePlay"), Tooltip("liens du levelManager"), SerializeField]
    private float speed = 5f;
    [FoldoutGroup("GamePlay"), Tooltip("liens du levelManager"), SerializeField]
    private float jumpForce = 10f;
    [FoldoutGroup("GamePlay"), Tooltip("liens du levelManager"), SerializeField]
    private float jumpForceDown = 1f;

    [FoldoutGroup("Objects"), Tooltip("liens du levelManager"), SerializeField]
    private ArduinoInput arduino;

    private float horiz = 0;
    private float verti = 0;
    private bool jump = false;

    [FoldoutGroup("Debug"), Tooltip("id unique du joueur correspondant à sa manette"), SerializeField]
    private int idPlayer = 0;
    public int IdPlayer { get { return idPlayer; } }

    private Rigidbody playerBody;
    private FrequencyTimer updateTimer;
    
    #endregion

    #region Initialize

    private void Awake()
	{
        InitPlayer();
	}

    /// <summary>
    /// initialise les players: créé les balls et les ajoutes dans la liste si la liste est vide
    /// </summary>
    private void InitPlayer()
    {
        Debug.Log("init player");
        playerBody = GetComponent<Rigidbody>();
    }

    #endregion

    #region Core

    /// <summary>
    /// input of player for both joystick
    /// </summary>
    private void InputPlayer()
    {
        //jump = PlayerConnected.GetSingleton.getPlayer(idPlayer).GetButtonDown("FireA");
        jump = (arduino.Jump == idPlayer + 1);
    }

    /// <summary>
    /// move le player
    /// </summary>
    private void MovePlayer()
    {
        //playerBody.MovePosition(transform.position + transform.forward * speed * Time.deltaTime);
        playerBody.AddForce(Vector3.up * -jumpForceDown, ForceMode.Acceleration);
        //playerBody.AddForce();

        if (jump)
        {
			playerBody.velocity = Vector3.zero;
            playerBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            jump = false;

        }
    }


    #endregion

    #region Unity ending functions
    /// <summary>
    /// input du joueur
    /// </summary>
    private void Update()
	{
        InputPlayer();
    }

	private void FixedUpdate()
	{
        MovePlayer();
	}

    #endregion


    [FoldoutGroup("Debug"), Button("Kill")]
    public void Kill()
	{
		Debug.Log ("Player dead !");
        Destroy(gameObject);
	}
}