using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteScript : MonoBehaviour
{
    public void startdelete()
    {
        StartCoroutine(distroy());
    }

    IEnumerator distroy()
    {
        yield return new WaitForSeconds(25);
        Object.Destroy(this.gameObject);
    }

}
