using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDestruction : MonoBehaviour
{
    [SerializeField]
    float distance;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        // 0 is the left button
        if(Input.GetMouseButtonDown(0)){
            // Get distance between mousepoint and projectile
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 gameObjectPosition = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);
            distance = Vector2.Distance(mousePosition, gameObjectPosition);
            if (distance<1 && distance>-1){
                // Immediately 
                Destroy(gameObject);
                GameObject.FindWithTag("Health").GetComponent<HealthManager>().Heal(10);
                GameObject.FindWithTag("Points").GetComponent<Points>().pointsUP();
            }
        }
    }
}
