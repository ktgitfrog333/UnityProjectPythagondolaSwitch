using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ステージサムネイル遷移の制御
/// </summary>
public class CsNormalLogicDesignOfStageSelect
{
    /// <summary>
    /// スクロールボタンのステータスとステージサムネイル状態を元に次に遷移するステージ情報を取得
    /// </summary>
    /// <param name="stageSelectBean">ステージ情報</param>
    /// <returns>ステージ情報</returns>
    public CsStageSelectMotionBean GetScrolledActionEvent(CsStageSelectMotionBean stageSelectBean)
    {
        CsStageSelectMotionBean stageSelectBeanResult = new CsStageSelectMotionBean();
        stageSelectBeanResult = stageSelectBean;
        // stage01 → stage02
        if (stageSelectBean.stageName.Equals(CsNormalLevelDesignOfStageSelect.THUMBNAIL_SCENES_STAGE_01)
            && stageSelectBean.actionEvent.Equals(CsNormalLevelDesignOfStageSelect.PUSHED_BUTTON_NAME_NEXT))
        {
            stageSelectBeanResult.stageName = CsNormalLevelDesignOfStageSelect.THUMBNAIL_SCENES_STAGE_02;
        }
        // Empty ← stage01（遷移無し）
        else if (stageSelectBean.stageName.Equals(CsNormalLevelDesignOfStageSelect.THUMBNAIL_SCENES_STAGE_01)
            && stageSelectBean.actionEvent.Equals(CsNormalLevelDesignOfStageSelect.PUSHED_BUTTON_NAME_BACK))
        {
            // 遷移無し
        }
        // stage02 → stage03
        else if (stageSelectBean.stageName.Equals(CsNormalLevelDesignOfStageSelect.THUMBNAIL_SCENES_STAGE_02)
            && stageSelectBean.actionEvent.Equals(CsNormalLevelDesignOfStageSelect.PUSHED_BUTTON_NAME_NEXT))
        {
            stageSelectBeanResult.stageName = CsNormalLevelDesignOfStageSelect.THUMBNAIL_SCENES_STAGE_03;
        }
        // stage01 ← stage02
        else if (stageSelectBean.stageName.Equals(CsNormalLevelDesignOfStageSelect.THUMBNAIL_SCENES_STAGE_02)
            && stageSelectBean.actionEvent.Equals(CsNormalLevelDesignOfStageSelect.PUSHED_BUTTON_NAME_BACK))
        {
            stageSelectBeanResult.stageName = CsNormalLevelDesignOfStageSelect.THUMBNAIL_SCENES_STAGE_01;
        }
        // stage03 → Empty（遷移無し）
        else if (stageSelectBean.stageName.Equals(CsNormalLevelDesignOfStageSelect.THUMBNAIL_SCENES_STAGE_03)
            && stageSelectBean.actionEvent.Equals(CsNormalLevelDesignOfStageSelect.PUSHED_BUTTON_NAME_NEXT))
        {
            // 遷移無し
        }
        // stage02 ← stage03
        else if (stageSelectBean.stageName.Equals(CsNormalLevelDesignOfStageSelect.THUMBNAIL_SCENES_STAGE_03)
            && stageSelectBean.actionEvent.Equals(CsNormalLevelDesignOfStageSelect.PUSHED_BUTTON_NAME_BACK))
        {
            stageSelectBeanResult.stageName = CsNormalLevelDesignOfStageSelect.THUMBNAIL_SCENES_STAGE_02;
        }
        return stageSelectBeanResult;
    }

    /// <summary>
    /// ステージ情報を受け取ってサムネイル表示を切り替える
    /// </summary>
    /// <param name="stageSelectBean">ステージ情報</param>
    /// <returns>ステージ情報</returns>
    public CsStageSelectMotionBean GetScrolledThumbnail(CsStageSelectMotionBean stageSelectBean)
    {
        CsStageSelectMotionBean stageSelectBeanResult = new CsStageSelectMotionBean();
        stageSelectBeanResult = stageSelectBean;
        if (stageSelectBean.stageName != null && !CsNormalLevelDesignOfCommon.BLANK.Equals(stageSelectBean.stageName))
        {
            // ステージ１を中央に表示（最前項目の表示の為、左側にサムネイルは表示しない）
            if (CsNormalLevelDesignOfStageSelect.THUMBNAIL_SCENES_STAGE_01.Equals(stageSelectBean.stageName))
            {
                CsStageSelectBean bean1 = new CsStageSelectBean();
                bean1.posY = CsNormalLevelDesignOfStageSelect.THUMBNAIL_POSITION_CENTER[CsNormalLevelDesignOfStageSelect.PosY];
                bean1.loadSceneActiveFlag = CsNormalLevelDesignOfCommon.TRUE;
                stageSelectBeanResult.stage01 = bean1;
                CsStageSelectBean bean2 = new CsStageSelectBean();
                bean2.posX = CsNormalLevelDesignOfStageSelect.THUMBNAIL_POSITION_RIGHT[CsNormalLevelDesignOfStageSelect.PosX];
                bean2.posY = CsNormalLevelDesignOfStageSelect.THUMBNAIL_POSITION_RIGHT[CsNormalLevelDesignOfStageSelect.PosY];
                bean2.scale_X = CsNormalLevelDesignOfStageSelect.THUMBNAIL_POSITION_RIGHT[CsNormalLevelDesignOfStageSelect.Scale_X];
                bean2.scale_Y = CsNormalLevelDesignOfStageSelect.THUMBNAIL_POSITION_RIGHT[CsNormalLevelDesignOfStageSelect.Scale_Y];
                bean2.loadSceneActiveFlag = CsNormalLevelDesignOfCommon.FALSE;
                stageSelectBeanResult.stage02 = bean2;
                CsStageSelectBean bean3 = new CsStageSelectBean();
                bean3.loadSceneActiveFlag = CsNormalLevelDesignOfCommon.FALSE;
                bean3.setActive = CsNormalLevelDesignOfCommon.FALSE;
                stageSelectBeanResult.stage03 = bean3;
            }
            // ステージ２を中央に表示
            else if (CsNormalLevelDesignOfStageSelect.THUMBNAIL_SCENES_STAGE_02.Equals(stageSelectBean.stageName))
            {
                CsStageSelectBean bean1 = new CsStageSelectBean();
                bean1.posX = CsNormalLevelDesignOfStageSelect.THUMBNAIL_POSITION_LEFT[CsNormalLevelDesignOfStageSelect.PosX];
                bean1.posY = CsNormalLevelDesignOfStageSelect.THUMBNAIL_POSITION_LEFT[CsNormalLevelDesignOfStageSelect.PosY];
                bean1.scale_X = CsNormalLevelDesignOfStageSelect.THUMBNAIL_POSITION_LEFT[CsNormalLevelDesignOfStageSelect.Scale_X];
                bean1.scale_Y = CsNormalLevelDesignOfStageSelect.THUMBNAIL_POSITION_LEFT[CsNormalLevelDesignOfStageSelect.Scale_Y];
                bean1.loadSceneActiveFlag = CsNormalLevelDesignOfCommon.FALSE;
                stageSelectBeanResult.stage01 = bean1;
                CsStageSelectBean bean2 = new CsStageSelectBean();
                bean2.posY = CsNormalLevelDesignOfStageSelect.THUMBNAIL_POSITION_CENTER[CsNormalLevelDesignOfStageSelect.PosY];
                bean2.loadSceneActiveFlag = CsNormalLevelDesignOfCommon.TRUE;
                stageSelectBeanResult.stage02 = bean2;
                CsStageSelectBean bean3 = new CsStageSelectBean();
                bean3.posX = CsNormalLevelDesignOfStageSelect.THUMBNAIL_POSITION_RIGHT[CsNormalLevelDesignOfStageSelect.PosX];
                bean3.posY = CsNormalLevelDesignOfStageSelect.THUMBNAIL_POSITION_RIGHT[CsNormalLevelDesignOfStageSelect.PosY];
                bean3.scale_X = CsNormalLevelDesignOfStageSelect.THUMBNAIL_POSITION_RIGHT[CsNormalLevelDesignOfStageSelect.Scale_X];
                bean3.scale_Y = CsNormalLevelDesignOfStageSelect.THUMBNAIL_POSITION_RIGHT[CsNormalLevelDesignOfStageSelect.Scale_Y];
                bean3.loadSceneActiveFlag = CsNormalLevelDesignOfCommon.FALSE;
                stageSelectBeanResult.stage03 = bean3;
            }
            // ステージ３を中央に表示（最後項目の表示の為、右側にサムネイルは表示しない）
            else if (CsNormalLevelDesignOfStageSelect.THUMBNAIL_SCENES_STAGE_03.Equals(stageSelectBean.stageName))
            {
                CsStageSelectBean bean1 = new CsStageSelectBean();
                bean1.loadSceneActiveFlag = CsNormalLevelDesignOfCommon.FALSE;
                bean1.setActive = CsNormalLevelDesignOfCommon.FALSE;
                stageSelectBeanResult.stage01 = bean1;
                CsStageSelectBean bean2 = new CsStageSelectBean();
                bean2.posX = CsNormalLevelDesignOfStageSelect.THUMBNAIL_POSITION_LEFT[CsNormalLevelDesignOfStageSelect.PosX];
                bean2.posY = CsNormalLevelDesignOfStageSelect.THUMBNAIL_POSITION_LEFT[CsNormalLevelDesignOfStageSelect.PosY];
                bean2.scale_X = CsNormalLevelDesignOfStageSelect.THUMBNAIL_POSITION_LEFT[CsNormalLevelDesignOfStageSelect.Scale_X];
                bean2.scale_Y = CsNormalLevelDesignOfStageSelect.THUMBNAIL_POSITION_LEFT[CsNormalLevelDesignOfStageSelect.Scale_Y];
                bean2.loadSceneActiveFlag = CsNormalLevelDesignOfCommon.FALSE;
                stageSelectBeanResult.stage02 = bean2;
                CsStageSelectBean bean3 = new CsStageSelectBean();
                bean3.posY = CsNormalLevelDesignOfStageSelect.THUMBNAIL_POSITION_CENTER[CsNormalLevelDesignOfStageSelect.PosY];
                bean3.loadSceneActiveFlag = CsNormalLevelDesignOfCommon.TRUE;
                stageSelectBeanResult.stage03 = bean3;
            }
        }
        return stageSelectBeanResult;
    }
}
