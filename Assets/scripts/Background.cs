using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Background : MonoBehaviour
{

    
    public Image baseimg;
    public Sprite[] sprite;
    private main man;
    public int x, idAnim;
    public Text desc, title;

    public Animation anim;

    // Start is called before the first frame update
    void Start()
    {
       man = GameObject.FindGameObjectWithTag("Manager").GetComponent<main>();
       
    }

    // Update is called once per frame
    void Update()
    {
        x = man.x;
        SliderBackground();
        ManagerAnim();
    }

    void SliderBackground()
    {
        switch (x)
        {
            case 0:
                idAnim = 0;
                baseimg.sprite = sprite[0];
                title.text = "titulo jogo 1";
                desc.text = "Descrição jogo 1";

                break;
            case 1:
                idAnim = 1;
                baseimg.sprite = sprite[1];
                title.text = "titulo jogo 2";
                desc.text = "Descrição jogo 2";

                break;
            case 2:
                idAnim = 2;
                baseimg.sprite = sprite[2];
                title.text = "titulo jogo 3";
                desc.text = "Descrição jogo 3";
               
                break;
            case 3:
                baseimg.sprite = sprite[3];
                title.text = "titulo jogo 4";
                desc.text = "Descrição jogo 4";
                break;
            case 4:
                baseimg.sprite = sprite[4];
                title.text = "titulo jogo 5";
                desc.text = "Descrição jogo 5";
                break;
        }
    }

    void ManagerAnim()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            anim.GetComponent<Animation>().Play("backgroundHove");

        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            anim.GetComponent<Animation>().Play("backgroundHove");

        }


    }
}
