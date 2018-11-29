using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotController : MonoBehaviour
{

    [SerializeField]
    private GameObject Shot;

    private List<GameObject> bulletList;

    private int maxBulletOnX = 300;


    // Use this for initialization
    void Start()
    {
        bulletList = new List<GameObject>();
        for (int i = 0; i < maxBulletOnX; i++)
        {
            bulletList.Add(Instantiate(Shot, Vector3.zero, transform.rotation));

            bulletList[i].SetActive(false);

        }
    }

    // Update is called once per frame
    void Update()
    {
        // Create the Bullet from the Bullet Prefab

        /*
        var bullet = (GameObject)Instantiate(
            Shot,
            transform.position,
            transform.rotation);

        bullet.GetComponent<Rigidbody>().velocity = transform.TransformDirection(Vector3.forward * 1);
        */

        // optimized
        GameObject temp = bulletList.Find(go => go.activeInHierarchy == false);
        if (temp != null)
        {
            temp.transform.position = transform.position;
            temp.SetActive(true);
        }



    }
}
