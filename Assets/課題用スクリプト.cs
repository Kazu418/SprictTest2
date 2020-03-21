using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 課題用スクリプト : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
        int[] array = { Random.Range(1, 10), Random.Range(1, 10), Random.Range(1, 10), Random.Range(1, 10), Random.Range(1, 10) };
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }
        for (int i = 4; i>= 0; i-=1)
        {
            Debug.Log(array[i]);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
