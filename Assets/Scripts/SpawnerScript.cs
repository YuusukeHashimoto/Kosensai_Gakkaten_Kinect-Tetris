using UnityEngine;
using System.Collections;

public class SpawnerScript : MonoBehaviour {
    // Groups
    public GameObject[] groups;
    int BlockCount=0;
    //ブロックをランダムに生成

    public void spawnNext()
    {
        if (BlockCount == 0)
        {
            Instantiate(groups[3], new Vector3(4.0f, 14.0f, 0.0f), Quaternion.identity);//決められたブロックその２を生成
            BlockCount = 1;
        }
        else
        {
            // Random Index
            int i = Random.Range(0, groups.Length);

            // Spawn Group at current Position
            Instantiate(groups[i],
                        transform.position,
                        Quaternion.identity);
        }
        
    }

    // Use this for initialization
    void Start () {
        
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
