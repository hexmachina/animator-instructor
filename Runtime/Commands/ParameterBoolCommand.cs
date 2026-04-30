using UnityEngine;

namespace TW.Animators.Instructors
{

	[System.Serializable]
	public class ParameterBoolCommand : AnimatorCommandBase
	{
		[Attributes.AnimatorParameter(AnimatorControllerParameterType.Bool)] public int parameter;
		public bool desiredValue;
		public override void Instruct(Animator animator)
		{
			animator.SetBool(parameter, desiredValue);
		}
	}
}
