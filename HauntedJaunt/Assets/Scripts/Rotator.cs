using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public GameObject player;

    private Vector3 angles;

    void Start()
    {
        angles = new Vector3(0.0f, 1.0f, 0.0f);
    }

    void FixedUpdate()
    {
        Vector3 distance = player.transform.position - transform.position;

        distance.Normalize();

        float angle = Mathf.Rad2Deg * Mathf.Acos(Vector3.Dot(Vector3.forward, distance));

        Vector3 cross = Vector3.Cross(Vector3.forward, distance);

        if (cross.y < 0.0f)
        {
            angle = -angle;
        }

        angles.y = angle;

        transform.eulerAngles = angles;
    }
}
