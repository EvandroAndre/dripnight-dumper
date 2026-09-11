using COW.GamePlay;
using GCommon;
using message;

namespace COW;

internal class UIHudSceneEditItemGenResultController : UIBaseController
{
	public class UIData
	{
		public bool IsSelected;

		public int Index;

		public KCJDEKIJAKH TemplateData;
	}

	private UIHudSceneEditItemGenResultView m_View;

	private KCJDEKIJAKH _003CTemplateData_003Ek__BackingField;

	private SceneEditAgent m_Agent;

	private bool mIsCurModeForbidden;

	private int index;

	public KCJDEKIJAKH TemplateData
	{
		get
		{
			return _003CTemplateData_003Ek__BackingField;
		}
		private set
		{
			_003CTemplateData_003Ek__BackingField = value;
		}
	}

	public SceneEditAgent Agent => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(UIData uiData)
	{
	}

	public void OnAddPrefabInPointDragMode()
	{
	}

	public void OnBtnClicked()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
