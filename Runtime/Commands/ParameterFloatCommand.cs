using UnityEngine;

namespace TW.Animators.Instructors
{

	[System.Serializable]
	public class ParameterFloatCommand : AnimatorCommandBase
	{
		[Attributes.AnimatorParameter(AnimatorControllerParameterType.Float)] public int parameter;
		public float value;

		public override void Instruct(Animator animator)
		{
			animator.SetFloat(parameter, value);
		}
	}
}
