コミット: 8c91fcefa601d9c3f2a9d06dd17fcfc419c0ccc0 [8c91fce]
日時: 2020年12月30日 15:36:09
・ゲームオーバー画面にて、リトライ、ステージセレクト画面へ遷移、タイトル画面へ遷移するボタンを配置
Assets\Scenes\ScGameOver.unity
・リザルト画面にて、ステージセレクト画面へ遷移、リトライ、タイトル画面へ遷移するボタンを配置
Assets\Scenes\ScResult.unity
・ボタンが押された際に指定されたシーンへ遷移する制御スクリプトを作成
Assets\Scripts\ScSceneMove.cs

コミット: 9ae61b7290b74db8550ab2a5a4326867e606eb06 [9ae61b7]
日時: 2020年12月30日 15:05:06
・タイトルシーンにて、スタートボタンの文言修正
Assets\Scenes\ScTitle.unity

コミット: 99335a8099794e4928557e0308f3188b6537fcbc [99335a8]
日時: 2020年12月30日 15:00:57
・タイトルボタンの遷移先をゲーム画面からステージセレクト画面へ変更
Assets\Scripts\ScStartButton.cs
・ステージセレクト画面のシーンを作成
Assets\Scenes\ScStageSelect.unity
・ビルド情報へステージセレクト画面を追加
ProjectSettings\EditorBuildSettings.asset
・ステージセレクト画面にて、ステージサムネイルを前へ次へ移動するかつ、シーン遷移有効フラグ切り替えボタン制御スクリプト作成
Assets\Scripts\ScScroll.cs
Assets\Scripts\ScStageSelectMotion.cs
・ステージセレクト画面にて、選択されたステージへ遷移する制御スクリプト作成
Assets\Scripts\ScStageSelect.cs
・サムネイル表示制御するクラスを作成
Assets\Scripts\Commons\CsNormalLogicDesignOfStageSelect.cs
・オブジェクト自身の有効フラグを管理するBeanクラスを作成
Assets\Scripts\Beans\CsInspectorBean.cs
・シーンとサムネイル情報を管理するBeanクラスを作成
Assets\Scripts\Beans\CsStageSelectBean.cs
・サムネイル表示数等を管理するBeanクラスを作成
Assets\Scripts\Beans\CsStageSelectMotionBean.cs
・サムネイル情報を管理する定数クラスを作成
Assets\Scripts\Commons\CsNormalLevelDesignOfStageSelect.cs
・ステージ１のサムネイル画像を作成
Assets\Images\StageSelect_ScStage.jpg
・定数管理クラスへステージセレクト画面の名前を追加、他、初期値やTRUE、FALSE等の値の定義も追加
Assets\Scripts\Commons\CsNormalLevelDesignOfCommon.cs
・RectTransformのBeanへスケール情報を追加
Assets\Scripts\Beans\CsRectTransformBean.cs

コミット: 0ec6134fe8252de5f125a086a4bdb411ce542767 [0ec6134]
日時: 2020年12月29日 19:19:20
・タイトルシーンをビルド追加
ProjectSettings\EditorBuildSettings.asset
・タイトル用のフォント作成
Assets\Fonts\rounded-mplus-1c-heavy SDF.asset
Assets\Fonts\rounded-mplus-1c-heavy.ttf
・タイトルシーンを作成
Assets\Scenes\ScTitle.unity
・タイトルからステージシーンへ遷移するスクリプト
Assets\Scripts\ScStartButton.cs
・TextMesh ProをImport、ImportTMPExampies＆Extrasを実行
Assets\TextMesh Pro\

コミット: 794751004f712dec2fea9b6307ebd22ff3a012dd [7947510]
日時: 2020年12月29日 17:28:17
・ステージシーンに場外判定の床を設置
Assets\Scenes\ScStage.unity
・場外判定の床オブジェクトをPrefab化
Assets\Prefabs\PlGameOver.prefab
・ゲームオーバーシーン名を定数定義へ追加
Assets\Scripts\Commons\CsNormalLevelDesignOfCommon.cs
・ゲームオーバーシーンへ遷移するスクリプトを作成
Assets\Scripts\ScWarpGameOver.cs
・ゲームオーバーのシーンを作成してステージシーンへリトライするオブジェクトを配置
Assets\Scenes\ScGameOver.unity
・リザルトシーンのリトライ制御オブジェクトのPrefab化
Assets\Scenes\ScResult.unity
Assets\Prefabs\GameObject.prefab

コミット: b920157c25e915ca132f64e2728211d325212d4c [b920157]
日時: 2020年12月28日 18:06:03
・Timerオブジェクト内のサブオブジェクト（テキスト）を削除して、サブオブジェクト（Image）を追加
Assets\Scenes\ScStage.unity
・タイマー処理をテキストからImage表示へ変更
Assets\Scripts\ScTimer.cs
・タイマーテクスチャ用のImageファイル
Assets\Images\ImageUI_Number.jpg
・タイマーテクスチャ用のPrefabファイル
Assets\Prefabs\SmTimer.prefab
・定数クラスからタイマーオブジェクト名の定義を削除
Assets\Scripts\Commons\CsNormalLevelDesignOfCommon.cs
・タイマー用の定数クラス
Assets\Scripts\Commons\CsNormalLevelDesignOfTimer.cs
・タイマーオブジェクト名の定数クラス変更に伴い修正
Assets\Scripts\ScWarpGoal.cs
Assets\Scripts\ScWarpScences.cs
・RectMask2D制御用のBeanクラスを追加
Assets\Scripts\Beans\CsRectMask2DBean.cs
・RectTransform制御用のBeanクラスを追加
Assets\Scripts\Beans\CsRectTransformBean.cs
・Tagへタイマーテキスト識別用のタグを追加
ProjectSettings\TagManager.asset

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
