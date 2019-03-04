using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAgent : MonoBehaviour
{
    public GameObject self;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
       if(other.tag == "Enemy")
        {
            Destroy(self);
        }
    }
}
