using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsY : MonoBehaviour
     
{
    private float leftLimit = 30;
    private float bottomLimit = -5;
    // Start is called before the first frame update
    void Start()
    {
        if (transform.position.y > leftLimit)
        {
            Destroy(gameObject);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
