using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Platform"){
            Destroy(this.gameObject);
        }

        //if(collision.gameObject.tag == "Player"){
        //    Destroy(this.gameObject); // 음식이 player와 닿으면 사라짐
        //}

        if(collision.gameObject.tag == "Food"){
            Destroy(this.gameObject);
        }


    }
}
