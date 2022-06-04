using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitPhysics : MonoBehaviour
{

    public float force = 30;
    // Start is called before the first frame update
    void Start()
    {
          GetComponent<Rigidbody>().AddForce(new Vector3(250,force,0),ForceMode.Acceleration);
    
    }
}
