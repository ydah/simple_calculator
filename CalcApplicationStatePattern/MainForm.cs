using System;
using System.Windows.Forms;
using CalcState;

namespace CalcApplication
{
    #region メイン画面クラス
    /// <summary>
    /// メイン画面クラス
    /// </summary>
    internal partial class MainForm : Form
    {
        #region コンストラクタ
        /// <summary>
        /// <see cref="MainForm"/>クラスの新しいインスタンスを初期化する。
        /// </summary>
        internal MainForm()
        {
            InitializeComponent();
        }
        #endregion  // コンストラクタ

        #region フィールド
        /// <summary>
        /// 計算結果
        /// </summary>
        private static double calcResult = 0;
        /// <summary>
        /// 符号種別
        /// </summary>
        private static Defines.ConstDefines.CalcType calcOperationType = Defines.ConstDefines.CalcType.Undefined;
        /// <summary>
        /// 状態管理クラス
        /// </summary>
        private static CalcStateManage context = null;
        #endregion  // フィールド

        #region 公開メソッド
        /// <summary>
        /// 計算結果エリアに数字を格納する。
        /// </summary>
        /// <param name="text">格納する数字</param>
        internal void UpdateResultArea(string text)
        {
            resultDispArea.Text = text;
        }

        /// <summary>
        /// 計算結果エリアに数字もしくは符号を追加する。
        /// </summary>
        /// <param name="text">追加する数字もしくは符号</param>
        internal void AppendResultArea(string text)
        {
            resultDispArea.AppendText(text);
        }

        /// <summary>
        /// 計算結果エリアをクリアする。
        /// </summary>
        internal void ClearResultArea()
        {
            resultDispArea.Text = Defines.ConstDefines.InitCalcResultDisp;
        }

        /// <summary>
        /// 計算結果エリアの文字数を取得する。
        /// </summary>
        /// <returns>計算結果エリアの文字数</returns>
        internal int getLengthResultArea()
        {
            return resultDispArea.Text.Length;
        }

        /// <summary>
        /// 計算結果エリアが初期状態か？
        /// </summary>
        /// <returns>初期状態か否か。true:初期状態 false:初期状態でない</returns>
        internal bool IsInitialValueResultArea()
        {
            return ((resultDispArea.Text.Length == 1) && (resultDispArea.Text == Defines.ConstDefines.InitCalcResultDisp));
        }

        /// <summary>
        /// 計算式表示エリアに数式を追加する。
        /// </summary>
        /// <param name="text">追加する数式</param>
        internal void AppendFormulaDisplayArea(string text)
        {
            formulaDispArea.AppendText(text);
        }

        /// <summary>
        /// 計算式表示エリアに計算結果エリアに表示している文字を追加する。
        /// </summary>
        internal void AppendFormulaDisplayAreaFromResultArea()
        {
            if (resultDispArea.Text.EndsWith("."))
            {
                DeleteLastChar();
            }

            formulaDispArea.AppendText(resultDispArea.Text);
        }

        /// <summary>
        /// 計算式表示エリアをクリアする。
        /// </summary>
        internal void ClearFormulaArea()
        {
            formulaDispArea.ResetText();
        }

        /// <summary>
        /// 計算結果を計算結果表示エリアに表示している値で更新する。
        /// </summary>
        internal void UpdateCalcResult()
        {
            calcResult = Convert.ToDouble(resultDispArea.Text);
        }

        /// <summary>
        /// 全ての表示エリアと計算結果をリセットする。
        /// </summary>
        internal void ResetAll()
        {
            ClearResultArea();
            ClearFormulaArea();
            calcResult = 0;
        }

        /// <summary>
        /// 計算を実施する
        /// </summary>
        internal void Calculate()
        {
            // 符号種別に応じた演算を行う
            switch (calcOperationType)
            {
                // 足し算の場合
                case Defines.ConstDefines.CalcType.Sum:
                    calcResult += Convert.ToDouble(resultDispArea.Text);
                    break;
                // 引き算の場合
                case Defines.ConstDefines.CalcType.Minus:
                    calcResult -= Convert.ToDouble(resultDispArea.Text);
                    break;
                // 掛け算の場合
                case Defines.ConstDefines.CalcType.Multiple:
                    calcResult *= Convert.ToDouble(resultDispArea.Text);
                    break;
                // 割り算の場合
                case Defines.ConstDefines.CalcType.Divide:
                    calcResult /= Convert.ToDouble(resultDispArea.Text);
                    break;
                // ここに来るのはあり得ない
                default:
                    break;
            }
            // 計算結果を計算結果表示エリアに表示する
            resultDispArea.Text = calcResult.ToString();
            calcOperationType = Defines.ConstDefines.CalcType.Undefined;
        }

        /// <summary>
        /// 符号を変更する
        /// </summary>
        /// <param name="operation">変更後の符号</param>
        internal void ChangeOperation(string operation)
        {
            if (calcOperationType != Defines.ConstDefines.CalcType.Undefined)
            {
                formulaDispArea.Text = formulaDispArea.Text.Remove(formulaDispArea.Text.Length - 1);
            }

            AppendFormulaDisplayArea(operation);
            SetCalcOperationFromText(operation);
        }

        /// <summary>
        /// 押されたボタンに対応する符号種別を取得する
        /// </summary>
        /// <param name="operation">変更後の符号</param>
        internal void SetCalcOperationFromText(string operation)
        {
            calcOperationType = Defines.ConstDefines.OperationTypeTable[operation];
        }

        /// <summary>
        /// 計算結果画面に表示している数字の正負を切り替える
        /// </summary>
        internal void TogglePositiveAndNegative()
        {
            // 計算結果エリアで表示している数字を取得し、数値に変換する
            double tmpValue = Convert.ToDouble(resultDispArea.Text);
            // 数値の正負を切り替えて計算結果エリアに戻す
            tmpValue *= -1;
            resultDispArea.Text = tmpValue.ToString();
        }

        /// <summary>
        /// 計算結果表示画面の一番後ろの文字を削除する
        /// </summary>
        internal void DeleteLastChar()
        {
            resultDispArea.Text = resultDispArea.Text.Remove(resultDispArea.Text.Length - 1);
        }

        /// <summary>
        /// 計算結果表示エリアに小数点が含まれているか？
        /// </summary>
        /// <returns>小数点が含まれているか否か？ true:含まれている false:含まれていない</returns>
        internal bool IsContainDecimalPoint()
        {
            return resultDispArea.Text.Contains(".");
        }
        #endregion  // 公開メソッド

        #region プライベートメソッド（イベントハンドラ）
        /// <summary>
        /// フォームを読み込む
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            context = new CalcStateManage(this);
        }

        /// <summary>
        /// 数字ボタンがクリックされた
        /// </summary>
        /// <param name="sender">イベントのソース</param>
        /// <param name="e">イベントデータ</param>
        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button clickedBtn = (Button)sender;
            context.InputNumber(clickedBtn.Text);
        }

        /// <summary>
        /// 計算符号ボタンがクリックされた
        /// </summary>
        /// <param name="sender">イベントのソース</param>
        /// <param name="e">イベントデータ</param>
        private void CalcTypeSign_Click(object sender, EventArgs e)
        {
            Button clickedBtn = (Button)sender;
            context.InputCalcOperation(clickedBtn.Text);
        }

        /// <summary>
        /// ＝ボタンがクリックされた
        /// </summary>
        /// <param name="sender">イベントのソース</param>
        /// <param name="e">イベントデータ</param>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            context.InputCalculate();
        }

        /// <summary>
        /// Cボタンがクリックされた
        /// </summary>
        /// <param name="sender">イベントのソース</param>
        /// <param name="e">イベントデータ</param>
        private void CButton_Click(object sender, EventArgs e)
        {
            context.InputCButton();
        }

        /// <summary>
        /// CEボタンがクリックされた
        /// </summary>
        /// <param name="sender">イベントのソース</param>
        /// <param name="e">イベントデータ</param>
        private void CEButton_Click(object sender, EventArgs e)
        {
            context.InputCEButton();
        }

        /// <summary>
        /// ←ボタンがクリックされた
        /// </summary>
        /// <param name="sender">イベントのソース</param>
        /// <param name="e">イベントデータ</param>
        private void BackSpaceButton_Click(object sender, EventArgs e)
        {
            context.InputBackSpace();
        }

        /// <summary>
        /// 正負切り替えボタンがクリックされた
        /// </summary>
        /// <param name="sender">イベントのソース</param>
        /// <param name="e">イベントデータ</param>
        private void SignToggleButton_Click(object sender, EventArgs e)
        {
            context.InputSignToggle();
        }

        /// <summary>
        /// 小数点"."ボタンがクリックされた
        /// </summary>
        /// <param name="sender">イベントのソース</param>
        /// <param name="e">イベントデータ</param>
        private void DecimalPointButton_Click(object sender, EventArgs e)
        {
            context.InputDecimalPoint();
        }
        #endregion  // プライベートメソッド（イベントハンドラ）
    }
    #endregion  // メイン画面クラス
}
