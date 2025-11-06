using UnityEngine;

public class GoingDown : MonoBehaviour
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




        if (5.5 >= place.x && place.x >= 4.5)
        {
            if (-4.5 >= place.z && place.z >= -5.5)
            {
                if (place.y > groundposition)
                {
                    transform.Translate(Time.deltaTime * speed * Vector3.down);
                }

                if (place.y < groundposition)
                {

                    place.y = groundposition;

                }


            }

        }
    }

}
   
