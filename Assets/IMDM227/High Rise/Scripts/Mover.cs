using UnityEngine;
using UnityEngine.InputSystem;

public class Mover : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float speed = 1;
    public float rate = 60;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current.upArrowKey.isPressed)
        {
            transform.Translate(Time.deltaTime * speed * Vector3.forward);
        }

        if (Keyboard.current.downArrowKey.isPressed)
        {
            transform.Translate(Time.deltaTime * speed * Vector3.back);
        }

        if(Keyboard.current.rightArrowKey.isPressed)
        {
            transform.Rotate(0, Time.deltaTime * rate, 0);
        }

        if(Keyboard.current.leftArrowKey.isPressed)
        {
            transform.Rotate(0, Time.deltaTime * -rate, 0);
        }
    }
}
