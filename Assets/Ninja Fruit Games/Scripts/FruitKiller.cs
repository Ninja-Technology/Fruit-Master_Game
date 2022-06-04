using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitKiller : MonoBehaviour
{
    /// <summary>
    /// Destroy(other.gameObject); 
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject); 
    }


}
