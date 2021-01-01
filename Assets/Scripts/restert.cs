using UnityEngine;
using System.Collections;

public class restert : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space))
        {
            ButtonPush.swich = 0; //ボタンを押したらswichに0を代入
            Application.LoadLevel("Title 1");
        }
    }
}
