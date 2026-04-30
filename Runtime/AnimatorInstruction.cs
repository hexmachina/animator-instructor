using System.Collections.Generic;
using TW.Attributes;
using UnityEngine;

namespace TW.Animators.Instructors
{

	[CreateAssetMenu(menuName = "Data/Animator/Instruction")]
	public class AnimatorInstruction : ScriptableObject
	{
		[SerializeReference, SR] private List<AnimatorCommandBase> _commands = new();

		public void Instruct(Component component)
		{
			if (component.TryGetComponent(out Animator animator))
			{
				Instruct(animator);
			}
		}

		public void Instruct(Animator animator)
		{
			foreach (var item in _commands)
			{
				if (item == null)
				{
					continue;
				}
				item.Instruct(animator);
			}
		}
	}
}

