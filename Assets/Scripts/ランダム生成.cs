using UnityEngine;
using System.Collections;

public class ランダム生成 : MonoBehaviour
{
    public GameObject[] Train;
    int number = 0;
    // Start is called before the first frame update
    void Start()
    {
        number = Random.Range(0, Train.Length);
        Instantiate(Train[number], transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
