using UnityEngine;

public class spawner_plusfive : MonoBehaviour
{
    
    public GameObject item;
    

    void Start()
    {
        float randomposy = Random.Range(-4.78f, 4.77f);
        float randomposx = Random.Range(-8f, 8.34f);
        float randomposz = 0;
        Vector3 randompos = new Vector3(randomposx, randomposy, randomposz);  
        Instantiate(item, randompos, Quaternion.identity);
    }

}
