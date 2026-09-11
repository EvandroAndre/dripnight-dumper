using System;
using GCommon;
using UnityEngine;

namespace COW;

public class UIPetSkillSlotController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public Action action;

		internal void _003CAddSlotClick_003Eb__0()
		{
		}
	}

	private uint m_PetSkillID;

	private bool m_IsEmpty;

	private UIPetSkillSlotView m_View;

	private Color m_Gray;

	private UIModelPet m_ModelPet;

	private UIModelLoadout m_ModelLoadout;

	protected override void OnUIInit()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void SetData(uint skillID, bool forceShowIcon = false)
	{
	}

	public void InitState()
	{
	}

	private void SetSkillIcon(uint skillId)
	{
	}

	private void OnSlotClick()
	{
	}

	public void AddSlotClick(Action action, bool needToClear = false)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
