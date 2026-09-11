using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace ReactUI;

public class UIVariableBindHelper
{
	public class VarBindData
	{
		public string m_varName;

		public PropertyInfo m_prop;

		public FieldInfo m_field;
	}

	public class EventBindData
	{
		public string m_eventName;

		public MethodInfo m_method;
	}

	public class GameObjectBindData
	{
		public string m_varName;

		public PropertyInfo m_prop;

		public FieldInfo m_field;
	}

	public class AutoBindForClass
	{
		public List<VarBindData> m_bindVar;

		public List<EventBindData> m_bindEvent;

		public List<GameObjectBindData> m_bindGameObject;
	}

	private static Dictionary<Type, AutoBindForClass> m_cacheBindProp;

	private static string prefix_var;

	private static string prefix_event;

	private static string prefix_gameobject;

	public static void AutoBind(object obj, GameObject view, Type baseClass = null)
	{
	}

	private static void AutoBindGameObject(object targetObject, GameObject rootObj, List<GameObjectBindData> bind)
	{
	}

	public static T GetCustomAttribute<T>(PropertyInfo prop) where T : class
	{
		return null;
	}

	public static T GetCustomAttribute<T>(FieldInfo prop) where T : class
	{
		return null;
	}

	public static T GetCustomAttribute<T>(MethodInfo prop) where T : class
	{
		return null;
	}

	private static void GenerateAutoBind(AutoBindForClass autoBind, Type t)
	{
	}

	private static AutoBindForClass GenerateAutoBind(Type t, Type baseClass = null)
	{
		return null;
	}
}
