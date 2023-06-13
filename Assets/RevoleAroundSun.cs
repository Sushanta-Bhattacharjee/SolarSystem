using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevoleAroundSun : MonoBehaviour
{
    public Transform earth;

    public Transform sun;
    // Start is called before the first frame update
    void Start()
    {
        //sun = GameObject.FindGameObjectWithTag("sun").transform;
        //sun = GameObject.Find("Sun").transform;
    }


    // Update is called once per frame
    void Update()
    {
    earth.RotateAround(sun.transform.position, Vector3.up, 20 * Time.deltaTime);
    }
}
