using System;
using UnityEngine;

namespace COW.Gameplay.UGC;

public abstract class UGCPreviewForPackage : UGCPreview
{
	private UGCCustomLevelObjectEditorPackageInfo _003CpackageInfo_003Ek__BackingField;

	public UGCCustomLevelObjectEditorPackageInfo packageInfo
	{
		get
		{
			return _003CpackageInfo_003Ek__BackingField;
		}
		set
		{
			_003CpackageInfo_003Ek__BackingField = value;
		}
	}

	public virtual void Load(Action<UnityEngine.Object> action)
	{
	}

	protected abstract void LoadFromUUID(string assetUUID, Action<UnityEngine.Object> action);
}
