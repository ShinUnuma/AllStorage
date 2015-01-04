using UnityEngine;
using System.Collections;

public class Singleton<T> where T : class, new()
{
	static readonly T instance = new T();

	static Singleton() {  }
	
	protected Singleton() { }
	
	public static T Instance { get { return instance; } }
}
