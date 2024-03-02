using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDestruction : MonoBehaviour
{
    //ADDED PROJECTILE OBJECT TO GET THE LOCATION
    public GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //CIRCLE CAST 
        //Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        //int circleCastArray[] = CircleCast(mousePosition, 1.0f, Vector2 direction, Mathf.Infinity, DefaultRaycastLayers, -Mathf.Infinity,Mathf.Infinity);
        //                                                 Radius
        //if (bool containsProjectile = circleCastArray.Contains(gameObject.transform.position)){
        //    Destroy(gameObject, t=0.0f);
        //}

        // 0 is the left button
        while (Input.GetMouseButtonDown(0)){
            // Get distance between mousepoint and projectile
            Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 gameObjectPosition = new Vector2(Input.gameObject.x, Input.gameObject.y);
            distance = Vector2.Distance(mousePosition, gameObjectPosition);
            if (distance<1){
                // Immediately 
                Destroy(gameObject, t = 0.0f);
            }
        }
    }
}
