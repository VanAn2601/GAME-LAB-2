using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class ChickenController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject egg;
    private int count = 0;


    // Update is called once per frame
    void Update()
    {
        count++;
        if (count > 500)
        {
            Instantiate(egg, transform.position, Quaternion.identity);
            count = 0;
        }
    }
}
