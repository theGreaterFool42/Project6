using UnityEngine;
using System.Collections;

public class TornadoGravity : MonoBehaviour
{
    public float radius = 10.0f;
    public float noGArea = 5.0f;
    public int layerMask = 1 << 8;
    public float pullInPower = -70.0f;
    public float upThrow = 15.0f;


    Collider[] colliders;
    // Use this for initialization
    void Start()
    {
        //layerMask = ~layerMask;
    }

    void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, radius);
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, noGArea);
    }

    // Update is called once per frame
    void Update()
    {
        colliders = Physics.OverlapSphere(transform.position, radius);
        foreach (Collider c in colliders)
        {
            if ((c.GetComponent<Rigidbody>() != null) && (c.gameObject.name != "Tornado"))
            {
                Ray ray = new Ray(transform.position, c.transform.position - transform.position);
                RaycastHit hit;
                Physics.Raycast(ray, out hit);
                //Debug.DrawLine(transform.position, c.transform.position/* - transform.position*/, Color.red);
                if (hit.collider != null)
                {
                    if ((hit.collider.name == c.gameObject.name) && (hit.distance > noGArea))
                    {
                        Debug.DrawLine(ray.origin, hit.point, Color.red);
                        Rigidbody rigidbody = c.GetComponent<Rigidbody>();
                        rigidbody.AddExplosionForce(pullInPower, /*transform.position*/ new Vector3(transform.position.x, transform.position.y + upThrow, transform.position.z), radius);
                        //print(hit.distance);
                        //print("collider: " + hit.collider);
                        //print("gameObject: " + c.gameObject);
                    } 
                }
            }
        }
    }
}
