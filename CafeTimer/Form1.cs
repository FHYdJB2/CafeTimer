using System;
using System.Drawing;
using System.Windows.Forms;

namespace CafeTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            AddDrink();
            Add();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "CafeTimer";
        }

        //最初のドリンクを追加するメソッド
        private void AddDrink()
        {
            //最初のドリンクをリストに追加
            firstDrinkComboBox.Items.Add("山崎");
            firstDrinkComboBox.Items.Add("ウーロンハイ");
            firstDrinkComboBox.Items.Add("カルピス");

            //アイテムの最大値をリストで作成
            for (int i = 0; i < 21; i++)
            {
                drink200ComboBox.Items.Add(i);
                drink300ComboBox.Items.Add(i);
                drink400ComboBox.Items.Add(i);
                drink600ComboBox.Items.Add(i);
                dropComboBox.Items.Add(i);
            }
        }
        //初期設定
        private void Add()
        {
            //テキストチェンジドイベントを削除
            firstDrinkText.TextChanged -= FirstDrinkChanged;
            drink200ComboBox.TextChanged -= SecondDrinkChanged;
            drink300ComboBox.TextChanged -= SecondDrinkChanged;
            drink400ComboBox.TextChanged -= SecondDrinkChanged;
            drink600ComboBox.TextChanged -= SecondDrinkChanged;

            //初期値
            chargeText.Text = "0";
            drinkTextBox.Text = "0";
            firstDrinkText.Text = "0";


            //200～600のドリンク
            drink200ComboBox.Text = "0";
            drink300ComboBox.Text = "0";
            drink400ComboBox.Text = "0";
            drink600ComboBox.Text = "0";
            dropComboBox.Text = "0";
            //テキストチェンジドイベントを追加
            drink200ComboBox.TextChanged += SecondDrinkChanged;
            drink300ComboBox.TextChanged += SecondDrinkChanged;
            drink400ComboBox.TextChanged += SecondDrinkChanged;
            drink600ComboBox.TextChanged += SecondDrinkChanged;

            //テキスト表示位置を右詰めに変更
            stayTime.TextAlign = HorizontalAlignment.Right;
            chargeText.TextAlign = HorizontalAlignment.Right;
            drinkTextBox.TextAlign = HorizontalAlignment.Right;
            firstDrinkText.TextAlign = HorizontalAlignment.Right;
            othersTextBox.TextAlign = HorizontalAlignment.Right;
            totalText.TextAlign = HorizontalAlignment.Right;
            taxText.TextAlign = HorizontalAlignment.Right;

            //ボタンのテキスト表示位置を真ん中に変更
            TimeCalcBtn.TextAlign = ContentAlignment.MiddleCenter;
            DisplayMoneyBtn.TextAlign = ContentAlignment.MiddleCenter;
        }
        //滞在時間を表示するメソッド
        private void TimeCalc()
        {
            DateTime inTime = inTimePicker.Value; //in時間
            DateTime outTime = outTimePicker.Value; //out時間
            TimeSpan diff = outTime - inTime; //滞在時間
            stayTime.Text = diff.ToString().Remove(5, 3);

            //滞在時間からチャージ料金を計算するメソッド
            double charge = diff.TotalMinutes; //チャージ時間
            double chargeMoney = (charge / 10) * 100; //チャージ料金
            chargeText.Text = chargeMoney.ToString();
        }
        //ドリンクを変更した際に値段を表示させるメソッド
        private void FirstDrinkChanged(object sender, EventArgs e)
        {
            if (firstDrinkComboBox.Text == "山崎")
            {
                firstDrinkText.Text = "1000";
            }
            else if (firstDrinkComboBox.Text == "ウーロンハイ")
            {
                firstDrinkText.Text = "800";
            }
            else
            {
                firstDrinkText.Text = "600";
            }
            /*
            if (firstDrinkComboBox.Text == "0")
            {
                double aaa = double.Parse(drinkTextBox.Text);
                double bbb = double.Parse(firstDrinkText.Text);
                double ccc = aaa + bbb;
                drinkTextBox.Text = ccc.ToString();
            }
            else if (firstDrinkComboBox.Text!="0")
            {
                double ccc = 0;
                ccc-=double.Parse(firstDrinkText.Text);
                double aaa = double.Parse(drinkTextBox.Text);
                double bbb = double.Parse(firstDrinkText.Text);
                 ccc += aaa + bbb;
                drinkTextBox.Text = ccc.ToString();
            }
            */
            
        }


        //しずくを変更した際に値段を表示させるメソッド
        private void OthersChanged(object sender, EventArgs e)
        {
            double aaa = double.Parse(dropComboBox.Text) * 1000;
            othersTextBox.Text = aaa.ToString();
        }

        //ドリンクを変更した際に値段を表示させるメソッド
        private void DrinkChanged(object sender, EventArgs e)
        {

        }
        //ドリンクの計算メソッド
        private void DrinkCalc()
        {
            double dr200 = double.Parse(drink200ComboBox.Text) * 200;
            double dr300 = double.Parse(drink300ComboBox.Text) * 300;
            double dr400 = double.Parse(drink400ComboBox.Text) * 400;
            double dr600 = double.Parse(drink600ComboBox.Text) * 600;
            //合計金額を表示するメソッド
            double drink = int.Parse(firstDrinkText.Text);
            double totalDrink = drink + dr200 + dr300 + dr400 + dr600;
            //ドリンクの値段を表示
            drinkTextBox.Text = totalDrink.ToString();
        }

        //消費税の計算メソッド
        private void Calc()
        {
            double chargeMoney = double.Parse(chargeText.Text);
            double totalDrink = double.Parse(drinkTextBox.Text);
            double drop = double.Parse(othersTextBox.Text);

            double totalMoney = (chargeMoney + totalDrink + drop); //合計金額の計算
            double taxMoney = totalMoney * 1.10; //消費税の計算
            totalText.Text = totalMoney.ToString();
            taxText.Text = taxMoney.ToString();
        }

        //滞在時間を計算するメソッド
        private void TimeCalcClicked(object sender, EventArgs e)
        {
            DateTime inTime = inTimePicker.Value; //in時間
            DateTime outTime = outTimePicker.Value; //out時間
            TimeSpan diff = outTime - inTime; //滞在時間
            stayTime.Text = diff.ToString().Remove(5, 3);

            //滞在時間からチャージ料金を計算するメソッド
            double charge = diff.TotalMinutes; //チャージ時間
            double chargeMoney = (charge / 10) * 100; //チャージ料金
            chargeText.Text = chargeMoney.ToString();
        }

        //ボタンクリック時の金額を表示
        private void DisplayMoneyClicked(object sender, EventArgs e)
        {
            if (firstDrinkComboBox.SelectedItem == null)
            {
                MessageBox.Show("一杯目を選択してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DrinkCalc();
                TimeCalc();
                Calc();
            }
        }

        private void SecondDrinkChanged(object sender, EventArgs e)
        {

            double dr200 = double.Parse(drink200ComboBox.Text) * 200;
            double dr300 = double.Parse(drink300ComboBox.Text) * 300;
            double dr400 = double.Parse(drink400ComboBox.Text) * 400;
            double dr600 = double.Parse(drink600ComboBox.Text) * 600;

            double totalDrink = double.Parse(firstDrinkText.Text)+ dr200+dr300+dr400+dr600;
            drinkTextBox.Text = totalDrink.ToString();
        }
    }
}
