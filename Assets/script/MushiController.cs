using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushiController : MonoBehaviour
{
    float speed;
    int direction;
    // Start is called before the first frame update
    void Start()
    {
        this.speed = 0.01f + Random.value * 0.1f;
        this.direction = Random.Range(0, 360);
        transform.Rotate(new Vector3(0, 0, 360 - direction));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Mathf.Sin(direction * Mathf.Deg2Rad) * speed, Mathf.Cos(direction * Mathf.Deg2Rad) * speed, 0, Space.World);

        int deltaDirection = Random.Range(-1, 2);
        this.direction = this.direction + deltaDirection;
        transform.Rotate(new Vector3(0, 0, 360 - deltaDirection));
    }
}
