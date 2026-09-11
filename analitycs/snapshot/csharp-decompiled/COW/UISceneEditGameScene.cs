using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using COW.Gameplay.UGC;
using GCommon;

namespace COW;

internal class UISceneEditGameScene : UIInGameScene
{
	private sealed class _003C_003Ec__DisplayClass41_0
	{
		public UIModelOptionalDownload modelOptionalDownload;

		public UGCSimpleDownloadTask ugcDownloadTask;

		public List<ResourceID> resourceIds;

		public bool downloadAllResOfGameMode;

		public object[] data;

		public ResDownloadType resType;

		public UIModelMapOpeningInfo modelMap;

		internal void _003COnShowDownloadPopup_003Eb__0()
		{
		}
	}

	private sealed class _003COpenCommonHud_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UISceneEditGameScene _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COpenCommonHud_003Ed__24(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private UIHudSceneEditConfirmWndController uiSceneEditConfirmWnd;

	private HNDHJGJILHC m_Game;

	private UIHudWorkshopPhotographModeController m_PhotoCtrl;

	private UIHudBtnWorkshopPhotographController m_PhotoBtnCtrl;

	public UIHudSceneEditCameraHeightController CameraHeightCtrl;

	public UIHudSceneEditAdjustFloorPlaneController FloorCtrl;

	public UIHudSceneEditMorePanelController MorePanelCtrl;

	private UIHudSceneEditFuncAttributeSettingController m_FuncAttributeSettingCtrl;

	private UIHudEntityGetterController m_EntityGetter;

	private UISceneEditInstanceGroupSwitchController m_GroupSwitchCtrl;

	private UIHudSceneEditItemAdjustSimplePanelController m_ItemAdjustSimplePanelCtrl;

	public UIHudSceneEditTransformGizmoController m_TransformGizmoCtrl;

	public UIHudSceneEditPaintPanelController PaintPanelCtrl;

	public UIHudSceneEditPaintModeController PaintModePickCtrl;

	public UIHudNewSceneEditItemPanelController ItemPanelCtrl;

	public UIHudMovingJoystickController MovingJoystickController;

	public UIHudSceneEditLeftOptionController SceneEditLeftOptionController;

	public UIHudSceneEditFPVController SceneEditFPVController;

	private UIHudResourceShopController m_ResourceShopController;

	public UIHUDAIChatParentController AIChatParentController;

	public UIHudSceneEditItemGenController ItemGenController;

	public UIHudSceneEditFrameController FrameController;

	private UIHudSceneEditInspectorController m_InspectorController;

	private SceneEditAgent m_Agent => null;

	protected override IEnumerator OpenCommonHud()
	{
		return null;
	}

	protected override void OnInit()
	{
	}

	public override void RegisterGameEventHandler()
	{
	}

	protected override void OnDestory()
	{
	}

	protected override bool OnCheckGroupNtf()
	{
		return false;
	}

	private bool OnEscapeClick()
	{
		return false;
	}

	private void OnHandleConfirmWnd(object[] args)
	{
	}

	private void OnHandleHttpRequestError(object[] args)
	{
	}

	private void OnTakingPhoto(object[] args)
	{
	}

	private void OnOpenTips(object[] data)
	{
	}

	private void ShowAttributeController(bool isShow)
	{
	}

	private void OnShowObjectAttribute(object[] data)
	{
	}

	private void OnShowFuncAttributeSettingUI(object[] data)
	{
	}

	private void OnEntityGetter(object[] data)
	{
	}

	private void OnOpenResourceShop(object[] data)
	{
	}

	private void OnCloseResourceShop()
	{
	}

	private void OnShowDownloadPopup(object[] data)
	{
	}

	public void SetRighPanelState()
	{
	}

	public IEnumerator _003C_003EiFixBaseProxy_OpenCommonHud()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnInit()
	{
	}

	public void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}

	public new bool _003C_003EiFixBaseProxy_OnCheckGroupNtf()
	{
		return false;
	}
}
