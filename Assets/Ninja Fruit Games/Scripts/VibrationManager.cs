using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VibrationManager : MonoBehaviour
{
  public static VibrationManager instance;

    public void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);

    }

    public void VibrateController(float duration, float frequency, float amplitude, OVRInput.Controller controller)
    {
        StartCoroutine(VibrateForSeconds(duration, frequency, amplitude, controller));
    }

    IEnumerator VibrateForSeconds(float duration, float frequency, float amplitude, OVRInput.Controller controller)
    {
        //Start the vibration
        OVRInput.SetControllerVibration(frequency, amplitude, controller);

        //executing the vibration for the duration of time
        yield return new WaitForSeconds(duration);

        //Stop the vibration after the duration
        OVRInput.SetControllerVibration(0,0,controller);
    }
}
