using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsolePrint : MonoBehaviour
{
private int i;



// Start is called before the first frame update
void Start()
{
i = 3;
//rand = Random.Range(200, 251);
}



// Update is called once per frame
void Update()
{
 i++;
Debug.Log(gameObject.name + ": " + i);



}
}
