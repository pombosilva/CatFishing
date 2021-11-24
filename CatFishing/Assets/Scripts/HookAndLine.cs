using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookAndLine : MonoBehaviour
{
    public LineRenderer lr;
    public Transform hook;
    public float hookMoveSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        lr = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, hookMoveSpeed*Input.GetAxis("Vertical")*Time.deltaTime, 0f);
        lr.SetPosition(1, new Vector3(0, hook.position.y+0.05f, 0));
    }
}
