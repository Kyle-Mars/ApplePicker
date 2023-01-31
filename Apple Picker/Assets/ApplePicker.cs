using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplePicker : MonoBehaviour
{
    [Header("Inscribed")]

    public GameObject basketPrefab;
    public int numBaskets = 3;
    public float basketBottom = 10f;
    public float basketSpacingY = 1f;
    // Start is called before the first frame update
    void Start(){
        for(int i = 0; i < numBaskets; i++) {
        GameObject tBasketGO = Instantiate<GameObject>(basketPrefab);
        Vector3 pos = Vector3.zero;
        pos.y = basketBottom + (basketSpacingY* i);
        tBasketGO.transform.position = pos;
        }
    }
    // Update is called once per frame
    void Update()
    { }
 
}
