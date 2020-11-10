    using UnityEngine;
    using System.Collections;
     
    public class GunFire : MonoBehaviour {

        public float fireRate = 0.5f;        
        private float nextFire = 0;  
        AudioSource bang;
        public Transform startPoint;
        public Transform endPoint;
     
        // Use this for initialization
        void Start () {
            
        }
       
        // Update is called once per frame
        void Update () {
           
            // Check if the player has pressed the fire button and if enough time has elapsed since they last fired
            if (Input.GetButtonDown("Fire1") && Time.time > nextFire) 
            {
                // Sound effects  
                bang = GetComponent<AudioSource>();              
                bang.Play();

                // Update the time when our player can fire next
                nextFire = Time.time + fireRate;

                // Declare a raycast hit to store information about what our raycast has hit
                RaycastHit hit;

                bool RayHit = Physics.Raycast (startPoint.position, endPoint.position, out hit, 100);
                // Check if our raycast has hit anything
                if (RayHit)
                {    
                    print(RayHit);
                    // Check if the object we hit has a rigidbody attached
                    // if (hit.rigidbody != null)
                    // {
                    //     print(RayHit);
                    //     // remove this object
                    //     //Destroy(hit);
                    // }
                }            
            
            }
        }
    }

