using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{

    public float bulletSpeed = 5f;
    void Update()
    {
        transform.Translate(Vector3.down * bulletSpeed * Time.deltaTime);
    }

    void OnBecameInvisible()
    {
        gameObject.SetActive(false);
    }

}
