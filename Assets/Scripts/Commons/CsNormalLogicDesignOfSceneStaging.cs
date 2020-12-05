using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Imageのカラーセット
/// <para/>カラーセットしたImageを取り出す
/// </summary>
public class CsNormalLogicDesignOfSceneStaging
{
    /// <summary>赤のカラーレベル</summary>
    public float red { get; set; }
    /// <summary>緑のカラーレベル</summary>
    public float green { get; set; }
    /// <summary>青のカラーレベル</summary>
    public float blue { get; set; }
    /// <summary>不透明度のレベル</summary>
    public float alpha { get; set; }
    /// <summary>フェード処理に必要なImage情報一時格納</summary>
    private Color fadeImageColorIsBuffer;
    /// <summary>フェード処理に必要なImage情報</summary>
    public Color fadeImageColor
    {
        get { return new Color(red, green, blue, alpha); }
    }

    public CsNormalLogicDesignOfSceneStaging()
    {
        this.red = CsNormalLevelDesignOfCommon.IMAGE_COLOR_LEVEL_MIN;
        this.green = CsNormalLevelDesignOfCommon.IMAGE_COLOR_LEVEL_MIN;
        this.blue = CsNormalLevelDesignOfCommon.IMAGE_COLOR_LEVEL_MIN;
        this.alpha = CsNormalLevelDesignOfCommon.IMAGE_ALPHA_LEVEL_MIN;
        this.fadeImageColorIsBuffer = new Color(red, green, blue, alpha);
    }
}
