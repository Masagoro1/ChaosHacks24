using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTracker : MonoBehaviour
{
    public Transform objectToTrack;
    float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        speed = Random.value();
    }

    // Update is called once per frame
    void Update()
    {
        // Track the object
        transform.LookAt(objectToTrack);

        // Movement code
        // Change value for step (speed)
        gameObject.position = Vector3.MoveTowards(gameObject.position, objectToTrack.position, speed * Time.deltaTime);
    }
}
