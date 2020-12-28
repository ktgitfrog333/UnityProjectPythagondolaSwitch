using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// タイマーを計測する
/// </summary>
public class ScTimer : MonoBehaviour
{
    /// <summary>計測時間</summary>
    public float countTime;
    /// <summary>タイマーコルーチン</summary>
    private IEnumerator timerCoroutine;
    /// <summary>マスクと位置情報を保持するBeanリスト</summary>
    private List<CsRectMask2DBean> rectMask2DBeanList;
    /// <summary>タイマーのプレハブ情報</summary>
    [SerializeField]
    private GameObject timerPrefab;

    // Start is called before the first frame update
    void Start()
    {
        this.rectMask2DBeanList = new List<CsRectMask2DBean>();
        this.countTime = 0f;
        this.rectMask2DBeanList = VisibleNumberTexture(float.Parse(countTime.ToString("F2")));
        CreateMaskPrefabTimer(rectMask2DBeanList);

        this.timerCoroutine = CountTimer();
    }

    /// <summary>
    /// タイマーのマスクと位置情報を元にゲームオブジェクトを生成する
    /// </summary>
    /// <param name="rectMask2DBeanList">タイマーのマスクと位置情報</param>
    private void CreateMaskPrefabTimer(List<CsRectMask2DBean> rectMask2DBeanList)
    {
        // 一度クリーンにする
        if (0 < GameObject.FindGameObjectsWithTag(CsNormalLevelDesignOfTimer.STRING_PREFAB_TAG_TIMER).Length)
        {
            foreach (GameObject g in GameObject.FindGameObjectsWithTag(CsNormalLevelDesignOfTimer.STRING_PREFAB_TAG_TIMER))
            {
                Destroy(g);
            }

        }
        // 再度生成
        for (int i = 0; i < rectMask2DBeanList.Count; i++)
        {
            CsRectMask2DBean r = rectMask2DBeanList[i];
            GameObject pf = timerPrefab;
            Vector3 v3 = new Vector3(transform.position.x + r.posX - (rectMask2DBeanList.Count - i) * 32f, transform.position.y + r.posY, transform.position.z + r.posZ);
            GameObject obj = (GameObject)Instantiate(pf, v3, Quaternion.identity, this.gameObject.transform);
            obj.GetComponent<RectMask2D>().padding = new Vector4(r.paddingLeft, r.paddingTop, r.paddingRight, r.paddingBottom);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    /// 時間を計測する
    /// </summary>
    /// <returns>時間管理コルーチン</returns>
    private IEnumerator CountTimer()
    {
        while(true)
        {
            this.countTime += Time.deltaTime;
            this.rectMask2DBeanList = VisibleNumberTexture(float.Parse(countTime.ToString("F2")));
            CreateMaskPrefabTimer(rectMask2DBeanList);
            yield return null;
        }
    }

    /// <summary>
    /// タイマーを有効にする
    /// </summary>
    public void TimerEnableSwitch()
    {
        StartCoroutine(timerCoroutine);
    }

    /// <summary>
    /// タイマーを無効にする
    /// </summary>
    public void TimerDisableSwitch()
    {
        StopCoroutine(timerCoroutine);
    }

    /// <summary>
    /// 与えられた数字をマスクパラメータ情報へ変換してリスト化する
    /// </summary>
    /// <param name="number">数字</param>
    /// <returns>マスクパラメータ情報</returns>
    private List<CsRectMask2DBean> VisibleNumberTexture(float number)
    {
        List<CsRectMask2DBean> list = new List<CsRectMask2DBean>();

        if (CsNormalLevelDesignOfCommon.NATURAL_NUMBER < number)
        {
            string strNumber = number.ToString();
            // 桁数を調べる
            int length = strNumber.Length;
            for (int i = 0; i < length; i++)
            {
                string strResult = strNumber.Substring(i, 1);
                CsRectMask2DBean rectMask2DBean = new CsRectMask2DBean();
                int max = 320;
                int trout = 32;

                int result = 0;
                if (!(CsNormalLevelDesignOfTimer.STRING_COMMA).Equals(strResult))
                {
                    result = int.Parse(strResult);
                }
                else
                {
                    result = CsNormalLevelDesignOfTimer.NUMBER_INDEX_COMMA;
                }
                rectMask2DBean.paddingLeft = trout * result;
                rectMask2DBean.paddingRight = max - (trout * result);
                rectMask2DBean.posX = max - (trout * result) + CsNormalLevelDesignOfTimer.TIMER_POS_X_OFF_SET;
                rectMask2DBean.posY = CsNormalLevelDesignOfTimer.TIMER_POS_Y_OFF_SET;
                list.Add(rectMask2DBean);
            }
        }
        return list;
    }
}
