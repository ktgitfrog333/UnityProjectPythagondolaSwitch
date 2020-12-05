using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 共通ロジックを管理
/// </summary>
public class CsNormalLogicDesignOfCommon
{
    /// <summary>
    /// ゲームオブジェクトにコンポーネントされているスクリプトを取得
    /// </summary>
    /// <typeparam name="Type">スクリプトクラスの型</typeparam>
    /// <param name="key">ゲームオブジェクト名</param>
    /// <returns>スクリプト</returns>
    public Type GetComponentScriptInGameObject<Type>(string key)
    {
        GameObject g = GameObject.Find(key);
        object o = null;

        if (!ReferenceEquals(g, null) && g != null)
        {
            var sc = g.GetComponent<Type>();
            if (!ReferenceEquals(sc, null) && sc != null)
            {
                o = sc;
            }
        }
        return (Type)o;
    }
}
