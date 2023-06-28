using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomizeBuilding : MonoBehaviour
{
    public GameObject scene;
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Left mouse button clicked
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                string objectName = hit.collider.gameObject.name;
                Debug.Log("Clicked on object: " + objectName);
                if (objectName == "NorthSide")
                {
                    scene.transform.rotation = new Quaternion(0, 180, 0, 0);
                }
                else if (objectName == "WestSide")
                {
                    scene.transform.rotation = new Quaternion(0, 270, 0, 0);
                }
                else if (objectName == "EastSide")
                {
                    Debug.Log("turning to east");
                    scene.transform.rotation = new Quaternion(0, 90, 0, 0);
                }
                else if (objectName == "SouthSide")
                {
                    scene.transform.rotation = new Quaternion(0, 0, 0, 0);
                }
            }
        }
    }
}
