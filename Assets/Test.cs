using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;
    private int power = 25;
    private int mp = 53;
    public void Magic(int 消費mp)
    {
        if( mp<5)
        {
            Debug.Log("MPが足りないため魔法攻撃が使えない");
        }
        else
        {
            mp -= 消費mp;
            Debug.Log("魔法攻撃をした。残りのmpは" + mp);
        }
       
    }
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        hp -= damage;
    }
}
public class Test : MonoBehaviour {
    
	// Use this for initialization
   
	void Start () {
        Boss lastboss = new Boss();
        int[] array = { 1, 2, 3, 4, 5 };
        for (int i = 0; i <= 4; i++)
        {
            Debug.Log(array[i]);
        }
        for (int I = 4; 0 <= I; I--)
        {
            Debug.Log(array[I]);
        }
        for (int a = 1; a <= 11; a++)
        {
            lastboss.Magic(5);
        }
        
        lastboss.Attack();
        lastboss.Defence(3);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
