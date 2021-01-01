using UnityEngine;
using System.Collections;

public class ButtonPush : MonoBehaviour {

    //Countdown countdown;
    public GameObject[] groups;
    public static int swich = 0;
    
    //画面上のボタン「Game Strat」を押した瞬間に一つ目のブロックを生成
    public void  ClickTest()
    {

        //countdown.changea();
        Countdown.a = 1;

        // Spawn Group at current Position
        Instantiate(groups[2],new Vector3(4.0f, 14.0f, 0.0f),Quaternion.identity);

        swich = 1; //ボタンを押したらswichに1を代入

        Destroy(GameObject.Find("Canvas/Text1"));//スタートボタンを押したら最初に表示されていたテキストを削除
        Destroy(GameObject.Find("Canvas/Button"));//スタートボタンを押したらスタートボタンを削除

        GameObject holeRootObj = GameObject.Find("Canvas");//スタートボタンを押したら説明文を表示
        GameObject RestartObj = GameObject.Find("Button(1)");//スタートボタンを押したらリスタートボタンを表示

        foreach (Transform child in holeRootObj.transform)
        {
            GameObject childGObj = child.gameObject;
            childGObj.SetActive(true);
        }
        
    }
}
