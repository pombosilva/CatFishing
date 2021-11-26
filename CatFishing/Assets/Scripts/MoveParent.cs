using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MoveParent : MonoBehaviour {
    public int sideToSpawn = -1;
    private float baseVelocity = 2f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;
    public bool isCaught = false;
    // Start is called before the first frame update
    void Start() {
        transform.localScale = new Vector3(-sideToSpawn*transform.localScale.x, transform.localScale.y, transform.localScale.z);
        float velocity = baseVelocity + baseVelocity * getVelocity();
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-sideToSpawn*velocity, 0);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update() {
        if(Mathf.Abs(this.gameObject.transform.position.x) > screenBounds.x * 2f) {
            Destroy(this.gameObject);
        }
    }
    public abstract float getVelocity();
    public abstract void interact();
}
