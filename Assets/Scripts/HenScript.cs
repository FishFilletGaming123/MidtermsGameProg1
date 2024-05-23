using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HenScript : MonoBehaviour
{
    public GameObject Egg;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.HenCounter++;
        StartCoroutine(EggCreate());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

        IEnumerator EggCreate()
    {
        int randomChance = Random.Range(2,10);
        yield return new WaitForSeconds(30f);//change into 10 later
       for (int i = 0; i < randomChance; i++)
       {
        Instantiate(Egg, transform.position, transform.rotation);
       }

       yield return new WaitForSeconds(10f);
       GameManager.HenCounter--;
       Destroy(this.gameObject);

    }
}
