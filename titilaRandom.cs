using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class luz : MonoBehaviour
{

    public bool titila = false;
    public float timeDelay;


    // Update is called once per frame
    void Update()
    {
        if (titila == false)
        {
            StartCoroutine(LuzQueTitila());
        }
    }
    IEnumerator LuzQueTitila()
    {
        titila = true;
        this.gameObject.GetComponent<Light>().enabled = false;
        timeDelay = Random.Range(0.01f, 0.2f);
        yield return new WaitForSeconds(timeDelay);
        this.gameObject.GetComponent<Light>().enabled = true;
        timeDelay = Random.Range(0.01f, 0.2f);
        yield return new WaitForSeconds(timeDelay);
        titila = false;


    }
}
