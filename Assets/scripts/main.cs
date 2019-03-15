using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class main : MonoBehaviour {


   // public GameObject card1, card2, card3, card4, card5;
    //public GameObject cardEnable1, cardEnable2, cardEnable3, cardEnable4, cardEnable5;
    public Animation anin;
    public static int coll;
    public int x;

    public GameObject[] col1,colEnable1,col2,colEnable2,col3,colEnable3;

    public Sprite[] tumb;
    public Image bg,bgEnable;
   

    // Use this for initialization
    void Start () {
        coll = 1;
        x = 2;

        for (int i = 0; i < col1.Length; i++)
        {
                bg = colEnable1[i].GetComponent<Image>();
                bgEnable = col1[i].GetComponent<Image>();
                bg.sprite = tumb[i];
                bgEnable.sprite = tumb[i];            
        }

        for (int j = 0; j < col1.Length; j++)
        {
            bg = colEnable2[j].GetComponent<Image>();
            bgEnable = col2[j].GetComponent<Image>();
            bg.sprite = tumb[j];
            bgEnable.sprite = tumb[j];
        }

        for (int n = 0; n < col1.Length; n++)
        {
            bg = colEnable3[n].GetComponent<Image>();
            bgEnable = col3[n].GetComponent<Image>();
            bg.sprite = tumb[n];
            bgEnable.sprite = tumb[n];
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
        if (coll == 3)
        {
            MangerCol3();
        }
        InpuKey();

    }

    void InpuKey()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if(x == 0)
            {
                x = x = col1.Length - 1;
            }
            else
            {
                x = x - 1;

            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if(x == col1.Length - 1)
            {
                x = 0;
            }else
            {
                x = x + 1;
            }
            
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            coll = coll + 1;
            col1[x].SetActive(false);
            colEnable1[x].SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            coll = coll - 1;
            col2[x].SetActive(false);
            colEnable2[x].SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if(coll == 1)
            {
                Debug.Log(col2[x]);

            }
            if(coll == 2)
            {
                Debug.Log(col1[x]);
            }
        }
       
    }

    void MangerCol1()
    {
        if (x == 0)
        {
            col1[0].SetActive(true);
            colEnable1[0].SetActive(false);
            

        }
        else
        {
            col1[0].SetActive(false);
            colEnable1[0].SetActive(true);
        }
        if (x == 1)
        {
            col1[1].SetActive(true);
            colEnable1[1].SetActive(false);

        }
        else
        {
            col1[1].SetActive(false);
            colEnable1[1].SetActive(true);
        }

        if (x == 2)
        {
            col1[2].SetActive(true);
            colEnable1[2].SetActive(false);

        }
        else
        {
            col1[2].SetActive(false);
            colEnable1[2].SetActive(true);
        }

        if (x == 3)
        {
            col1[3].SetActive(true);
            colEnable1[3].SetActive(false);

        }
        else
        {
            col1[3].SetActive(false);
            colEnable1[3].SetActive(true);
        }

        if (x == 4)
        {
            col1[4].SetActive(true);
            colEnable1[4].SetActive(false);

        }
        else
        {
            col1[4].SetActive(false);
            colEnable1[4].SetActive(true);
        }
    }

    void MangerCol2()
    {
        if (x == 0)
        {
            col2[0].SetActive(true);
            colEnable2[0].SetActive(false);
            

        }
        else
        {
            col2[0].SetActive(false);
            colEnable2[0].SetActive(true);
        }
        if (x == 1)
        {
            col2[1].SetActive(true);
            colEnable2[1].SetActive(false);

        }
        else
        {
            col2[1].SetActive(false);
            colEnable2[1].SetActive(true);
        }

        if (x == 2)
        {
            col2[2].SetActive(true);
            colEnable2[2].SetActive(false);

        }
        else
        {
            col2[2].SetActive(false);
            colEnable2[2].SetActive(true);
        }

        if (x == 3)
        {
            col2[3].SetActive(true);
            colEnable2[3].SetActive(false);

        }
        else
        {
            col2[3].SetActive(false);
            colEnable2[3].SetActive(true);
        }

        if (x == 4)
        {
            col2[4].SetActive(true);
            colEnable2[4].SetActive(false);

        }
        else
        {
            col2[4].SetActive(false);
            colEnable2[4].SetActive(true);
        }
    }

    void MangerCol3()
    {
        if (x == 0)
        {
            col3[0].SetActive(true);
            colEnable3[0].SetActive(false);


        }
        else
        {
            col3[0].SetActive(false);
            colEnable3[0].SetActive(true);
        }
        if (x == 1)
        {
            col3[1].SetActive(true);
            colEnable3[1].SetActive(false);

        }
        else
        {
            col3[1].SetActive(false);
            colEnable3[1].SetActive(true);
        }

        if (x == 2)
        {
            col3[2].SetActive(true);
            colEnable3[2].SetActive(false);

        }
        else
        {
            col3[2].SetActive(false);
            colEnable3[2].SetActive(true);
        }

        if (x == 3)
        {
            col3[3].SetActive(true);
            colEnable3[3].SetActive(false);

        }
        else
        {
            col3[3].SetActive(false);
            colEnable3[3].SetActive(true);
        }

        if (x == 4)
        {
            col3[4].SetActive(true);
            colEnable3[4].SetActive(false);

        }
        else
        {
            col3[4].SetActive(false);
            colEnable3[4].SetActive(true);
        }
    }
}
