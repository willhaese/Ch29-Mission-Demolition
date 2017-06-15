using UnityEngine;
using System.Collections;
public class Slingshot : MonoBehaviour
{
    // fields set in the Unity Inspector Pane
    public GameObject prefabProjectile;
    public bool ___________________________;
    //fields set dynamically
    public GameObject launchPoint;
    void Awake()
    {
        Transform launchPointTrans = transform.Find("LaunchPoint");
        launchPoint = launchPointTrans.gameObject;
        launchPoint.SetActive(false);
    }

    void OnMouseEnter()
    {
        //print("Slingshot:OnMouseEnter()");
        launchPoint.SetActive(true);

    }
    void OnMouseExit()
    {
        //print("Slingshot:OnMouseExit()");
        launchPoint.SetActive(false);
    }
}
