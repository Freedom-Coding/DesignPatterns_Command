using UnityEngine;

namespace DesignPatternsTesting
{
    public class CharacterAttack : MonoBehaviour
    {
        [SerializeField] private float attackDamage;

        public void Attack()
        {
            Debug.Log(gameObject.name + " dealt " + attackDamage + " damage.");
        }
    }
}