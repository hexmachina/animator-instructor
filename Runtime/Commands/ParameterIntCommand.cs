using UnityEngine;

namespace TW.Animators.Instructors
{

	[System.Serializable]
	public class ParameterIntCommand : AnimatorCommandBase
	{
		[Attributes.AnimatorParameter(AnimatorControllerParameterType.Int)] public int parameter;
		public int value;
		public override void Instruct(Animator animator)
		{
			animator.SetInteger(parameter, value);
		}
	}
}
