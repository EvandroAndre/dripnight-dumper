using System.Collections.Generic;
using COW.Gameplay.UGC;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudUGCTutorialRestrictionBaseController : UIBaseController
{
	protected class TutorialRestrictionEntry
	{
		public GameObject target;

		public UIBaseController controller;

		public uint controllerVisibilityFlag;

		public UIButton button;

		public UIToggleButton toggleButton;

		public UIScrollView scrollView;

		public UIInput input;

		public BitArrayBoolean visibleFlag;

		public bool enabled;

		public TutorialRestrictionEntry(GameObject go)
		{
		}

		public TutorialRestrictionEntry(UIBaseController ctrl, uint visibilityFlag)
		{
		}

		public TutorialRestrictionEntry(UIButton btn)
		{
		}

		public TutorialRestrictionEntry(UIScrollView sv)
		{
		}

		public TutorialRestrictionEntry(UIInput uiInput)
		{
		}
	}

	private const uint RESTRICTION_VIS_NORMAL = 1u;

	private const uint RESTRICTION_VIS_TUTORIAL = 2u;

	private Dictionary<UGCTutorialRestrictionType, List<TutorialRestrictionEntry>> m_RestrictionEntries;

	protected void InitRestrictionSystem()
	{
	}

	protected void RegisterRestrictionEntry(UGCTutorialRestrictionType type, GameObject go)
	{
	}

	protected void RegisterRestrictionController(UGCTutorialRestrictionType type, uint visibilityFlag = 1073741824u)
	{
	}

	protected void RegisterRestrictionEntry(UGCTutorialRestrictionType type, UIButton btn)
	{
	}

	protected void RegisterRestrictionEntry(UGCTutorialRestrictionType type, UIButton btn, bool keepCurrentVisible)
	{
	}

	protected void RegisterRestrictionEntry(UGCTutorialRestrictionType type, UIScrollView sv)
	{
	}

	protected void RegisterRestrictionEntry(UGCTutorialRestrictionType type, UIInput input)
	{
	}

	protected void ClearRestrictionEntries(UGCTutorialRestrictionType type)
	{
	}

	private void RegisterRestrictionEntry(UGCTutorialRestrictionType type, TutorialRestrictionEntry entry)
	{
	}

	protected void SetRestrictionNormalVisible(UGCTutorialRestrictionType type, bool visible)
	{
	}

	private void ApplyRestrictionEntry(TutorialRestrictionEntry entry)
	{
	}

	protected virtual UGCTutorialRestrictionManager GetRestrictionManager()
	{
		return null;
	}

	private void OnTutorialRestrictionChanged()
	{
	}

	protected void ApplyTutorialRestrictions()
	{
	}

	protected virtual void OnAfterTutorialRestrictionApplied()
	{
	}
}
