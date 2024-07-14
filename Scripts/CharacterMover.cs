using UnityEngine;
using DG.Tweening;

namespace DesignPatternsTesting
{
    public class CharacterMover : MonoBehaviour
    {
        [SerializeField] private float playerMoveSpeed = 2;

        public void Move(Vector2 moveVector)
        {
            transform.DOMove(transform.position + (Vector3)moveVector, 1);
        }
    }
}