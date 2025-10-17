using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float sideSpeed = 5.0f;
    private float horizontalInput;
    public float forwardInput;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       horizontalInput = Input.GetAxis("horizontal");
        forwardInput = Input.GetAxis("vertical"); 

        //move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Rotate(Vector3.up, sideSpeed * horizontalInput * Time.deltaTime);

    
    }
}
