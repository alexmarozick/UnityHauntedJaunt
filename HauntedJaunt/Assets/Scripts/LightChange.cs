using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightChange : MonoBehaviour
{
    public GameObject traveling;
    public GameObject endpoint;
    Light m_Light;
    Vector3 pos;
    Vector3 pos2;

    public Vector4 startcolor;
    public Vector4 endcolor;
    // Start is called before the first frame update
    void Start()
    {

        Transform basiclevel = endpoint.GetComponent<Transform>();
        pos = basiclevel.position;
        m_Light = GetComponent<Light>();

        startcolor = startcolor / 255;
        endcolor = endcolor / 255;
    }

    // Update is called once per frame
    void Update()
    {
        pos2 = traveling.GetComponent<Transform>().position;
        Vector3 diff = pos2 - pos;
        float level = diff.magnitude;
        float color1 = 1.0f / 900f * (level * level);
        m_Light.color = Vector4.Lerp(endcolor, startcolor, color1);
    }
}
