using UnityEngine;

public class playerControler : MonoBehaviour
{
    public Rigidbody rb;
    public Transform playPoint;
    public float Force = 2000f;
    void FixedUpdate()
    {
        

        if(Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(Force*Time.deltaTime,0,0);
            Debug.Log("work");

        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-Force*Time.deltaTime,0,0);
            Debug.Log("back");
        }
    }
}
