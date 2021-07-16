using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public float startPosition;
    public float endPosition;
    // public GameObject gameObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);

        if (transform.position.x <= endPosition){
            if (gameObject.tag == "obstacle"){
                Destroy(gameObject);
            }else {
                transform.position = new Vector2(startPosition, transform.position.y);
            }
        }
    
    }
}
