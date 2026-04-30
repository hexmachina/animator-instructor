using UnityEngine;

namespace TW.Animators.Instructors
{

	[System.Serializable]
	public class ParameterTriggerCommand : AnimatorCommandBase
	{
		[Attributes.AnimatorParameter(AnimatorControllerParameterType.Trigger)] public int parameter;

		public override void Instruct(Animator animator)
		{
			animator.SetTrigger(parameter);
		}
	}
}

