using System.Collections;
using UnityEngine;

public class ChickScript : MonoBehaviour
{
    private float timer2;
    public GameObject Hen;
    public GameObject Rooster;

    void Start()
    {
        timer2 = GameManager.timer;
        GameManager.ChickCounter++;

        if (timer2 > 21)
        {
            StartCoroutine(MatureTimer());
        }
        else
        {
            StartCoroutine(HenSpawnTimer());
        }
    }

    IEnumerator MatureTimer()
    {
        yield return new WaitForSeconds(10f);
        HenOrRooster();
    }

    IEnumerator HenSpawnTimer()
    {
        yield return new WaitForSeconds(10f);
        Instantiate(Hen, transform.position, transform.rotation);
        GameManager.ChickCounter--;
        Destroy(gameObject);
    }

    void HenOrRooster()
    {
        int randomChance = Random.Range(0, 2);
        GameObject spawnedObject;

        if (randomChance == 0)
        {
            spawnedObject = Instantiate(Hen, transform.position, transform.rotation);
        }
        else
        {
            spawnedObject = Instantiate(Rooster, transform.position, transform.rotation);
        }

        GameManager.ChickCounter--;
        Destroy(gameObject);
    }
}
