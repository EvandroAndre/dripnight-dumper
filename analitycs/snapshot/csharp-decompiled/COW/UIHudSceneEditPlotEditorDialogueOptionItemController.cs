using GCommon;
using message;

namespace COW;

public class UIHudSceneEditPlotEditorDialogueOptionItemController : UIBaseController, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public MPGMIACDBGN plot;

		public UIHudSceneEditPlotEditorDialogueOptionItemController _003C_003E4__this;

		internal void _003COnBtnTurnToClick_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass9_1
	{
		public HMJODCEJBFF dialogue;

		public UIHudSceneEditPlotEditorDialogueOptionItemController _003C_003E4__this;

		internal void _003COnBtnTurnToClick_003Eb__1()
		{
		}
	}

	private UIHudSceneEditPlotEditorDialogueOptionItemView m_View;

	private UIModelUGCPlotEdit m_Model;

	private HOOIPPJLMCK m_OptionData;

	private HMJODCEJBFF m_DialogueBelongs;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(HOOIPPJLMCK optionData, HMJODCEJBFF dialogueBelongs)
	{
	}

	public void SetSelected(bool value)
	{
	}

	private void OnBtnSelectClick()
	{
	}

	private void OnBtnTurnToClick()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
