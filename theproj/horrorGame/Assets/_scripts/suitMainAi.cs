using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suitMainAi : MonoBehaviour
{
    // Start is called before the first frame update
    private bool patrolling;
    public float speed = 2.0f;
    public float minDist = 2.0f;
    void Start()
    {
        patrolling = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (patrolling)
        {
            bool hitLeft = false, hitRight = false, hitFront = false;
            int layerMask = 1 << 8;
            layerMask = ~layerMask;
            RaycastHit Fronthit, Lefthit, Righthit;
            /*if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Fronthit, Mathf.Infinity, layerMask))
            {
                hitFront = true;
            }
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.left), out Lefthit, Mathf.Infinity, layerMask))
            {
                hitLeft = true;
            }
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), out Righthit, Mathf.Infinity, layerMask))
            {
                hitRight = true;
            }

            
            if (Fronthit.distance <= minDist)
            {
                if (Lefthit.distance <= minDist && Righthit.distance <= minDist)
                {
                    transform.Rotate(0, 180, 0);
                }

                else if (Lefthit.distance <= minDist)
                {
                    transform.Rotate(0, 90, 0);
                }
                else if (Righthit.distance <= minDist)
                {
                    transform.Rotate(0, 270, 0);
                }
                else
                {
                    //transform.Rotate(0, 27, 0);
                    Debug.Log("yo!");
                }

                //Quaternion theChange = new Quaternion(0.0f, 180.0f, 0.0f, 1.0f);
            }*/


        }
 		Debug.Log("Calling transfom");
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
