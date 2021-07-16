using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{

    float timer;
    float maxTime;

    float chooseObstacle;
    GameObject obstacle;

    public GameObject obstacle1;
    public GameObject obstacle2;
    public GameObject obstacle3;
    public GameObject obstacle4;
    public GameObject obstacle5;


    // Start is called before the first frame update
    void Start(){
        maxTime = 1f;
    }

    // Update is called once per frame
    void Update(){

        timer += Time.deltaTime;
        if (timer > maxTime){
            timer = 0;
            generateObstacle();
        }
    }
    
    void generateObstacle(){

        
        chooseObstacle = Random.Range(1, 8);

        switch(chooseObstacle) {
            case 1 :
                obstacle = obstacle1;
                break;
            case 2 :
                obstacle = obstacle2;
                break;
            case 3 :
                obstacle = obstacle3;
                break;
            case 4 :
                obstacle = obstacle4;
                break;
            case 5 :
                obstacle = obstacle5;
                break;
        }

        if (obstacle != null){
            GameObject newObstacle = Instantiate(obstacle);
        }
    }

    

}
