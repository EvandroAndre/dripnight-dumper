using System;
using UnityEngine;

namespace COW;

public class CommonSettingItemScalableSliderData : CommonSettingItemDataBase
{
	public Func<float> GetSliderValueFunc;

	public Func<float, int> SliderValueProcess;

	public Func<float, float> GetOrigionValue;

	public Action<float> SetSliderValue;

	public bool IsShowAdhesionPoint;

	public Func<Vector3, Vector3> ResetAdhesionPoint;

	public Func<float, float> Adhesion;
}
