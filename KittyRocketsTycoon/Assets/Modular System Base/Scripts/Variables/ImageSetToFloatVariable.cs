using UnityEngine;
using UnityEngine.UI;

namespace WARMachine.Variables
{
    /// <summary>
    /// Sets an Image component's to represent Variable
    /// between One or the other.
    /// </summary>
    public class ImageSetToFloatVariable : MonoBehaviour
    {
        [Tooltip("Value to check if current Unlocked or Locked")]
        public FloatVariable Variable;
        [Tooltip("Image to set the fill amount on")]
        public Image Image;

        [Header("Locked Sprites")]
        [Tooltip("Value to use as the Locked")]
        public FloatReference VariableLocked;
        public Sprite LockedSprite;

        [Header("Unlocked Sprites")]
        [Tooltip("Value to use as the Unlock")]
        public FloatReference VariableUnlocked;  
        public Sprite UnlockedSprite;
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            //FloatReference fl = VariableLocked;
           // Debug.Log(Variable.Value + " == " + VariableLocked.Value);
            if (Variable.Value == VariableLocked.Value)
            {
                Image.sprite = LockedSprite;
            }
            if (Variable.Value == VariableUnlocked.Value)
            {
                Image.sprite = UnlockedSprite;
            }
        }
    }
}
