using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyScript : MonoBehaviour
{
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            // Icrement Score
            
            GameManager.instance.IncrementScore();

            Destroy(gameObject);
} 
        else if(collider.gameObject.tag == "Boundary")
        {
            // Decrement Life

            GameManager.instance.DecreaseLife();
            Destroy(gameObject);
        }
    }
}
