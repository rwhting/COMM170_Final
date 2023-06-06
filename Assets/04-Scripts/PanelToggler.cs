using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelToggler : MonoBehaviour
{
	public GameObject Panel;
	public void TogglePanel()
	{
		Panel.SetActive(!Panel.activeSelf);
	}
}
