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
