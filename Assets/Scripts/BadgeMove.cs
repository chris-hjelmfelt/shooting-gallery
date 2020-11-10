using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadgeMove : MonoBehaviour
{
    bool bounce = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   float yLoc = 0.17f;
        float zLoc = 5.39f;
        if (transform.position.x <= 3 && bounce == false) {
            transform.position += new Vector3(1 * Time.deltaTime, 0, 0);
        } else if(transform.position.x >= -3) {
            transform.position -= new Vector3(1 * Time.deltaTime, 0, 0);    
            bounce = true;
        } else {
            transform.position = new Vector3(-3, yLoc, zLoc);
            bounce = false;
        }
    }
}
