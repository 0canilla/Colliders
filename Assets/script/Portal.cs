using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    private GameObject Player;
    private float shrinkTimeout = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (shrinkTimeout > 0f)
        {
            shrinkTimeout -= Time.deltaTime;
        }
    }

    void startShrinkTimeout(float time = 0.75f)
    {
        shrinkTimeout = time;
    }

    bool canShrink()
    {
        return shrinkTimeout <= 0f;
    }

    void OnTriggerEnter(Collider collider)
    {
        {
            if (canShrink())
            {
                startShrinkTimeout();
                Player.GetComponent<PlayerController>().ToggleSize();
            }
        }
    }
}
