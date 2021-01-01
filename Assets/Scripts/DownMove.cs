using UnityEngine;
using System.Collections;

public class DownMove : MonoBehaviour {

    public GameObject hoge;

    // Use this for initialization
    void Start () {
        hoge = GameObject.Find("movecube"); //シーン内のMovecubeを検索
    }
	
	// Update is called once per frame
	void Update () {
       
    }

    void OnTriggerEnter(Collider collider)
    {
        //衝突判定
        hoge.transform.position = new Vector3(-16, -5, 0);

    }

    void OnTriggerExit(Collider collider)
    {
        hoge.transform.position = new Vector3(-16, 0, 0);
    }

}
