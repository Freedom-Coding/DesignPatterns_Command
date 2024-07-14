using UnityEngine;

namespace DesignPatternsTesting
{
    public class EnemyAI : MonoBehaviour
    {
        [SerializeField] private CharacterMover characterMover;

        private void OnEnable()
        {
            CommandManager.Instance.OnCommandsExecute += CalculateMovement;
        }
        private void OnDisable()
        {
            CommandManager.Instance.OnCommandsExecute -= CalculateMovement;
        }

        private void CalculateMovement()
        {
            Vector2[] directions = new Vector2[]
            {
            Vector2.up,
            Vector2.right,
            Vector2.left,
            Vector2.down
            };

            int randomIndex = Random.Range(0, directions.Length);
            Vector2 direction = directions[randomIndex];

            MoveCommand moveCommand = new MoveCommand(characterMover, direction);
            CommandManager.Instance.AddCommand(moveCommand);
        }
    }
}