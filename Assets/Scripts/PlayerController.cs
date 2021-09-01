using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    public float VerticalInput;
    public float speed;
    public Vector2 xRange = new Vector2(-15,15);
    public GameObject projectilPrefab;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Movimiento del jugador

        horizontalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");

        transform.Translate(speed * Vector3.right * Time.deltaTime * horizontalInput);
        transform.Translate(speed * Vector3.forward * Time.deltaTime * VerticalInput);

        if (this.transform.position.x < xRange.x)
        {
            this.transform.position = new Vector3(xRange.x, this.transform.position.y, this.transform.position.z);
        }

        if (this.transform.position.x > xRange.y)
        {
            this.transform.position = new Vector3(xRange.y, this.transform.position.y, this.transform.position.z);
        }


        // Acciones del jugador

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilPrefab, this.transform.position, this.transform.rotation);
        } 
     
    }
}
