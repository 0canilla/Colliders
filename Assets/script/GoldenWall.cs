using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldenWall : MonoBehaviour
{
    private float timeout = 2f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void teleport()
    {
        var random = new System.Random();
        transform.position = new Vector3(random.Next(-10, 10), random.Next(-10, 10), random.Next(-10, 10));
        transform.localRotation = new Quaternion(random.Next(-10, 10), random.Next(-10, 10), random.Next(-10, 10), random.Next(-10, 10));
    }

    private void OnCollisionStay(Collision collision)
    {
        timeout -= Time.deltaTime;

        if (timeout <= 0)
        {
            teleport();
            resetTimeout();
        }

    }

    void resetTimeout()
    {
        timeout = 2f;
    }
}
