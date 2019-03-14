using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class main : MonoBehaviour {


   // public GameObject card1, card2, card3, card4, card5;
    //public GameObject cardEnable1, cardEnable2, cardEnable3, cardEnable4, cardEnable5;
    public Animation anin;
    public int x, coll;

    public GameObject[] card,cardEnable,col,colEnable;

    public Sprite[] tumb;
    public Image bg;

    // Use this for initialization
    void Start () {
       
        x = 1;

        for (int i = 0; i < card.Length; i++)
        {
                bg = cardEnable[i].GetComponent<Image>();
                bg.sprite = tumb[i];
            
        }
        for (int j = 0; j < card.Length; j++)
        {
            bg = colEnable[j].GetComponent<Image>();
            bg.sprite = tumb[j];
        }
        
	}
	
	// Update is called once per frame
	void Update () {

        if(coll == 1)
        {
            MangerCol1();
        }
        if(coll == 2)
        {
            MangerCol2();
        }
        InpuKey();

    }

    void InpuKey()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if(x == 0)
            {
                x = x = card.Length - 1;
            }
            else
            {
                x = x - 1;

            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            x = x + 1;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            coll = 2;
            card[x].SetActive(false);
            cardEnable[x].SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            coll = 1;
            col[x].SetActive(false);
            colEnable[x].SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if(coll == 1)
            {
                Debug.Log(col[x]);

            }
            if(coll == 2)
            {
                Debug.Log(card[x]);
            }
        }
       
    }

    void MangerCol1()
    {
        if (x == 0)
        {
            card[0].SetActive(true);
            cardEnable[0].SetActive(false);
            card[0].GetComponent<Animation>().Play("animation_card");
            

        }
        else
        {
            card[0].SetActive(false);
            cardEnable[0].SetActive(true);
        }
        if (x == 1)
        {
            card[1].SetActive(true);
            cardEnable[1].SetActive(false);
            card[1].GetComponent<Animation>().Play("animation_card");

        }
        else
        {
            card[1].SetActive(false);
            cardEnable[1].SetActive(true);
        }

        if (x == 2)
        {
            card[2].SetActive(true);
            cardEnable[2].SetActive(false);
            card[2].GetComponent<Animation>().Play("animation_card");

        }
        else
        {
            card[2].SetActive(false);
            cardEnable[2].SetActive(true);
        }

        if (x == 3)
        {
            card[3].SetActive(true);
            cardEnable[3].SetActive(false);
            card[3].GetComponent<Animation>().Play("animation_card");

        }
        else
        {
            card[3].SetActive(false);
            cardEnable[3].SetActive(true);
        }

        if (x == 4)
        {
            card[4].SetActive(true);
            cardEnable[4].SetActive(false);
            card[4].GetComponent<Animation>().Play("animation_card");

        }
        else
        {
            card[4].SetActive(false);
            cardEnable[4].SetActive(true);
        }
    }

    void MangerCol2()
    {
        if (x == 0)
        {
            col[0].SetActive(true);
            colEnable[0].SetActive(false);
            col[0].GetComponent<Animation>().Play("animation_card");

        }
        else
        {
            col[0].SetActive(false);
            colEnable[0].SetActive(true);
        }
        if (x == 1)
        {
            col[1].SetActive(true);
            colEnable[1].SetActive(false);
            col[1].GetComponent<Animation>().Play("animation_card");

        }
        else
        {
            col[1].SetActive(false);
            colEnable[1].SetActive(true);
        }

        if (x == 2)
        {
            col[2].SetActive(true);
            colEnable[2].SetActive(false);
            col[2].GetComponent<Animation>().Play("animation_card");

        }
        else
        {
            col[2].SetActive(false);
            colEnable[2].SetActive(true);
        }

        if (x == 3)
        {
            col[3].SetActive(true);
            colEnable[3].SetActive(false);
            col[3].GetComponent<Animation>().Play("animation_card");

        }
        else
        {
            col[3].SetActive(false);
            colEnable[3].SetActive(true);
        }

        if (x == 4)
        {
            col[4].SetActive(true);
            colEnable[4].SetActive(false);
            col[4].GetComponent<Animation>().Play("animation_card");

        }
        else
        {
            col[4].SetActive(false);
            colEnable[4].SetActive(true);
        }
    }
}
