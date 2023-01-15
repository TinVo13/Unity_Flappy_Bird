using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject pipe;
    public float maxtime;
    public float height;
    float timer;
    private void Start()
    {
        timer = maxtime;
    }
    private void Update()
    {
        if(timer > maxtime)
        {
            GameObject tmp = Instantiate(pipe,new Vector3(transform.position.x,transform.position.y + Random.Range(-height,height),0),Quaternion.identity);
            Destroy(tmp,10f);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
