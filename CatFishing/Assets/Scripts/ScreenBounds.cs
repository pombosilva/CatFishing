using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenBounds : MonoBehaviour
{
    public Camera MainCamera; //be sure to assign this in the inspector to your main camera
    private Vector2 screenBounds;
    private float objectHeight;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = MainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, MainCamera.transform.position.z));
        objectHeight = transform.GetComponent<SpriteRenderer>().bounds.extents.y;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 viewPos = transform.position;
        viewPos.y = Mathf.Clamp(viewPos.y, -screenBounds.y + objectHeight, 3);
        transform.position = viewPos;
    }
}
