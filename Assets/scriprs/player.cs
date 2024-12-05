using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float moveH;
    public float moveV;
    public int velocidade;
    private Vector3 posInicial;
    private Animator anim;
    private SpriteRenderer sprite;

    


    // Start is called before the first frame update
    void Start()
    {
        posInicial = transform.position;
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        moveH = Input.GetAxis("Horizontal");
        moveV = Input.GetAxis("Vertical");

        transform.position += new Vector3(moveH * velocidade * Time.deltaTime, 0, 0);
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.D) && moveH > 0)
        {
            sprite.flipX = false;
            anim.SetLayerWeight(1,1);
        }

        else if(Input.GetKey(KeyCode.A) && moveH < 0)
        {
            sprite.flipX = true;
            anim.SetLayerWeight(1,1);
        }

        else
        {
            anim.SetLayerWeight(1,0);
        }

        if(Input.GetKey(KeyCode.Mouse0))
        {
            anim.SetLayerWeight(4,1);
        }

        else
        {
            anim.SetLayerWeight(4,0);
        }
        
        if(Input.GetKey(KeyCode.LeftShift))
        {
            anim.SetLayerWeight(2,1);
        }

        else
        {
            anim.SetLayerWeight(2,0);
        }
        
    }
}
