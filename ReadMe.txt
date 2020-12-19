コミット: f2abf943a3f6c4d93430fb019ac6659b3f1c592a [f2abf94]
日時: 2020年12月19日 17:15:27
・対象オブジェクトの子要素としてエフェクトを作成
Assets\Scenes\ScStage.unity
・UIエフェクト設定とエフェクト発生処理の追加
Assets\Scripts\ScMixer.cs
・エフェクト演出制御処理を作成
Assets\Scripts\Commons\CsNormalLogicDesignOfHitObject.cs

コミット: 337c706d6e17b935ced9c09c442d834a62a19d4e [337c706]
日時: 2020年12月18日 22:39:40
・カメラのGameObjectへスクリプト追加とシーン内のポジション調整
Assets\Scenes\ScStage.unity
・カメラにプレイヤーを追従させる処理を追加
Assets\Scripts\ScCameraMove.cs

コミット: 4cfa6a49756981bcddb88489e713e6e3a998d83a [4cfa6a4]
日時: 2020年12月13日 16:12:58
・ステージ床のサイズ調整、衝突確認用オブジェクト配置
Assets\Scenes\ScStage.unity
・オブジェクト衝突時にプレイヤーオブジェクトとの接着する処理（被オブジェクト側）
Assets\Scripts\ScMixer.cs
・オブジェクト衝突時にプレイヤーオブジェクトとの接着する処理（プレイヤー側）
Assets\Scripts\ScOperationPlayer.cs

コミット: edb9b0b38485204f9fd91297ea69ec1210acf4bf [edb9b0b]
日時: 2020年12月5日 22:54:50
・ゲームオブジェクトのインスタンス管理をシングルトン制御　及び　フェードの黒い部分のずれを修正
Assets\Scripts\ScWarpScences.cs

コミット: 9f5c464ae1e59e739bc84c8973660eee43569930 [9f5c464]
日時: 2020年12月5日 20:48:48
・ファイル名変更_A
（削除-）Assets\Scripts\ScAbstractPlayerRoll.cs
（作成+）Assets\Scripts\Commons\CsAbstractLogicDesignOfPlayerRoll.cs
・ファイル名変更_B
（削除-）Assets\Scripts\ScBallPlayer.cs
（作成+）Assets\Scripts\Commons\CsNormalLogicDesignOfBallPlayer.cs
・ファイル名変更_C
（削除-）Assets\Scripts\ScInterfacePlayerRollBySystem.cs
（作成+）Assets\Scripts\Commons\CsInterfacePlayerRollBySystem.cs
・ファイル名変更_D
（削除-）Assets\Scripts\ScLevelDesignCommon.cs
（作成+）Assets\Scripts\Commons\CsNormalLevelDesignOfCommon.cs
・ファイル名変更_E
（削除-）Assets\Scripts\ScLevelDesignOfBall.cs
（作成+）Assets\Scripts\Commons\CsNormalLevelDesignOfBall.cs
・ファイル名変更_F
（削除-）Assets\Scripts\ScLogicDesignCommon.cs
（作成+）Assets\Scripts\Commons\CsNormalLogicDesignOfCommon.cs
・ファイル名変更_G
（削除-）Assets\Scripts\ScLogicDesignOfSceneStaging.cs
（作成+）Assets\Scripts\Commons\CsNormalLogicDesignOfSceneStaging.cs
・ファイル名変更_H
（削除-）Assets\Scripts\ScOprationPlayer.cs
（作成+）Assets\Scripts\ScOperationPlayer.cs
・クラス名変更の影響でそれぞれのスクリプトで呼び出し処理を変更
Assets\Scripts\ScRetry.cs
Assets\Scripts\ScWarpGoal.cs
Assets\Scripts\ScWarpScences.cs

コミット: 723094ebe3ffd461e9c7adca0de23b3664e23d19 [723094e]
日時: 2020年12月5日 15:45:29
コミット「d88fc11447b8307d15583581df04fbc8294152a7」の反映漏れ
※バッファファイルの為、確認不要です。

コミット: d88fc11447b8307d15583581df04fbc8294152a7
日時: 2020年12月5日 15:43:04
・カラーレベルと不透明度の最小値、最大値の定数を追加
Assets\Scripts\ScLevelDesignCommon.cs
・ゲームオブジェクト内のスクリプトコンポーネント呼び出しロジックの作成
Assets\Scripts\ScLogicDesignCommon.cs
・カラー不透明度をコントロールするロジックの作成
Assets\Scripts\ScLogicDesignOfSceneStaging.cs
・上記、「ゲームオブジェクト内のスクリプトコンポーネント呼び出しロジックの作成」の影響による変更
Assets\Scripts\ScRetry.cs
・上記、「ゲームオブジェクト内のスクリプトコンポーネント呼び出しロジックの作成」及び「カラー不透明度をコントロールするロジックの作成」の影響による変更
Assets\Scripts\ScWarpGoal.cs
Assets\Scripts\ScWarpScences.cs
・プレイヤー操作フラグの切り替えメソッド名の変更
（※原則、True or Falseの切り替えにはChangeではなくSwitchを使用する）
Assets\Scripts\ScOprationPlayer.cs

コミット: 5deba8404cd8a3c471f931b16a6e86ab3f0b8e8d
日時: 2020年11月26日 22:59:54
・ゴール処理にタイマー情報を追加
Assets\Scripts\ScWarpGoal.cs
・ゴール処理にタイマー情報を追加（ゲームオブジェクトからコンポーネント内にあるスクリプトを取り出すメソッドを追加）
Assets\Scripts\ScWarpScences.cs
・タイマーの計測時間を取得して、タイマー表示用ゲームオブジェクトへセットする処理を追加
Assets\Scripts\ScResultSet.cs
・タイマー計測用スクリプト
Assets\Scripts\ScTimer.cs


コミット: 32be9a9d6a0b5bb420b2f48ab91f0c10ff9f906f
日時: 2020年11月24日 22:11:59
・フェード処理のゲームオブジェクト名を定数に追加
Assets\Scripts\ScLevelDesignCommon.cs
・ボールのオブジェクト名を定数に追加
Assets\Scripts\ScLevelDesignOfBall.cs
・定数と変数の呼び出し方法を変更し、コメントも追加修正
Assets\Scripts\ScOprationPlayer.cs
Assets\Scripts\ScRetry.cs
Assets\Scripts\ScWarpGoal.cs
Assets\Scripts\ScWarpScences.cs


コミット: 43ad27e94a570c04dceda51b6b68fe2b9ddc5de1
日時: 2020年11月24日 21:13:45
・プレイヤー操作の有効無効を管理する
Assets\Scripts\ScOprationPlayer.cs
・ゴールのシーン移動演出している間は操作を無効にする
Assets\Scripts\ScOprationPlayer.cs
・スタートの際の演出している間は操作を無効にする
Assets\Scripts\ScWarpScences.cs


コミット: b89158de53bc29c1f62fd590533bd2da9680dc15
日時: 2020年11月23日 20:25:08
・リトライ画面からのフェード処理が複数回実行される不具合を修正
Assets\Scripts\ScRetry.cs
・コルーチン化
Assets\Scripts\ScWarpScences.cs


コミット: db5536b2e707c483218aa3537e1def388084ddfb
日時: 2020年11月23日 13:59:50
・ゲーム画面からリザルト画面へシーン遷移する際にフェードする処理を追加
Assets\Scenes\ScStage.unity
Assets\Scripts\ScWarpGoal.cs
・リザルト画面からゲーム画面へシーン遷移する際にフェードする処理を追加
Assets\Scripts\ScRetry.cs
・シーン遷移する際にフェードする処理を追加
Assets\Scripts\ScWarpScences.cs


コミット: 7969bc967d95e013b40eae3a9796fb6c328e4922
日時: 2020年11月21日 17:53:45
・シーン名を定数で管理
Assets\Scripts\ScLevelDesignCommon.cs
・ゴールによる画面遷移の制御の修正
Assets\Scripts\ScRetry.cs
Assets\Scripts\ScWarpGoal.cs
・シーン移動を管理するメソッド用ファイルを作成
Assets\Scripts\ScWarpScences.cs


■記載ルール
①リビジョン番号ごとに対応内容を記載する
②リビジョン番号、対応日付、修正内容と該当するファイル等があればパスを記載する
