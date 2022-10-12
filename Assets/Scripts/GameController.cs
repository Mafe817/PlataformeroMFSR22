using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public int level = 0;

    public GameObject winSpot;
    private BoxCollider2D winCollider;
     public GameObject player;
    private BoxCollider2D playerCollider;

    public GameObject[] checksPoints;
    // Start is called before the first frame update
    void Start()
    {
        winCollider = winSpot.GetComponent<BoxCollider2D>();
        playerCollider = player.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {



        if(winCollider.IsTouching(playerCollider)){
            SceneManager.LoadScene("Level" + (level+1));
        }

      foreach (var checkponint in checksPoints)
      {
        BoxCollider2D checksPointsCollider = 
        checkponint.GetComponent<BoxCollider2D>();

        if(checksPointsCollider.IsTouching(playerCollider)){
            
             player.GetComponent<Player>().respawpoint= player.transform.position;
            
        }
      }

      if(Input.GetKeyDown(KeyCode.Escape)){
        Pause();
      }
       
    }

    public void Pause(){
        if(Time.timeScale >0){
                Time.timeScale = 0;
        }else{
                Time.timeScale = 1;
        }
    }
}
