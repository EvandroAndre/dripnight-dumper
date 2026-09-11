using System;
using System.Collections.Generic;

namespace COW.Gameplay.UGC;

internal class UGCPropertyFormulaMgr
{
	private UGCEntityDataStore m_EntityModule;

	private Dictionary<string, Dictionary<long, UGCPropertyFormulaRepItem>> m_PropertyFormulaMap;

	private Dictionary<string, UGCPropertyFormulaRepItem> m_FormulaMap;

	private Dictionary<string, Action> m_OnFormulaChangeEvent;

	public UGCPropertyFormulaMgr(UGCEntityDataStore entityModule)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnAddEntity(string formulaID)
	{
	}

	private void OnRemoveEntity(string formulaID)
	{
	}

	private void OnFormulaChangeByFormulaID(string formulaID)
	{
	}

	private void OnFormulaChangeByBindEntityID(string bindEntityID)
	{
	}

	private UGCPropertyFormulaRepItem GetFormula(string entityID, long propertyID)
	{
		return null;
	}

	private float InternalCalcPropertyValue(float baseValue, string entityID, long propertyID)
	{
		return 0f;
	}

	public void RegisterFormulaChangeEvent(string bindEntityID, Action handler)
	{
	}

	public void UnRegisterFormulaChangeEvent(string bindEntityID, Action handler)
	{
	}

	public float CalcPropertyValueForFloat32(float baseValue, string entityID, int propertyID, bool forcePositive = true)
	{
		return 0f;
	}

	public int CalcPropertyValueForInt(int baseValue, string entityID, int propertyID, bool forcePositive = true)
	{
		return 0;
	}
}
