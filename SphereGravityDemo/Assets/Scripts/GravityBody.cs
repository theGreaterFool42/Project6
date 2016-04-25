using UnityEngine;
using System.Collections;

public class GravityBody : MonoBehaviour
{
    public Attractor attractor;
    private Transform transformObject;
    // Use this for initialization
    void Start()
    {
        this.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        this.GetComponent<Rigidbody>().useGravity = false;
        transformObject = transform;
    }

    // Update is called once per frame
    void Update()
    {
        attractor.Attract(transformObject);
    }
}
