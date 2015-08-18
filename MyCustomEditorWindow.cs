using UnityEngine;
using System.Collections;
using UnityEditor;

public class MyCustomEditorWindow : EditorWindow {
	private static Texture WindowTitleTexture{
		get{
			return Resources.Load("title_tex") as Texture;
		}
	}

	//顶级菜单使用中文会出现问题，一定要使用英文
	[MenuItem("Custom Menu Name/Menu Item Name")]
	public static void OpenCustomEditorWindow(){
		var window = EditorWindow.CreateInstance<MyCustomEditorWindow>();

		window.titleContent = WindowTitleTexture ? 
			new GUIContent("Title Name", WindowTitleTexture) :
			new GUIContent("Title Name");
		window.Show();
	}

	#region GUI
	void OnGUI(){
		EditorGUILayout.HelpBox ("This is a HelpBox", MessageType.Info);
		EditorGUILayout.LabelField("This is a LabelField");
		EditorGUILayout.PrefixLabel("This is a PrefixLabel");

		EditorGUILayout.Toggle("This is a Toggle", true);

		if(GUILayout.Button("This is a Button")){

		}
	}
	#endregion
}
