using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingView : UIView
{
	private Image _progressImage;

    public LoadingView(GameObject gameObject) : base(gameObject)
    {
    }

	public override void Init()
	{
		_progressImage = UITool.GetComponent<Image>(_gameObject, "ProgressBar/Progress");
		_progressImage.fillAmount = 0f;
	}

	public void SetProgress(float progress)
	{
		_progressImage.fillAmount = progress;
	}
}
