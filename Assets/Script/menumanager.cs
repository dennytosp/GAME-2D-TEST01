using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menumanager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
     public void Player(){
      
    SceneManager.LoadScene("Scenes/Play");
    
    }
     public void Board(){
      
    SceneManager.LoadScene("Scenes/LEADERBOARD");
    
    }
}
