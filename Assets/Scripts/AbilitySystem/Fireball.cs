using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    [SerializeField] public KeyCode keybinding;
    [SerializeField] public Transform projectile;
    [SerializeField] public Transform spawnPosition;
    private Camera mainCamera;
    private Vector3 mousePos;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        Vector3 rotation = mousePos - transform.position;
        float rotateZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(rotateZ, 0, 0);
        if (Input.GetKeyDown(keybinding))
        {
            Transform projectileClone = Instantiate(projectile, spawnPosition.position, Quaternion.identity) ;
        }
    }
}
