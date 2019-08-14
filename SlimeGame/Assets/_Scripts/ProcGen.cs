using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcGen : MonoBehaviour
{
    public Objects obj;
    public Vector3[,] grid = new Vector3[20, 20];

    public int baseX = 0;
    public int baseY = 0;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 20; i ++)
        {
          for(int d = 0; d < 20; d++)
            {
                grid[i, d] = new Vector3(0 + baseX, 0,  1 + baseY);
                baseY++;
                print(grid[i, d]);
                Instantiate(obj.smallObject, new Vector3(grid[i,d].x, grid[i,d].y + 1, grid[i,d].z), Quaternion.identity);
            }
            baseX++;
            baseY = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
