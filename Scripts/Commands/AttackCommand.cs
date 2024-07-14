using UnityEngine;

namespace DesignPatternsTesting
{
    public class AttackCommand : ICommand
    {
        private CharacterAttack characterAttack;

        public AttackCommand(CharacterAttack _characterAttack)
        {
            characterAttack = _characterAttack;
        }

        public void Execute()
        {
            characterAttack.Attack();
        }

        public Sprite GetSprite()
        {
            return CommandManager.Instance.commandSprites.attack;
        }
    }
}