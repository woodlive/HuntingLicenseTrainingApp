using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Debug.Log(Input.mousePosition);
        transform.position = new Vector3(Input.mousePosition.x / 1200*12.5f, Input.mousePosition.y / 890 * 6.5f, -1.0f);
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        ray.origin = new Vector3(ray.origin.x, ray.origin.y, Mathf.Abs(ray.origin.y));
        Debug.Log(Camera.main.ScreenPointToRay(Input.mousePosition));
        Debug.DrawRay(Camera.main.transform.position, ray.origin, Color.red, 2);

        if (Physics.Raycast(ray, out hit, 20f))
        {
            Transform objectHit = hit.transform;

            Debug.DrawRay(Camera.main.transform.position, hit.point, Color.yellow);
            Debug.Log("Did Hit");

            // Do something with the object that was hit by the raycast.
        }


        // Vector3 input = Input.mousePosition;
    }
}
