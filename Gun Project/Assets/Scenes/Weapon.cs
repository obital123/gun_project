using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform FirePoint; // 총구
    public GameObject BulltPrefeb; // 총알
    float angle;
    Vector2 mouse, target;
    // Start is called before the first frame update
    void Start()
    {
        target = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);  // 마우스 위치
        angle = Mathf.Atan2(mouse.y - target.y, mouse.x - target.x) * Mathf.Rad2Deg; 
        this.transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward); // 각도 조절

        if (Input.GetKeyDown(KeyCode.Space))
        {
            shoot();
        }
    }
    void shoot()
    {
        Instantiate(BulltPrefeb, FirePoint.position, FirePoint.rotation); // 총알 생성
    }
}
