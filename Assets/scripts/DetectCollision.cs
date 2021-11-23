using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider otherCollider)
    {
        //Destruir proyectil
        Destroy(gameObject);
        //Destruir el animal contra el que colisiono
        Destroy(otherCollider.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
