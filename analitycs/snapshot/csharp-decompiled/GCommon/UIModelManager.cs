using System;
using System.Collections.Generic;

namespace GCommon;

public class UIModelManager : SingletonModule<UIModelManager>
{
	private Dictionary<Type, UIBaseModel> m_UIModels;

	private List<UIBaseModel> m_ModelLists;

	public T GetModel<T>() where T : UIBaseModel, new()
	{
		return null;
	}

	public UIBaseModel GetModel(Type modelType)
	{
		return null;
	}

	public bool HasModel(Type modelType)
	{
		return false;
	}

	public List<Type> GetObservedModelType(IUIModelDataChangeObserver observer)
	{
		return null;
	}

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public void ClearCache()
	{
	}

	public void LoginOffline()
	{
	}

	public void UserLogin(object[] data)
	{
	}

	public void UserLogout(object[] data)
	{
	}

	public void SceneChange(object[] data)
	{
	}

	private IEnumerable<UIBaseModel> GetModels()
	{
		return null;
	}
}
