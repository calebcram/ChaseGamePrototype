using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : MonoBehaviour
{
    public Transform player;
    public Vector3 target;
    public float speed = 2;
    public bool shrink;
    void Start()
    {
        GetNewTarget();
        shrink = false;
    }

    private void Update()
    {
        if (Vector3.Distance(transform.position, target) < 1)
        {
            GetNewTarget();
        }

        transform.position = Vector3.Lerp(transform.position, target, Time.deltaTime * speed);
        if (shrink)
        {
            Shrink();
        }
    }

    public void GetNewTarget()
    {
        target = new Vector3(Random.Range(-5, 5), 1f, Random.Range(-5, 5));
    }

    public void Shrink()
    {
        if (Vector3.Magnitude(transform.localScale) < .1)
        {
            Destroy(gameObject);
        }
       transform.localScale -= new Vector3(.1f, .1f, .1f);
    }

    private void LineRender()
    {
        FindShortestPath();
        Vector3 nnewVect = new Vector3(1f, 1f, 1f);
        LineRenderer line = new LineRenderer();
        Vector3 anotherVect = new Vector3(1, 2, 3);
    }

    private static void FindShortestPath()
    {
        float total = 0;
        Vector3[] vectArra = new Vector3[5];
        for (int i = 0; i < vectArra.Length - 1; i++)
        {
            total += Vector3.Distance(vectArra[i], vectArra[i + 1]);
        }
    }

    //public void GetNewTarget()
    // {
    //FindLowestHealthEnemy();
    // }

    /* private GameObject FindLowestHealthEnemy()
     {
         target = new Vector3(Random.Range(-5, 5), 1f, Random.Range(-5, 5));
         GameObject[] enemies = GameObject.FindGameObjectsWithTag("enemy");
         foreach (GameObject en in enemies)
         {
             if (en.GetComponent<Enemy>().healthBar < lowestHealth.GetComponent<Enemy>().healthBar)
             {
                 lowestHealth = en;
             }
         }
     }*/

    /* private void Dice()
     {
         RollTheDice();
     }

     private static void RollTheDice()
     {
         int dice = Random.Range(0, 3);
         Debug.Log("Dice value = " + dice);
         switch (dice)
         {
             case 0:
                 {
                     break;
                 }
             case 1:
                 {
                     break;
                 }
             case 2:
                 {
                     break;
                 }
             case 3:
                 {
                     break;
                 }
         }
     }*/
}
