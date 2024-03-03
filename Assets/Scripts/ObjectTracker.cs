using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTracker : MonoBehaviour
{
    public Transform objectToTrack;
    float speed = 1;
    float health;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        objectToTrack = GameObject.FindWithTag("Player").transform;
        speed = Random.Range(15.0f, 25.0f);
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(new Vector3(Random.Range(-1.0f, 1.0f) / (health / 100), Random.Range(-1.0f, 1.0f) / (health / 100), 0));
        timer += Time.deltaTime;
        if(timer > 30)
        {
            Destroy(gameObject);
        }
        // Track the object
        transform.LookAt(objectToTrack);
        health = GameObject.FindWithTag("Health").GetComponent<HealthManager>().healthAmount;
        if(health <= 0)
        {
            health = 1;
        }
        // Movement code
        // Change value for step (speed)
        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, objectToTrack.position, 0.1f * speed * Time.deltaTime);
        if(Random.Range(0,100) > (95 + 0.05f * health))
        {
            transform.Translate(new Vector2(Random.Range(-1.0f, 1.0f) / (health/100), Random.Range(-1.0f, 1.0f) / (health / 100)));
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, objectToTrack.position, 0.035f * speed);
        }
    }
}
