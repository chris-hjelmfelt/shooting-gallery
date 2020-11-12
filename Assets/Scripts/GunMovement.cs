using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunMovement : MonoBehaviour
{
    float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton (1)) {
            if (Input.GetAxis ("Mouse X") != 0) {
                transform.position += new Vector3 (Input.GetAxisRaw ("Mouse X") * Time.deltaTime * speed, 
                                        Input.GetAxisRaw ("Mouse Y") * Time.deltaTime * speed,  0.0f);
            }
    
            if (Input.GetAxis ("Mouse Y") < 0) {
                transform.position += new Vector3 (Input.GetAxisRaw ("Mouse X") * Time.deltaTime * speed, 
                                        Input.GetAxisRaw ("Mouse Y") * Time.deltaTime * speed, 0.0f);
            }
        }
    }
}
