using UnityEngine;

namespace DesignPatternsTesting
{
    [RequireComponent(typeof(CharacterMover), typeof(CharacterAttack))]
    public class PlayerController : MonoBehaviour
    {
        private CharacterMover playerCharacterMover;
        private CharacterAttack playerCharacterAttack;

        private void Start()
        {
            playerCharacterMover = GetComponent<CharacterMover>();
            playerCharacterAttack = GetComponent<CharacterAttack>();
        }

        private void Update()
        {
            Move();
            Attack();
        }

        private void Move()
        {
            Vector2 inputVector = Vector2.zero;

            if (Input.GetKeyDown(KeyCode.W))
            {
                inputVector = new Vector2(0, 1);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                inputVector = new Vector2(-1, 0);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                inputVector = new Vector2(0, -1);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                inputVector = new Vector2(1, 0);
            }

            if (inputVector == Vector2.zero) return;

            CommandManager.Instance.AddCommand(new MoveCommand(playerCharacterMover, inputVector));
        }

        private void Attack()
        {
            if (Input.GetMouseButtonDown(1))
            {
                CommandManager.Instance.AddCommand(new AttackCommand(playerCharacterAttack));
            }
        }
    }
}