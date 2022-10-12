using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{

   // public bool indestructible = false;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Hit(){
        
            Destroy(gameObject);
        
        
    }

    protected void OnTriggerEnter2D(Collider2D collider){

         Player player = collider.GetComponent<Player>();
         if(player != null){
        player.GetComponent<Rigidbody2D>().AddForce(new Vector2(player.horizontal, 1f) * 300f);
            player.Hit();
            }
    }
}
