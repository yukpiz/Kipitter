using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KipitterCore.Constant
{
    public class WeekEffect
    {
        private static string[] _IMBOLIC_EFFECTS = { "", "" };
        public static KipitterCore.WeekEffect IMBOLIC = 
            new KipitterCore.WeekEffect(
                "日曜日",
                "インボリック", 
                "Imbolic",
                new string[] {
                    "クリティカルヒットの発生率が高くなります。",
                    "ラッキーフィニッシュの発生率が高くなります。",
                    "演奏成功率が増加します。",
                    "魔法音楽の成功率が増加します。",
                    "魔法音楽の発生率が増加します。",
                },
                new string[] {
                    "染色アンプル",
                    "金属染色アンプル",
                });

        public static KipitterCore.WeekEffect ALBAN_EILER = 
            new KipitterCore.WeekEffect(
                "月曜日",
                "アルバンエイレル", 
                "Alban Eiler",
                new string[] {
                    "生産スキルの成功率が高くなります。",
                    "生活スキルのランクアップボーナスが増加します。",
                    "生産品の品質が向上します。",
                },
                new string[] {
                    "完全回復ポーション",
                    "生命力のエリクサー",
                    "魔法攻撃力増加ポーション",
                    "スタミナのエリクサー",
                });

        public static KipitterCore.WeekEffect BELTANE = 
            new KipitterCore.WeekEffect(
                "火曜日",
                "ベルテン", 
                "Beltane",
                new string[] {
                    "同じアイテムを落とした場合でもダンジョンの形が変わるようになります。",
                    "ダンジョンでアイテムが出る確率が高くなります。",
                    "戦闘スキルのランクアップボーナスが増加します。",
                },
                new string[] {
                    "遠隔用フェニックスの羽根 2個",
                    "遠隔武器屋利用チケット 2個",
                    "遠隔衣類修理チケット 2個",
                });

        public static KipitterCore.WeekEffect ALBAN_HERUIN = 
            new KipitterCore.WeekEffect(
                "水曜日",
                "アルバンヘルイン", 
                "Alban Heruin",
                new string[] {
                    "自然や動物からアイテムを入手できる確率が高くなります。",
                    "店から物を安く買うことができます。",
                    "銀行の手数料が安くなります。",
                    "スキルのパーフェクト・トレーニングボーナスが増加します。",
                    "黄金キノコが採取できます。",
                },
                new string[] {
                    "採集速度増加ポーション",
                    "生産失敗ポーション",
                    "遠隔鍛冶屋修理チケット 2個",
                    "遠隔錬金術師の家チケット 2個",
                });

        public static KipitterCore.WeekEffect LUGHNASADH = 
            new KipitterCore.WeekEffect(
                "木曜日",
                "ルーナサ", 
                "Lughnasadh",
                new string[] {
                    "エンチャントの成功率が高くなります。",
                    "魔法スキルのランクアップボーナスが増加します。",
                    "装備を使用したときに得る熟練度が増加します。",
                },
                new string[] {
                    "キャンプファイアキット 2個",
                    "遠隔官庁利用チケット 2個",
                    "銀行チケット 2個",
                    "キャンプキット",
                });

        public static KipitterCore.WeekEffect ALBAN_ELVED = 
            new KipitterCore.WeekEffect(
                "金曜日",
                "アルバンエルベド", 
                "Alban Elved",
                new string[] {
                    "行動不能時の経験値ペナルティーが減ります。",
                    "ポーションの効果が高くなります。",
                    "アルバイトの報酬が高くなります。",
                },
                new string[] {
                    "パーティー用フェニックスの羽根 2個",
                    "無制限影ミッション通行証",
                    "友達召喚カプセル 2個",
                });

        public static KipitterCore.WeekEffect SAMHAIN = 
            new KipitterCore.WeekEffect(
                "土曜日",
                "サーオィン", 
                "Samhain",
                new string[] {
                    "歳を取ることでAPを獲得します。",
                    "食べ物の効果が高くなります。",
                    "Lロッドの効果が増加します。",
                    "少し動いてしまった動物もスケッチできます。",
                    "錬金術スキルの成功率が高くなります。",
                },
                new string[] {
                    "スキルアントレインカプセル",
                    "ヒーラーチケット 2個",
                    "遠隔魔法武器修理チケット 2個",
                    "有効期限7日延長の鍵",
                });
    }

    public static class Http
    {
        //Trade board URL.
        public const string TRADEBOARD_URL = 
            "http://mabinogi.nexon.co.jp/community/tradeBoardList.asp";

        //Server parameters.
        public const string PARAM_KEY_SV = "sv";
        public const string PARAM_VAL_MA = "ma";
        public const string PARAM_VAL_RU = "ru";
        public const string PARAM_VAL_TA = "ta";

        //Page parameters.
        public const string PARAM_KEY_P = "p";

        //What's parameters?
        public const string PARAM_KEY_ST = "st";
        public const string PARAM_VAL_T = "t";

        //Search parameters.
        public const string PARAM_KEY_SE = "se";
    }
}
