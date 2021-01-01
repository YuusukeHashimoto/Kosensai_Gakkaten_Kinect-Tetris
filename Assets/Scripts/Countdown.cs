using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Countdown : MonoBehaviour {
    private float time = 120;
    public static int a =  0;

	// Use this for initialization
	void Start () {
        GetComponent<Text>().text = string.Format("{0:00}:{1:00}", (int)(time / 60), time % 60);
	
	}
	
	// Update is called once per frame
	void Update () {
        if (a == 1)
        {
            time -= Time.deltaTime;
            GetComponent<Text>().text = string.Format("{0:00}:{1:00}", (int)(time / 60), time % 60);
            if(time <= 0)
            {
                Application.LoadLevel("gameover 1");
                a = 0;
            }
        }
	}

   /* public void changea()
    {
        a = true;
    }*/

}
