using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform FirePoint; // �ѱ�
    public GameObject BulltPrefeb; // �Ѿ�
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
        mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);  // ���콺 ��ġ
        angle = Mathf.Atan2(mouse.y - target.y, mouse.x - target.x) * Mathf.Rad2Deg; 
        this.transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward); // ���� ����

        if (Input.GetKeyDown(KeyCode.Space))
        {
            shoot();
        }
    }
    void shoot()
    {
        Instantiate(BulltPrefeb, FirePoint.position, FirePoint.rotation); // �Ѿ� ����
    }
}
