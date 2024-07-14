using UnityEngine;

namespace DesignPatternsTesting
{
    public class MoveCommand : ICommand
    {
        private CharacterMover characterMover;
        private Vector2 moveVector;

        public MoveCommand(CharacterMover _characterMover, Vector2 _moveVector)
        {
            characterMover = _characterMover;
            moveVector = _moveVector;
        }

        public void Execute()
        {
            characterMover.Move(moveVector);
        }

        public Sprite GetSprite()
        {
            switch ((moveVector.x, moveVector.y))
            {
                case (0, 1):
                    return CommandManager.Instance.commandSprites.moveUp;

                case (0, -1):
                    return CommandManager.Instance.commandSprites.moveDown;

                case (-1, 0):
                    return CommandManager.Instance.commandSprites.moveLeft;

                case (1, 0):
                    return CommandManager.Instance.commandSprites.moveRight;

                default:
                    return null;
            }
        }
    }
}