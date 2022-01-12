using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCast : MonoBehaviour
{

    [SerializeField] private GameObject m_Explosion;
    private GameObject prefab;

    private void Update()
    {
        var pos = new Vector3(Input.mousePosition.x, Input.mousePosition.y,
            Camera.main.transform.position.y);
        var screenPoint = Camera.main.ScreenToWorldPoint(pos);
        if(Input.GetMouseButtonDown(0))
        {
            prefab = Instantiate(m_Explosion, screenPoint, Quaternion.identity);
            Destroy(prefab, 2f);
        }
    }
}
