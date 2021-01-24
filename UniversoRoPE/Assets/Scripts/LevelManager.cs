using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private const float TILE_SIZE = 1.0f;
    private const float TILE_OFFSET = TILE_SIZE / 2;

    private const float GROUND_WIDTH = 6;
    private const float GROUND_HEIGHT = 6;

    private int currentPositionX = -1;
    private int currentPositionY = -1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DrawGround();
    }



    private void DrawGround()
    {
        Vector3 widthLine = Vector3.right * GROUND_WIDTH;
        Vector3 heigthLine = Vector3.forward * GROUND_HEIGHT;

        for (int i = 0; i <= GROUND_WIDTH; i++)
        {
            Vector3 start = Vector3.forward * i;
            Debug.DrawLine(start, start + widthLine);
            for (int j = 0; j <= GROUND_HEIGHT; j++)
            {
                start = Vector3.right * j;
                Debug.DrawLine(start, start + heigthLine);
            }
        }

    }
}
