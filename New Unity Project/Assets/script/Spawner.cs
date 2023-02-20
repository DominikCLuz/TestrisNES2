using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Transform transform;

    // Update is called once per frame
    void Start()
    {
        Debug.Log("criou");
        StartCoroutine(Rain());
       
    }

    private IEnumerator Rain(){
        bool run = true;
        while (run)
        {
            int burst = Random.Range(8,30);
            float random_time = 2;
            for (int i = 0; i < burst; i++)
            {
                Instantiate(objectToSpawn,transform.position, Quaternion.identity);
            }
            yield return new WaitForSeconds(random_time);
        }
    }
}
