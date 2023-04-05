//Otettu mallia https://www.youtube.com/watch?v=CcTj8es83zA&t=81s&ab_channel=TheSleepyKoala

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class SeaSpawnSript : MonoBehaviour
{
    public GameObject SeaPrefab;
    private float currentXSpawnPosition = 78f;
    private bool collectionCheck = true;
    private int maxPoolSize = 15;
    public IObjectPool<GameObject> m_pool { get; set; }
    // Start is called before the first frame update
    void Start()
    {
        m_pool = new ObjectPool<GameObject>(CreateSea, OnTakeFromPool, OnReturnedToPool, OnDestroyPoolObject, collectionCheck, 10, maxPoolSize);
    }

    // Update is called once per frame
    void Update()
    {
     
    }
    public void SpawnSea() => m_pool.Get();

    public void ReleaseSea(GameObject sea) => m_pool.Release(sea);
    private GameObject CreateSea()
    {
        //Create a new sea within parent transform
        GameObject sea = Instantiate(SeaPrefab, transform);
        sea.SetActive(false);

        return sea;
    }
    // Called when a sea is returned to the pool using Release
    private void OnReturnedToPool(GameObject sea) => sea.gameObject.SetActive(false);
    private void OnTakeFromPool(GameObject sea)
    {
        //Move the sea to the currentXSpawnPosition
        sea.transform.position = new Vector3(currentXSpawnPosition, 0, 0);
        //Activate the sea
        sea.gameObject.SetActive(true);
    }
    //If the pool capacity is reached then any platforms returned will be destroyd
    //We can control what the destroy behavior does, here we destroy GameObject
    private void OnDestroyPoolObject(GameObject sea) => Destroy(sea);
   
}
