using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public float moveSpeed;
    
    
    private bool isMoving;

    private Rigidbody2D playerRB;
    private Vector3 input;
    

    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (!isMoving)
        {
            input = Vector3.zero;
            input.x = Input.GetAxisRaw("Horizontal");
            input.y = Input.GetAxisRaw("Vertical");

           // if (input.x != 0) input.y = 0;
            
            if (input != Vector3.zero)
            {
                moveCharacter();

            }
        }
    }

    void moveCharacter()
    {
        isMoving = true;
        playerRB.MovePosition(transform.position + input.normalized * moveSpeed * Time.deltaTime);
        isMoving = false;
    }
   /*IEnumerator Move(Vector3 targetPos)
    {
        isMoving = true;
        
        while ((targetPos - transform.position).sqrMagnitude > Mathf.Epsilon)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
            yield return null;
        }

        transform.positio    n = targetPos;

        isMoving = false;
    }*/

}
