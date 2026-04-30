using UnityEngine;

namespace TW.Animators.Instructors
{

	[System.Serializable]
	public class LayerCommand : AnimatorCommandBase
	{
		[Attributes.AnimatorLayer, SerializeField] private int _layer;
		[SerializeField, Range(0f, 1f)] private float _weight;

		public override void Instruct(Animator animator)
		{
			animator.SetLayerWeight(_layer, _weight);
		}
	}
}
