using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using NumberExtension;

public class NumberSetting : MonoBehaviour {
	Text _text ;

	ulong _value;
	public ulong Number{
		set{
			DebugUtils.Assert(_findText != null, "The delegate : _findText == null");
			DebugUtils.Assert(_text != null, "Text == NULL !");
			_value = value;
			_text.text = value.ToThousandFormatString();
		}
		get {
			return _value;
		}
	}

	public delegate Text FindTextHandler();
	FindTextHandler _findText;
	public FindTextHandler FindText{
		set{
			_findText = value; 
			_text = _findText();
		} 
	}
}
