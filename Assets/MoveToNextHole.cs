using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToNextHole : MonoBehaviour
{
    public string nextScene;

    public bool isBallInHole = false;

    public float nextHoleTimer = 0;

    // Start is called before the first frame update
    void Start()
    {
        nextHoleTimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (isBallInHole)
        {
            nextHoleTimer += Time.deltaTime;
        }

        if(nextHoleTimer > 10)
        {
            SceneManager.LoadScene(nextScene);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Ball"))
        {
            Debug.Log("Ball Went In the Hole");
            isBallInHole = true;
        }
    }
}
