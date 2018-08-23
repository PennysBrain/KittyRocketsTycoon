using UnityEngine;
using UnityEngine.UI;
namespace WARMachine.Elements
{
    public class Elemental : MonoBehaviour
    {
        [Tooltip("Element represented by this elemental.")]
        public AttackElement Element;

        [Tooltip("Text to Fill in with the Element name")]
        public Text Lable;

        // Use this for initialization
        private void OnEnable()
        {
            if (Lable != null)
                Lable.text = Element.name;
        }

        private void OnTriggerEnter(Collider other)
        {
            Elemental e = other.gameObject.GetComponent<Elemental>();
            if (e != null)
            {
                if (e.Element.DefeatedElements.Contains(Element))
                    Destroy(gameObject);
            }
        }
    }
}
