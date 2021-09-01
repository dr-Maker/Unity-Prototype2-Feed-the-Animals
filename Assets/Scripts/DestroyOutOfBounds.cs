using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    public float topBound = 20f;
    public float bottomBound = -7f;


    // Update is called once per frame
    void Update()
    {

        if (this.transform.position.z > topBound )
        {
            Destroy(this.gameObject);
        }


        if (this.transform.position.z < bottomBound)
        {
            Destroy(this.gameObject);
            Debug.Log("GAME OVER");
            Time.timeScale = 0;
        }

    }
}
