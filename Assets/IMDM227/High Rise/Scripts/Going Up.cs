using System;
using UnityEngine;
using UnityEngine.UIElements;

public class GoingUp : MonoBehaviour
{
    public float groundposition = 1;
    public float highposition = 10;
    public float speed = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 place = transform.position;
        
       

       
            if(0.5 >= place.x && place.x >= -0.5)
            {
                if(0.5 >= place.z && place.z >= -0.5)
                {
                    if (place.y < highposition)
                    {
                        transform.Translate(Time.deltaTime * speed * Vector3.up);
                    }

                    if(place.y > highposition)
                    {
                        
                        place.y = highposition;
                        
                    }
                    
                    
                }

            }
        }
    
}
