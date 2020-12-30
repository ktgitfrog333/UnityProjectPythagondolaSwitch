using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScStageSelectMotion : MonoBehaviour
{
    /// <summary>各ステージのBeanクラス</summary>
    CsStageSelectMotionBean stageSelectBean;
    /// <summary>各ステージの遷移制御ロジック</summary>
    CsNormalLogicDesignOfStageSelect stageSelect;

    private void Awake()
    {
        this.stageSelectBean = new CsStageSelectMotionBean();
        this.stageSelect = new CsNormalLogicDesignOfStageSelect();
    }
    // Start is called before the first frame update
    void Start()
    {
        this.stageSelectBean.stageName = CsNormalLevelDesignOfStageSelect.THUMBNAIL_SCENES_STAGE_01;
        this.stageSelectBean = stageSelect.GetScrolledThumbnail(this.stageSelectBean);
        ScrollThumbnail(this.stageSelectBean);
    }

    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    /// スクロールボタンが押された場合に実行
    /// </summary>
    /// <param name="mode">状態</param>
    public void PushedScrollButton(string mode)
    {
        this.stageSelectBean.actionEvent = mode;
        this.stageSelectBean = stageSelect.GetScrolledActionEvent(this.stageSelectBean);
        this.stageSelectBean = stageSelect.GetScrolledThumbnail(this.stageSelectBean);
        ScrollThumbnail(this.stageSelectBean);
    }

    /// <summary>
    /// 各ステージのBean情報を受け取って位置とスケールを調整する
    /// </summary>
    /// <param name="stageSelectBean">ステージ情報</param>
    private void ScrollThumbnail(CsStageSelectMotionBean stageSelectBean)
    {
        foreach(Transform tran in transform)
        {
            GameObject game = tran.gameObject;
            if (game.name.Equals(CsNormalLevelDesignOfStageSelect.THUMBNAIL_SCENES_STAGE_01))
            {
                if (stageSelectBean.stage01.setActive)
                {
                    Vector3 position = game.transform.localPosition;
                    position.x = stageSelectBean.stage01.posX;
                    position.y = stageSelectBean.stage01.posY;
                    position.z = stageSelectBean.stage01.posZ;
                    game.transform.localPosition = position;
                    Vector3 scale = game.transform.localScale;
                    scale.x = stageSelectBean.stage01.scale_X;
                    scale.y = stageSelectBean.stage01.scale_Y;
                    scale.z = stageSelectBean.stage01.scale_Z;
                    game.transform.localScale = scale;

                    if (stageSelectBean.stage01.loadSceneActiveFlag)
                    {
                        game.transform.GetChild(0).gameObject.GetComponent<ScStageSelect>().LoadSceneActiveFlagEnableSwitch();
                    }
                    else
                    {
                        game.transform.GetChild(0).gameObject.GetComponent<ScStageSelect>().LoadSceneActiveFlagDisableSwitch();
                    }
                }
                game.SetActive(stageSelectBean.stage01.setActive);
            }
            else if (game.name.Equals(CsNormalLevelDesignOfStageSelect.THUMBNAIL_SCENES_STAGE_02))
            {
                if (stageSelectBean.stage02.setActive)
                {
                    Vector3 position = game.transform.localPosition;
                    position.x = stageSelectBean.stage02.posX;
                    position.y = stageSelectBean.stage02.posY;
                    position.z = stageSelectBean.stage02.posZ;
                    game.transform.localPosition = position;
                    Vector3 scale = game.transform.localScale;
                    scale.x = stageSelectBean.stage02.scale_X;
                    scale.y = stageSelectBean.stage02.scale_Y;
                    scale.z = stageSelectBean.stage02.scale_Z;
                    game.transform.localScale = scale;

                    if (stageSelectBean.stage02.loadSceneActiveFlag)
                    {
                        game.transform.GetChild(0).gameObject.GetComponent<ScStageSelect>().LoadSceneActiveFlagEnableSwitch();
                    }
                    else
                    {
                        game.transform.GetChild(0).gameObject.GetComponent<ScStageSelect>().LoadSceneActiveFlagDisableSwitch();
                    }
                }
                game.SetActive(stageSelectBean.stage02.setActive);
            }
            else if (game.name.Equals(CsNormalLevelDesignOfStageSelect.THUMBNAIL_SCENES_STAGE_03))
            {
                if (stageSelectBean.stage03.setActive)
                {
                    Vector3 position = game.transform.localPosition;
                    position.x = stageSelectBean.stage03.posX;
                    position.y = stageSelectBean.stage03.posY;
                    position.z = stageSelectBean.stage03.posZ;
                    game.transform.localPosition = position;
                    Vector3 scale = game.transform.localScale;
                    scale.x = stageSelectBean.stage03.scale_X;
                    scale.y = stageSelectBean.stage03.scale_Y;
                    scale.z = stageSelectBean.stage03.scale_Z;
                    game.transform.localScale = scale;

                    if (stageSelectBean.stage03.loadSceneActiveFlag)
                    {
                        game.transform.GetChild(0).gameObject.GetComponent<ScStageSelect>().LoadSceneActiveFlagEnableSwitch();
                    }
                    else
                    {
                        game.transform.GetChild(0).gameObject.GetComponent<ScStageSelect>().LoadSceneActiveFlagDisableSwitch();
                    }
                }
                game.SetActive(stageSelectBean.stage03.setActive);
            }
        }
    }
}
