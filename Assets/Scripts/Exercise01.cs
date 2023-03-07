using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise01 : MonoBehaviour
{
    public GameObject _cubePrefab;

    public int randomRangeX;
    public int randomRangeY;
    public int randomRangeZ;

    public int pose = 8;

    private void Start()
    {

        for (int i = 0; i < 10; i++)
        {
            randomRangeX = Random.Range(-pose, pose);
            randomRangeY = Random.Range(-pose, pose);
            randomRangeZ = Random.Range(-pose, pose);
            GameObject inst = Instantiate(_cubePrefab, new Vector3(randomRangeX, randomRangeY, randomRangeZ), Quaternion.identity);
            inst.transform.localScale = Vector3.one * Random.Range(1,8);
        }
    }
}
