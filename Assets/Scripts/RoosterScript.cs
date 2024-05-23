using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoosterScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    
        StartCoroutine(RoosterTimer());
        GameManager.RoosterCounter++;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

        IEnumerator RoosterTimer()
    {
        
          yield return new WaitForSeconds(40f); 
         GameManager.RoosterCounter--;
          Destroy(this.gameObject);

    }
}
