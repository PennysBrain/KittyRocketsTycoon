using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WARMachine.Variables;
public class Bullet : MonoBehaviour
{
    public FloatReference Speed;
    public FloatReference ShipPosition;
    public float spawnXPosition;
    // Use this for initialization
    void Start ()
    {
		
	}

    private void OnEnable()
    {
        spawnXPosition = ShipPosition.Value;
    }
    // Update is called once per frame
    void Update ()
    {
        transform.position = new Vector3(spawnXPosition, transform.position.y + Speed.Value * Time.deltaTime, transform.position.z);	
	}
}
