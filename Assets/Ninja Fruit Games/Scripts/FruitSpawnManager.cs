using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawnManager : MonoBehaviour
{
    public GameObject[] Spawnpoints;
    public GameObject[] Fruitprefabs;
    private int index;
    private int indexfruit;

    public float timeRate;

    void Start()
    {
        StartCoroutine(CreateFruits());
    }


    private IEnumerator CreateFruits()
    {
        while (true)
        {
            index = Random.Range(0, 4);
            indexfruit = Random.Range(0,9);


            GameObject fruit = Instantiate(Fruitprefabs[indexfruit], Spawnpoints[index].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
            fruit.transform.SetParent(transform);
            yield return new WaitForSeconds(timeRate);
        }
    }

}
