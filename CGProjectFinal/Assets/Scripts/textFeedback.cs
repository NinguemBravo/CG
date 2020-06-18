using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textFeedback : MonoBehaviour
{
    private int lifetime = 2;
    private float timeSpawned;
    // Start is called before the first frame update
    void Start()
    {
        timeSpawned = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - timeSpawned >= lifetime)
        {
            Destroy(gameObject);
        }

        transform.position += new Vector3(0, 0.1f, 0);
    }
}
