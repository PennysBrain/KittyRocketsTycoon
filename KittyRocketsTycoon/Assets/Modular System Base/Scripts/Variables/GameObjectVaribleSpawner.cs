using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WARMachine.Variables
{
    public class GameObjectVaribleSpawner : MonoBehaviour
    {
#if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription = "";
#endif
        public GameObject Prefab;
        public FloatReference FloatReference;
        public bool SpawnAtStart;
        public GameObject spawnPoint;
        // Use this for initialization
        void Start()
        {
            if (SpawnAtStart)
            {
                Spawn(FloatReference.Value);
            }
        }

        // Update is called once per frame
        public void Spawn(float amount)
        {
            for (float i = amount; i > 0; i--)
            {
                if(spawnPoint!=null)
                    Instantiate(Prefab, new Vector3(spawnPoint.transform.position.x, spawnPoint.transform.position.y, spawnPoint.transform.position.z), Quaternion.identity);
                else
                    Instantiate(Prefab, new Vector3(0,0,0), Quaternion.identity);

            }
        }
    }
}