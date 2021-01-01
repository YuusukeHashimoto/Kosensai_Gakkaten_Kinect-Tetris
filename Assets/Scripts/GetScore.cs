using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GetScore : MonoBehaviour {
    private int score;
    public Text scoretext;

    // Use this for initialization
    void Start () {
        scoretext = GetComponentInChildren<Text>();
        scoretext.text = "0";
    }
	
	// Update is called once per frame
	void Update () {
        score = Grid.score;
        scoretext.text = score.ToString();
    }
}
