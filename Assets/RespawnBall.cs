using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnBall : MonoBehaviour
{
    public Transform ballPosition;
    public float minimumYValue;
    //public Transform defaultPosition;
    public float spawnX;
    public float spawnY;
    public float spawnZ;

    public Rigidbody ballVelocity;

    // Start is called before the first frame update
    void Start()
    {
        spawnX = ballPosition.position.x;
        spawnY = ballPosition.position.y;
        spawnZ = ballPosition.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        if (ballPosition.position.y < minimumYValue)
        {
            ballPosition.SetPositionAndRotation(new Vector3(spawnX, spawnY, spawnZ), Quaternion.identity);
            ballVelocity.velocity = Vector3.zero;
            ballVelocity.angularVelocity = Vector3.zero;
        }
    }
}
