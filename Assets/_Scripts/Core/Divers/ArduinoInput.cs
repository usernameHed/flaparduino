using UnityEngine;
using Sirenix.OdinInspector;
using System.IO.Ports;
/// <summary>
/// ArduinoInput Description
/// </summary>
public class ArduinoInput : MonoBehaviour
{
    #region Attributes
    SerialPort sp = new SerialPort("COM6", 9600);

    private int jump = -1;
    public bool Jump { get { return (jump == 1); } }
    #endregion

    #region Initialization

    private void Start()
    {
        sp.Open();
        sp.ReadTimeout = 1;
    }
    #endregion

    #region Core
    private void Update()
    {
        if (sp.IsOpen)
        {
            try
            {
                //print(sp.ReadLine());
                jump = int.Parse(sp.ReadLine());

                /*jump = sp.ReadByte();
                if (jump == 1)
                {
                    Debug.Log("jump: " + jump);
                }
                else if (jump == 2)
                {
                    Debug.Log("no jump: " + jump);
                }
                */

            }
            catch (System.Exception)
            {
                Debug.Log("exeption...");
            }
        }
        else
            Debug.Log("not open");
    }
    #endregion

    #region Unity ending functions

    #endregion
}
