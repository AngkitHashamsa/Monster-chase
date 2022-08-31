using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] monsterRefrence;
    [SerializeField]
    private Transform Left, Right;

    private GameObject spawnMonster;

    private int radomIndex;
    private int randomSide;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpwanMonster());
    }

    IEnumerator SpwanMonster()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1, 5));

            radomIndex = Random.Range(0, monsterRefrence.Length);
            randomSide = Random.Range(0, 2);
            spawnMonster = Instantiate(monsterRefrence[radomIndex]);

            if (randomSide == 0)
            {
                spawnMonster.transform.position = Left.position;
                spawnMonster.GetComponent<Monsters>().speed = Random.Range(4, 10);
 
            }
            else
            {
                spawnMonster.transform.position = Right.position;
                spawnMonster.GetComponent<Monsters>().speed = -Random.Range(4, 10);
                spawnMonster.transform.localScale = new Vector3(-1f, 1f, 1f);
            }
        } //while loop
     
    }

}//class
