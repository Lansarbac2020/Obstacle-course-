using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigidbody;
    [SerializeField] float timeTowait = 5f;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent <MeshRenderer>();
       rigidbody = GetComponent <Rigidbody> ();

     renderer.enabled = false;
      GetComponent<Rigidbody>().useGravity = false; 
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timeTowait)
        {
            renderer.enabled = true;
            GetComponent<Rigidbody>().useGravity = true;  
        }

    }
}


