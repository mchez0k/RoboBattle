using UnityEngine.TextCore.Text;

namespace RoboBattle.Movement
{
    public abstract class MovementState
    {
        protected Character character;

        public MovementState(Character character) // TODO: Оптимизировать
        {
            this.character = character;
        }

        public virtual void EnterState(Character character)
        {

        }

        public virtual void UpdateState(Character character)
        {

        }

        public virtual void ExitState(Character character)
        {

        }
    }
}

