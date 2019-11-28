using System.Collections.Generic;

namespace Defines
{
    #region 定数定義クラス

    internal static class ConstDefines
    {
        #region フィールド（読み取り専用）

        /// <summary>
        /// 計算種別。
        /// </summary>
        internal enum CalcType
        {
            Undefined = -1,
            Sum = 0,
            Minus,
            Multiple,
            Divide
        };

        /// <summary>
        /// 計算機状態
        /// </summary>
        internal enum CalcState
        {
            Initaial = 0,
            WaitOperation,
            WaitNumInputAfterOperation,
            Calulable,

        };

        /// <summary>
        /// 符号文字から計算種別を取得する変換テーブル。
        /// </summary>
        /// <value></value>
        internal static readonly Dictionary<string, CalcType> OperationTypeTable = new Dictionary<string, CalcType>
        {
            { ConstDefines.Plus, ConstDefines.CalcType.Sum },
            { ConstDefines.Minus, ConstDefines.CalcType.Minus },
            { ConstDefines.Multipul, ConstDefines.CalcType.Multiple },
            { ConstDefines.Divide, ConstDefines.CalcType.Divide },
        };

        /// <summary>
        /// 計算結果表示エリアの初期値
        /// </summary>
        public const string InitCalcResultDisp = "0";

        /// <summary>
        /// 符号文字：足し算
        /// </summary>
        public const string Plus = "＋";

        /// <summary>
        /// 符号文字：引き算
        /// </summary>
        public const string Minus = "－";

        /// <summary>
        /// 符号文字：掛け算
        /// </summary>
        public const string Multipul = "×";

        /// <summary>
        /// 符号文字：割り算
        /// </summary>
        public const string Divide = "÷";

        /// <summary>
        /// 小数点
        /// </summary>
        public const string DecimalPoint = ".";

        #endregion フィールド（読み取り専用）
    }

    #endregion 定数定義クラス
}