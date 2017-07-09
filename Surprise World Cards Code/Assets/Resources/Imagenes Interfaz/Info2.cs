using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info2 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        StartCoroutine(example());
    }

    IEnumerator example()
    {
        yield return new WaitForSeconds(2);
        Application.LoadLevel("Info3");
    }
}
