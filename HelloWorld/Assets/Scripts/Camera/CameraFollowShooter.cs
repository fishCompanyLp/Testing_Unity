using UnityEngine;
using System.Collections;

public class CameraFollowShooter : MonoBehaviour
{

    Transform otherTransform;

    void Start()
    {
        // you can set a reference to the "parent" cube
        otherTransform = GameObject.Find("ShooterPlayer").transform;
    }

    void Update()
    {
        // here we force the position of the current object to have the same y as the parent
        transform.position = new Vector3(otherTransform.position.x, otherTransform.position.y + 2, transform.position.z);
    }
}
