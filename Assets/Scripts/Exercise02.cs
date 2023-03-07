using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Exercise02 : MonoBehaviour
{
    public int counter = 0;

    public TextMeshProUGUI Texto;

    private void Start()
    {
        StartCoroutine(Counter());
    }
    private IEnumerator Counter()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            Texto.text = $"{counter}";
            counter++;
        }
    }   
}
