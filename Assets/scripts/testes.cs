using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testes : MonoBehaviour
{
    public Animation anim;
    public int Ncol;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ncol = main.coll;

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if(Ncol == 1)
                anim.GetComponent<Animation>().Play("animcol1");
            if(Ncol == 2)
                anim.GetComponent<Animation>().Play("animcol2");
            if (Ncol == 3)
                anim.GetComponent<Animation>().Play("animcol3");
            if (Ncol == 4)
                anim.GetComponent<Animation>().Play("animcol4");
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (Ncol == 5)
                anim.GetComponent<Animation>().Play("animcolUP4");
            if (Ncol == 4)
                anim.GetComponent<Animation>().Play("animcolUP3");
            if (Ncol == 3)
                anim.GetComponent<Animation>().Play("animcolUP2");
            if (Ncol == 2)
                anim.GetComponent<Animation>().Play("animcolUP1");
        }
    }  
        IEnumerator menu()
        {
            yield return new WaitForSeconds(0.45f);
            anim.GetComponent<Animation>().Stop("anim-scroll");

        yield break;
        }
}
