using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenStripeController : MonoBehaviour
{
  private Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        position.z = GameObject.Find("Ball").transform.position.z;
        transform.position = position;
    }
}
