using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody sphereRigidbody;
    public float ballSpeed = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Calling the Start method");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 inputVector = Vector2.zero; 
       if (Input.GetKey(KeyCode.W)){
         inputVector += Vector2.left;
        }
        if (Input.GetKey(KeyCode.A)){
           
            inputVector += Vector2.down;
        
        }
        if (Input.GetKey(KeyCode.S)){
          inputVector += Vector2.right;
        }
        if (Input.GetKey(KeyCode.D)){
        inputVector += Vector2.up;
        }
   Vector3 inputXZPlane = new(inputVector.x, 0, inputVector.y);
    sphereRigidbody.AddForce(inputXZPlane*ballSpeed);
    }
}
