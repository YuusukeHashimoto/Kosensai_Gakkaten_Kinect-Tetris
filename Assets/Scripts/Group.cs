using UnityEngine;
using System.Collections;

public class Group : MonoBehaviour {
    double lastFall = 0;
    int framecount = 0;
    double FallSpeed = 1;
    public GameObject hoge;

 

    bool isValidGridPos()
    {
        foreach (Transform child in transform)
        {
            Vector2 v = Grid.roundVec2(child.position);

            // Not inside Border?
            if (!Grid.insideBorder(v))
                return false;

            // Block in grid cell (and not part of same group)?
            if (Grid.grid[(int)v.x, (int)v.y] != null &&
                Grid.grid[(int)v.x, (int)v.y].parent != transform)
                return false;
        }
        return true;
    }
    void updateGrid()
    {
        // Remove old children from grid
        for (int y = 0; y < Grid.h; ++y)
            for (int x = 0; x < Grid.w; ++x)
                if (Grid.grid[x, y] != null)
                    if (Grid.grid[x, y].parent == transform)
                        Grid.grid[x, y] = null;

        // Add new children to grid
        foreach (Transform child in transform)
        {
            Vector2 v = Grid.roundVec2(child.position);
            Grid.grid[(int)v.x, (int)v.y] = child;
        }
    }


    // Use this for initialization
    void Start()
    {


        //ブロックが枠の外に出たらGameOver
        if (!isValidGridPos())
        {
            Debug.Log("GAME OVER");
            Destroy(gameObject);
            Application.LoadLevel("gameover 1");
        }

        hoge = GameObject.Find("movecube"); //シーン内のオブジェクト「movecube」を検索

        //スコアに応じたスピード調節

       if (Grid.score < 5000)
        {
            FallSpeed = 2;
            

        }else if(Grid.score < 7000)
        {
            FallSpeed = 0.5;
          

        }else if(Grid.score < 9000)
        {
            FallSpeed = 0.1;
           

        }else if(Grid.score < 11000)
        {
            FallSpeed = 0.00000000000000000000001;
            
        }
               
                
        }
    
    

    // Update is called once per frame
    //update()が60回呼ばれるたびに移動の処理を実行
    void Update () {
        framecount += 1;
        if(framecount == 60)
        {
            
            framecount = 0;
            Move();
        }
    }

    void Move()
    {
       
        // Move Left
        if (hoge.transform.localPosition.x > -11)
        {

            // Modify position
            transform.position += new Vector3(-1, 0, 0);

            // See if valid
            if (isValidGridPos())
            {
                // Its valid. Update grid.
                updateGrid();
                framecount = 20;
                AudioScript.Moved();

            }
            else
            {
                // Its not valid. revert.
                transform.position += new Vector3(1, 0, 0);
            }
            

        }
        // Move Right
        else if (hoge.transform.localPosition.x < -20)
        {
            // Modify position
            transform.position += new Vector3(1, 0, 0);

            // See if valid
            if (isValidGridPos())
            {
                // It's valid. Update grid.
                updateGrid();
                framecount = -20;
                AudioScript.Moved();

            }
            else
            {
                // It's not valid. revert.
                transform.position += new Vector3(-1, 0, 0);
            }
            

        }
        // Rotate
        else if (hoge.transform.localPosition.y > 4)
        {
            transform.Rotate(0, 0, -90);
            
            // See if valid
            if (isValidGridPos())
            {
                // It's valid. Update grid.
                updateGrid();
                framecount = -40;
                AudioScript.Rotated();
            }
            else
            {
                // It's not valid. revert.
                transform.Rotate(0, 0, 90);
            }
        }

        // Move Downwards and Fall
        else if ((hoge.transform.localPosition.y < -4)  )            
        {
            // Modify position
            transform.position += new Vector3(0, -1, 0);

            // See if valid
            if (isValidGridPos())
            {
                // It's valid. Update grid.
                updateGrid();
                framecount = 45;
                

            }
            else
            {
                // It's not valid. revert.
                transform.position += new Vector3(0, 1, 0);

                // Clear filled horizontal lines
                Grid.deleteFullRows();

                // Spawn next Group(デフォルトのブロックが落ちた場合は次のブロックを生成しない)
                if (ButtonPush.swich == 1)
                {
                    FindObjectOfType<SpawnerScript>().spawnNext();
                }
                // Disable script
                enabled = false;
            }

            lastFall = Time.time;
        }
        //1秒ごとに落下
        if (Time.time - lastFall >= FallSpeed)
        {

         // Modify position
        transform.position += new Vector3(0, -1, 0);

        // See if valid
        if (isValidGridPos())
        {
            // It's valid. Update grid.
            updateGrid();
        }
        else
        {
            // It's not valid. revert.
            transform.position += new Vector3(0, 1, 0);

            // Clear filled horizontal lines
            Grid.deleteFullRows();

                // Spawn next Group
                if (ButtonPush.swich == 1)
                {
                    FindObjectOfType<SpawnerScript>().spawnNext();
                }
            // Disable script
            enabled = false;
        }

        lastFall = Time.time;
    
    }
}

}
