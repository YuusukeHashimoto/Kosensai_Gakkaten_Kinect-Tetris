using UnityEngine;
using System.Collections;

public class Restartgame01 : MonoBehaviour {

    public void CrickButton()
    {
        ButtonPush.swich = 0; //ボタンを押したらswichに0を代入

        Application.LoadLevel("gameover 1");
    }
}
