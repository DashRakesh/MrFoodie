using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    Rigidbody2D myRigidbody;
    [SerializeField] float arrowSpeed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        myRigidbody.velocity = new Vector2(0f, arrowSpeed);
    }
     void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Fruits"))
        {
            Fruits.magnetActive = true;
        }
    //    if(other.tag == "Fruits")
  //      {
     //       Fruits.magnetActive = true;
           // Destroy(other.gameObject);
     //   }
        Destroy(gameObject);
    }
}
