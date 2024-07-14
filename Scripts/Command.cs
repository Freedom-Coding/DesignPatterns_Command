using UnityEngine;

namespace DesignPatternsTesting
{
    public interface ICommand
    {
        void Execute();
        Sprite GetSprite();
    }
}