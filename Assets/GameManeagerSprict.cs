using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManeagerSprict : MonoBehaviour
{
  
    // Start is called before the first frame update
    
    void PrintArray()
    {

        string debugText = "";
        for (int y = 0; y < map.GetLength(0); y++)
        {

            for (int x = 0; x < map.GetLength(1); x++)
            {
                debugText += map[y,x].ToString() + ",";

            }
            debugText += "\n";
            //Debug.Log(map[i]+",");

        }
        Debug.Log(debugText);

    }

    Vector2Int GetPlayerIndex()
    {
        for (int y = 0; y < field.Length; y++)
        {
            for (int x = 0; x < field.Length; x++)
            {
                if(field[y, x] == null)
                {

                    continue;

                }

                if (field[y,x].tag == "Player")
                {

                    return new Vector2Int(x, y);

                }

                     

            }
        }

        return new Vector2Int(-1,-1);

    }

    bool MoveNumber(int number, Vector2Int moveForm, Vector2Int moveTo)
    {
        if (moveTo.x < 0 || moveTo.x >= field) { return false; }

        if (map[moveTo] == 2)
        {
            int velocity = moveTo - moveForm;
            bool sucess = MoveNumber(2, moveTo, moveTo + velocity);
            if (!sucess) { return false; }
        }

        map[moveTo] = number;
        map[moveForm] = 0;
        return true;
    }

    void Start()
    {

        
      
        map = new int[,] {

        {0,0,0,0,0,},
        {0,0,1,0,0,},
        {0,0,0,0,0,},

        };
        field=new GameObject[map.GetLength(0),map.GetLength(1)];

        for(int y = 0;y < map.GetLength(0); y++)
        {
            for(int x = 0;x < map.GetLength(1); x++)
            {

                if (map[y,x] == 1)
                {
                    field[y,x] = Instantiate(
                        PlayerPrefab,
                        new Vector3(x,y,0),
                        Quaternion.identity

                        ); 

                }

            }


        }

        PrintArray();



    }

    // Update is called once per frame
    //void Update()
    //{

    //    if (Input.GetKeyDown(KeyCode.RightArrow))
    //    {
    //        int playerIndex = GetPlayerIndex();
    //        if (playerIndex >= 0)
    //        {
    //            MoveNumber(1, playerIndex, playerIndex + 1);
    //        }
    //            PrintArray();



    //    }

    //    if (Input.GetKeyDown(KeyCode.LeftArrow))
    //    {
    //        int playerIndex = GetPlayerIndex();
    //        if (playerIndex >= 0)
    //        {
    //            MoveNumber(1, playerIndex, playerIndex - 1);
    //        }
    //        PrintArray();



    //    }

    //}


    public GameObject PlayerPrefab;
    int[,] map;
    GameObject[,] field;
    
}
