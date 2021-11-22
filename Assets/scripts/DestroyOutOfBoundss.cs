using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundss : MonoBehaviour
{
    private float upperLim = 30f;
    private float lowerLim = -10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Bala out of Bounds
        if(transform.position.z > upperLim) 
                {
            Destroy(gameObject);
        }
        //Animal out of bounds

        if(transform.position.z < lowerLim)
        {
            Destroy(gameObject);
        }
    }
}
