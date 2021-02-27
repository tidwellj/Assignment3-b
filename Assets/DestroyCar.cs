using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroyDelayed());
    }

    // Update is called once per frame
    IEnumerator DestroyDelayed()
    {
        yield return new WaitForSeconds(6f);
        Destroy(gameObject);
    }
}
