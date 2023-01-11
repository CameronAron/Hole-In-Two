using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPlayer : MonoBehaviour
{
    public Transform playerPosition;
    public float minimumYValue;
    //public Transform defaultPosition;
    public float spawnX;
    public float spawnY;
    public float spawnZ;

    //public Rigidbody ballVelocity;

    // Start is called before the first frame update
    void Start()
    {
        spawnX = playerPosition.position.x;
        spawnY = playerPosition.position.y;
        spawnZ = playerPosition.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerPosition.position.y < minimumYValue)
        {
            playerPosition.SetPositionAndRotation(new Vector3(spawnX, spawnY, spawnZ), Quaternion.identity);
            //ballVelocity.velocity = Vector3.zero;
            //ballVelocity.angularVelocity = Vector3.zero;
        }
    }
}
