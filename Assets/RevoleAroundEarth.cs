using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevoleAroundEarth : MonoBehaviour
{
    public Transform earth;

    public Transform moon;
    // Start is called before the first frame update
    void Start()
    {
        earth = GameObject.FindGameObjectWithTag("earth").transform;
    }

    // Update is called once per frame
    void Update()
    {
        moon.RotateAround(earth.transform.position, Vector3.up, -20 * Time.deltaTime);
    }
}
