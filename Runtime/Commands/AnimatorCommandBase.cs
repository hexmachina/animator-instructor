using UnityEngine;

namespace TW.Animators.Instructors
{

	[System.Serializable]
	public abstract class AnimatorCommandBase
	{
		public abstract void Instruct(Animator animator);
	}
}

