using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    
    public float bottomLimit = -35;

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        
        // Destroy balls if y position is less than bottomLimit
        if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
        }
        
    }
}
