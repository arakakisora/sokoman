using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManeagerSprict : MonoBehaviour
{
    public GameObject PlayerPrefab;
    int[,] map;
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

    //int GetPlayerIndex()
    //{
    //    for(int i = 0; i < map.Length; i++)
    //    {
    //        if (map[i] == 1)
    //        {
    //            return i;
    //        }
    //    }

    //    return -1;

    //}

    //bool MoveNumber(int number,int moveForm,int moveTo)
    //{
    //    if (moveTo < 0 || moveTo >= map.Length){return false;}

    //    if (map[moveTo] == 2)
    //    {
    //        int velocity = moveTo - moveForm;
    //        bool sucess = MoveNumber(2, moveTo, moveTo + velocity);
    //        if (!sucess) {return false;} 
    //    }

    //    map[moveTo] = number; 
    //    map[moveForm] = 0;
    //    return true;
    //}
    
    void Start()
    {

      
        map = new int[,] {

        {0,0,0,0,0,},
        {0,0,1,0,0,},
        {0,0,0,0,0,},

        };
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
}
