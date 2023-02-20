using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Rigidbody rb;

   void OnCollisionEnter (Collision coliisionInfo)
   {
    Debug.Log(coliisionInfo.collider.name);
    if (coliisionInfo.collider.name == "ground")
    {
        rb.constraints = RigidbodyConstraints.FreezeAll;
    }
    if (coliisionInfo.collider.name == "Cube")
    {
        rb.constraints = RigidbodyConstraints.FreezeAll;
    }
   }
}
