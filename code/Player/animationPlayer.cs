using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class animationPlayer : MonoBehaviour {

    public Sprite sprite1; // Drag your first sprite here
    public Sprite sprite2; // Drag your second sprite here

    public Sprite spriteG1;
    public Sprite spriteG2;

    public Sprite exp1;
    public Sprite exp2;
    public Sprite exp3;

    int i = 0;
    int k = 0;

    public static bool ded = false;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
        if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
            spriteRenderer.sprite = sprite1; // set the sprite to sprite1
    }

    void Update()
    {
            ChangeTheDamnSprite(); // call method to change sprite
    }

    void ChangeTheDamnSprite()
    {
        if (transform.position.y > -4.2 && ded == false)
        {
            if (k == 0)
            {
                spriteRenderer.sprite = sprite2;
                i = i + 1;
            }
            if (i == 5)
            {
                k = 1;
            }
            if (k == 1)
            {
                spriteRenderer.sprite = sprite1;
                i = i - 1;
            }
            if (i == 0)
            {
                k = 0;
            }

        }
        else if (ded == false)
        {
            if (k == 0)
            {
                spriteRenderer.sprite = spriteG2;
                i = i + 1;
            }
            if (i == 5)
            {
                k = 1;
            }
            if (k == 1)
            {
                spriteRenderer.sprite = spriteG1;
                i = i - 1;
            }
            if (i == 0)
            {
                k = 0;
            }
        }
        if(ded == true)
        {
            i = i + 1;
            if(i == 5)
            {
                spriteRenderer.sprite = exp1;
            }
            if(i == 10)
            {
                spriteRenderer.sprite = exp2;
            }
            if(i == 15)
            {
                spriteRenderer.sprite = exp3;
            }
            if(i == 18)
            {
                i = 0;
                animationPlayer.ded = false;
                SceneManager.LoadScene("DeadScreen");
            }
        }
    }
}
