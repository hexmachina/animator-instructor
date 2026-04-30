using UnityEngine;

namespace TW.Animators.Instructors
{

	[DisallowMultipleComponent, RequireComponent(typeof(Animator))]
	public class AnimatorInstructor : MonoBehaviour
	{
		[SerializeField] private AnimatorInstruction _instruction;
		private Animator _anim;
		private void Awake()
		{
			TryGetComponent(out _anim);
		}

		public void RunInstruct()
		{
			Instruct(_instruction);
		}

		public void Instruct(AnimatorInstruction instruction)
		{
			if (instruction == null)
			{
				return;
			}
			instruction.Instruct(_anim);
		}
	}
}

