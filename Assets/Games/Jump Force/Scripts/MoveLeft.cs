using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 20;
    private PlayerController PlayerCS;
    private float leftbound = -15;
    // Start is called before the first frame update
    void Start()
    {
        PlayerCS = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerCS.gameOver == false){
        transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if(transform.position.x < leftbound && gameObject.CompareTag("Obstacle")){
            Destroy(gameObject);
        }
    }
}
