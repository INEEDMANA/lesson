using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    public int HeightBrick;
    public int WidthBrick;
    public int LengthBrick;
    public int LengthPit;
    public int WidthPit;
    // Use this for initialization
    void Start()
    {
        if (WidthBrick >= WidthPit)
        {
            Debug.Log(" Your brick is very wide for this hole on WidthBrick = " + WidthBrick);

        }


        if (LengthBrick >= LengthPit)
        {
            Debug.Log(" Your brick is very long for this hole on  LenhtgBrick = " + LengthBrick);
        }
        else Debug.Log("All right , Your brick is in a pit ");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
