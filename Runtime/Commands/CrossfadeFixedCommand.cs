using UnityEngine;

namespace TW.Animators.Instructors
{

	[System.Serializable]
	public class CrossfadeFixedCommand : AnimatorCommandBase
	{
		[Header("Crossfade Fixed")]
		[Attributes.AnimatorState] public int stateHash;
		public float fixedDurationTransition;
		[Attributes.AnimatorLayer] public int layer;
		public float fixedTimeOffset;

		public override void Instruct(Animator animator)
		{
			animator.CrossFadeInFixedTime(stateHash, fixedDurationTransition, layer, fixedTimeOffset);
		}
	}
}

