using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhenDoesItEnd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Global.MaybeTodayWillBeBetter());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
