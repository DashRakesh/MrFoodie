using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruits : MonoBehaviour
{
    CapsuleCollider2D myCapsuleCollider;
    [SerializeField] float DieDelay = 5f;
    [SerializeField] float timeTaken = 1f;
    private GameObject Box;

    public static bool magnetActive = false;
    

    // Start is called before the first frame update
    void Start()
    {
        Box = GameObject.FindWithTag("Box");
        myCapsuleCollider = GetComponent<CapsuleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //  if(!myCapsuleCollider.IsTouchingLayers(LayerMask.GetMask("Ground")))
        // {
        //   return;
        //  }
        //  else
        //    {
        //       Destroy(gameObject);
        //  }
        

        if (magnetActive == true)
        {
            MoveTowardsBox();
        }
        else
        {
            magnetActive = false;
        }

        StartCoroutine(FruitsDestroy());
    }
    IEnumerator FruitsDestroy()
    {
        yield return new WaitForSecondsRealtime(DieDelay);
        if (myCapsuleCollider.IsTouchingLayers(LayerMask.GetMask("Ground")))
        {
            Destroy(gameObject);
        }
      //  else
        //{
            
        //}
    }
    void MoveTowardsBox()
    {
        {
    
            transform.position = Vector3.Lerp(this.transform.position, Box.transform.position, timeTaken * Time.deltaTime);
        }
    }
}
