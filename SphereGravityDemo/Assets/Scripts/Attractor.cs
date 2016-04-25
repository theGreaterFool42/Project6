using UnityEngine;
using System.Collections;

public class Attractor : MonoBehaviour
{

    public float gravity = -9.81f;
    public void Attract(Transform gravityObject)
    {
        Vector3 gravityUp = (gravityObject.position - transform.position).normalized;
        Vector3 gravityObjectUp = gravityObject.up;

        gravityObject.GetComponent<Rigidbody>().AddForce(gravityUp * gravity);

        Quaternion targetRotation = Quaternion.FromToRotation(gravityObjectUp, gravityUp) * gravityObject.rotation;
        gravityObject.rotation = Quaternion.Slerp(gravityObject.rotation, targetRotation, 50 * Time.deltaTime);
    }

}
