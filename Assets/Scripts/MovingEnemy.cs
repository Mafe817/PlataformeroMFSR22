using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingEnemy : Enemy
{
    public float speed = 5f;
    public float direction = 1f;
    public float directionTimeChange = 5f;
    private Rigidbody2D rigidBody2D;

    private GameObject wallR;

      private GameObject wallL;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        //StartCoroutine(DirectionChange());
        wallR = transform.parent.Find("WallR").gameObject;
        wallL = transform.parent.Find("WallL").gameObject;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
       rigidBody2D.velocity = new Vector2(direction, rigidBody2D.velocity.y);
    }

    //IEnumerator DirectionChange(){
      //  while(true){
        //yield return new WaitForSeconds(directionTimeChange);
        //Turn();
        //}
    //}

    private new void OnTriggerEnter2D(Collider2D collider){
        base.OnTriggerEnter2D(collider);
        if(collider.gameObject == wallL || collider.gameObject == wallR){
            Turn();
        }
    }

    private void Turn(){
         direction = direction * -1; 
        transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
    }

}
