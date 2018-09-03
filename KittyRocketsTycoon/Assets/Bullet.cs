using UnityEngine;
using WARMachine.Variables;
public class Bullet : MonoBehaviour
{
    public FloatReference Speed;
    public FloatReference ShipPosition;
    public float spawnXPosition;
    // Use this for initialization
    void Awake()
    {
        GetPosition();//Call this in Awake OnEnable is not called on Windows Build
    }

    private void OnEnable()
    {
        GetPosition();
    }

    // Update is called once per frame
    void Update ()
    {
        transform.position = new Vector3(spawnXPosition, transform.position.y + Speed.Value * Time.deltaTime, transform.position.z);	
	}

    void GetPosition()
    {
        if (ShipPosition == 0)
        {
            spawnXPosition = this.transform.position.x;
            Debug.Log("Call this");
        }
        else
            spawnXPosition = ShipPosition.Value;
    }
}
