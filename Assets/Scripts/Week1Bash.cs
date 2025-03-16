using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week1Bash : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] nums = new int[10];

        for (int i = 1; i <= 10; i++)
        {
            nums[i] = i;
        }

        for (int i = 1; i <= 10; i++)
        {
            Debug.Log("nums : " + nums[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
