using UnityEngine;

namespace TW.Animators.Instructors
{
	[System.Serializable]
	public class CrossfadeCommand : AnimatorCommandBase
	{
		[Attributes.AnimatorState] public int stateHash;
		[Range(0, 1)] public float normalizedTransitionDuraiton;
		[Range(0, 1)] public float normalizedTimeOffset;
		public override void Instruct(Animator animator)
		{
			animator.CrossFade(stateHash, normalizedTransitionDuraiton, -1, normalizedTimeOffset);
		}
	}
}
