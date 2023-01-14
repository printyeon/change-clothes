using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drag : MonoBehaviour
{
   // bool[] tf = new bool[10];


    public GameObject pic1;
    public GameObject pic1b;

    public GameObject pic2;
    public GameObject pic2b;

    public GameObject pic3;
    public GameObject pic3b;

    public GameObject pic4;
    public GameObject pic4b;

    public GameObject pic5;
    public GameObject pic5b;

    public GameObject pic6;
    public GameObject pic6b;

    public GameObject pic7;
    public GameObject pic7b;

    public GameObject pic8;
    public GameObject pic8b;

    public GameObject pic9;
    public GameObject pic9b;

    public GameObject pic10;
    public GameObject pic10b;

    Vector2 pic1Pos;
    Vector2 pic2Pos;
    Vector2 pic3Pos;
    Vector2 pic4Pos;
    Vector2 pic5Pos;
    Vector2 pic6Pos;
    Vector2 pic7Pos;
    Vector2 pic8Pos;
    Vector2 pic9Pos;
    Vector2 pic10Pos;

    // Start is called before the first frame update
    private void Start()
    {
     
                pic1Pos = pic1.transform.position;
                pic2Pos = pic2.transform.position;
                pic3Pos = pic3.transform.position;
                pic4Pos = pic4.transform.position;
                pic5Pos = pic5.transform.position;
                pic6Pos = pic6.transform.position;
                pic7Pos = pic7.transform.position;
                pic8Pos = pic8.transform.position;
                pic9Pos = pic9.transform.position;
                pic10Pos = pic10.transform.position;
     }

    private void Update()
    {
    }

    public void Dragpic1()
    { 
        pic1.transform.position = Input.mousePosition;
    }

    public void Droppic1()
    {
        float Distance1 = Vector2.Distance(pic1.transform.position, pic1b.transform.position);
        if (Distance1 < 200)
        {
            pic1.transform.position = pic1b.transform.position;
           //tf[0] = true;

        }
        else
        {
            pic1.transform.position = pic1Pos;
        }
    }



    public void Dragpic2()
    {
        pic2.transform.position = Input.mousePosition;
    }

    public void Droppic2()
    {
        float Distance1 = Vector2.Distance(pic2.transform.position, pic2b.transform.position);
        if (Distance1 < 200)
        {
            pic2.transform.position = pic2b.transform.position;
            //tf[1] = true;

        }
        else
        {
            pic2.transform.position = pic2Pos;
        }
    }


    public void Dragpic3()
    {
        pic3.transform.position = Input.mousePosition;
    }

    public void Droppic3()
    {
        float Distance1 = Vector2.Distance(pic3.transform.position, pic3b.transform.position);
        if (Distance1 < 200)
        {
            pic3.transform.position = pic3b.transform.position;
            //tf[2] = true;

        }
        else
        {
            pic3.transform.position = pic3Pos;
        }
    }


    public void Dragpic4()
    {
        pic4.transform.position = Input.mousePosition;
    }

    public void Droppic4()
    {
        float Distance1 = Vector2.Distance(pic4.transform.position, pic4b.transform.position);
        if (Distance1 < 200)
        {
            pic4.transform.position = pic4b.transform.position;
            //tf[3] = true;

        }
        else
        {
            pic4.transform.position = pic4Pos;
        }
    }


    public void Dragpic5()
    {
        pic5.transform.position = Input.mousePosition;
    }

    public void Droppic5()
    {
        float Distance1 = Vector2.Distance(pic5.transform.position, pic5b.transform.position);
        if (Distance1 < 200)
        {
            pic5.transform.position = pic5b.transform.position;
            //tf[4] = true;

        }
        else
        {
            pic5.transform.position = pic5Pos;
        }

        
    }



    public void Dragpic6()
    {
        pic6.transform.position = Input.mousePosition;
    }

    public void Droppic6()
    {
        float Distance1 = Vector2.Distance(pic6.transform.position, pic6b.transform.position);
        if (Distance1 < 200)
        {
            pic6.transform.position = pic6b.transform.position;
            //tf[5] = true;

        }
        else
        {
            pic6.transform.position = pic6Pos;
        }
    }


    public void Dragpic7()
    {
        pic7.transform.position = Input.mousePosition;
    }

    public void Droppic7()
    {
        float Distance7 = Vector2.Distance(pic7.transform.position, pic7b.transform.position);
        if (Distance7 < 200)
        {
            pic7.transform.position = pic7b.transform.position;
            //tf[6] = true;

        }
        else
        {
            pic7.transform.position = pic7Pos;
        }
    }


    public void Dragpic8()
    {
        pic8.transform.position = Input.mousePosition;
    }

    public void Droppic8()
    {
        float Distance8 = Vector2.Distance(pic8.transform.position, pic8b.transform.position);
        if (Distance8 < 200)
        {
            pic8.transform.position = pic8b.transform.position;
            //tf[7] = true;

        }
        else
        {
            pic8.transform.position = pic8Pos;
        }
    }


    public void Dragpic9()
    {
        pic9.transform.position = Input.mousePosition;
    }

    public void Droppic9()
    {
        float Distance9 = Vector2.Distance(pic9.transform.position, pic9b.transform.position);
        if (Distance9 < 200)
        {
            pic9.transform.position = pic9b.transform.position;
            //tf[8] = true;

        }
        else
        {
            pic9.transform.position = pic9Pos;
        }
    }


    public void Dragpic10()
    {
        pic10.transform.position = Input.mousePosition;
    }

    public void Droppic10()
    {
        float Distance10 = Vector2.Distance(pic10.transform.position, pic10b.transform.position);
        if (Distance10 < 200)
        {
            pic10.transform.position = pic10b.transform.position;
            //tf[9] = true;

        }
        else
        {
            pic10.transform.position = pic10Pos;
        }
    }
}
