using UnityEngine;
using System.Collections;

public class Swirler : MonoBehaviour
{
    public float speed = 1.0f;
    public float radius = 10.0f;
    public float pullInPower = 1;
    public float noGArea = 15.0f;


    Collider[] colliders;
    void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, radius);
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, noGArea);
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(transform.parent.transform.position, Vector3.up, speed);
        colliders = Physics.OverlapSphere(transform.position, radius);
        foreach (Collider c in colliders)
        {
            if (c.GetComponent<Rigidbody>() != null)
            {
                Rigidbody rigidbody = c.GetComponent<Rigidbody>();
                Ray ray = new Ray(transform.position, c.transform.position - transform.position);
                RaycastHit hit;
                Physics.Raycast(ray, out hit);
                if (hit.distance > noGArea)
                {
                    //if (c.transform.position.z < 8.5)
                    {
                        Debug.DrawLine(transform.position, hit.point, Color.magenta);
                        Vector3 Force = new Vector3((transform.position.x - c.transform.position.x) + 2, rigidbody.velocity.y / 3, (transform.position.z - c.transform.position.z) + 2) * pullInPower;
                        rigidbody.AddForceAtPosition(Force, transform.position);
                    }
                    rigidbody.AddForceAtPosition((transform.position - c.transform.position) * pullInPower, transform.position);
                }
            }
        }
    }
}
