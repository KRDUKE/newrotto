using System;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        private readonly string MSG_1 = "텍스트창에 문자 또는 특수문자, 범위 이외의 숫자가 입력되었습니다. 1~45 이내의 숫자를 입력해 주십시오";

        private Dictionary<string, Item> _items = new Dictionary<string, Item>();

        private TextBox[] _number;
        private Button[] _btnhd;
        private TextBox[] _range;

        public Form1()
        {
            InitializeComponent();

            _items.Add(nameof(txtBox1), new Item(txtBox1, btnHold1));
            _items.Add(nameof(txtBox2), new Item(txtBox2, btnHold2));
            _items.Add(nameof(txtBox3), new Item(txtBox3, btnHold3));
            _items.Add(nameof(txtBox4), new Item(txtBox4, btnHold4));
            _items.Add(nameof(txtBox5), new Item(txtBox5, btnHold5));
            _items.Add(nameof(txtBox6), new Item(txtBox6, btnHold6));

            _number = new TextBox[] { txtBox1, txtBox2, txtBox3, txtBox4, txtBox5, txtBox6 };
            _btnhd = new Button[] { btnHold1, btnHold2, btnHold3, btnHold4, btnHold5, btnHold6 };
            _range = new TextBox[] { txtMin, txtMax };
            Load();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnLottery.Enabled = txtMin.Text == string.Empty ? false : true;

            //ClearTextBOx();
            List<int> LN = GetRandomLN();
            //LN.Sort();

            for (int i = 0; i < _number.Length; i++)
            {

                int d = LN[i];
                _number[i].Text = d.ToString();

            }
        }

        private void ClearTextBOx()
        {
            for (int i = 0; i < _number.Length; i++)
            {
                _number[i].Text = string.Empty;
            }
        }

        private List<int> GetRandomLN()
        {
            Random ab = new Random();
            List<int> LN = new List<int>();

            List<int> _temps = new List<int>();

            for (int i = 0; i < _number.Length; i++)
            {
                if (_number[i].ReadOnly)
                {
                    _temps.Add(int.Parse(_number[i].Text));
                }
            }

            for (int i = 0; i < _number.Length; i++)
            {
                int randomNumber;

                int test = 0;
                if (int.TryParse(txtExclude1.Text, out int value))
                {
                    test = value;
                }
                else
                {

                }



                if (_number[i].ReadOnly == false)
                {
                    do
                    {
                        randomNumber = ab.Next(Convert.ToInt32(_range[0].Text), Convert.ToInt32(_range[1].Text) + 1);
                    }
                    while (_temps.Contains(randomNumber) || test == randomNumber);

                    _temps.Add(randomNumber);
                    LN.Add(randomNumber);
                }
                else
                {
                    LN.Add(int.Parse(_number[i].Text));
                }

            }

            return LN;
        }

        private void btnHold1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < _btnhd.Length; i++)
            {
                if (sender == _btnhd[i])
                    _number[i].ReadOnly = !_number[i].ReadOnly;
            }
        }

        private void textBox1_TextChanged_1(object sender, System.EventArgs e)
        {
            var item = _items[(sender as TextBox).Name];

            item._btnhd.Enabled = item._number.Text == string.Empty ? false : true;

            if (int.TryParse(item._number.Text, out int value))
            {
                if (Convert.ToInt32(txtMin.Text) <= value && value <= Convert.ToInt32(txtMax.Text))
                {

                }
                else
                {
                    item._btnhd.Enabled = false;

                    this.toolTip1.ToolTipTitle = "경고";
                    this.toolTip1.IsBalloon = true;
                    var textbox = sender as TextBox;
                    toolTip1.Show(MSG_1, textbox, textbox.Size.Width, textbox.Size.Height, 1000);
                }
            }
            else
            {
                item._btnhd.Enabled = false;
                this.toolTip1.ToolTipTitle = "경고";
                this.toolTip1.IsBalloon = true;
                var textbox = sender as TextBox;
                toolTip1.Show("텍스트창에 문자 또는 특수문자, 범위 이외의 숫자가 입력 되었습니다. 1~45 이내의 숫자를 입력해 주십시오", textbox, textbox.Size.Width, textbox.Size.Height, 1000);

            }


            //for (int i = 0; i < _btnhd.Length; i++)
            //{
            //    if (sender as TextBox == _number[i])
            //    {
            //        _btnhd[i].Enabled = _number[i].Text == string.Empty ? false : true;

            //        if (int.TryParse(_number[i].Text, out int value))
            //        {
            //            if (1 <= value && value <= _max)
            //            {

            //            }
            //            else
            //            {
            //                _btnhd[i].Enabled = false;

            //                this.toolTip1.ToolTipTitle = "경고";
            //                this.toolTip1.IsBalloon = true;
            //                var textbox = sender as TextBox;
            //                toolTip1.Show(MSG_1, textbox, textbox.Size.Width, textbox.Size.Height, 1000);
            //            }
            //        }
            //        else
            //        {
            //            _btnhd[i].Enabled = false;

            //            this.toolTip1.ToolTipTitle = "경고";
            //            this.toolTip1.IsBalloon = true;
            //            var textbox = sender as TextBox;
            //            toolTip1.Show(MSG_1, textbox, textbox.Size.Width, textbox.Size.Height, 1000);

            //        }

            //        _btnhd[i].Enabled = _number[i].Text == string.Empty ? false : true;

            //        //    if (int.TryParse(_number[i].Text.Replace(",", ""), out int value))
            //        //    {
            //        //        if (1 <= value && value <=_max)
            //        //        {
            //        //            _number[i].Text = value.ToString();
            //        //        }
            //        //        else
            //        //        {
            //        //            _number[i].Text = "";
            //        //        }
            //        //    }
            //        //    else
            //        //    {
            //        //        _number[i].Text = "";
            //        //    }
            //        break;
            //    }
            //}
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // FileInfo file = new FileInfo("data001.txt");
            //FileStream fs = file.Create();
            //fs.Close();
            //textbox에서 경로를 받음 
            string filepath = txtPath.Text;
            //richtextbox에서 내용을 받음 
            string value = _range[0].Text + "\r\n" + _range[1].Text;
            //경로가 입력되어있으면 
            if (filepath.Length > 0)
            {
                //File에 내용을 입력
                System.IO.File.WriteAllText(filepath, value);

            }
        }

        private void btnPathSearch_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = false; // true : 폴더 선택 / false : 파일 선택

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txtPath.Text = dialog.FileName;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Load();
        }

        private void Load()
        {
            FileInfo File_Check = new FileInfo(txtPath.Text);

            string filepath = txtPath.Text;
            string filedir = txtPath.Text.Substring(0, 8);

            if (!File_Check.Exists)
            {
                if (!Directory.Exists(filedir))
                {
                    Directory.CreateDirectory(filedir);
                }
                string value = "1" + "\r\n" + "45";

                if (filepath.Length > 0)
                {
                    //File에 내용을 입력
                    System.IO.File.WriteAllText(filepath, value);
                }
            }


            string[] textValue = System.IO.File.ReadAllLines(txtPath.Text);

            txtMin.Text = textValue[0];
            txtMax.Text = textValue[1];
        }

        private void textMin_TextChanged(object sender, EventArgs e)
        {
            btnLottery.Enabled = txtMin.Text == string.Empty ? false : true;
            btnSave.Enabled = txtMin.Text == string.Empty ? false : true;


            if (int.TryParse(txtMin.Text, out int value))
            {
                if (txtMax.Text != string.Empty && Convert.ToInt32(_range[0].Text) <= Convert.ToInt32(_range[1].Text) - 8)
                {
                    if (Convert.ToInt32(_range[0].Text) > 0)
                    {

                    }
                    else
                    {
                        btnSave.Enabled = false;
                        btnLottery.Enabled = false;

                        this.toolTip1.ToolTipTitle = "경고";
                        this.toolTip1.IsBalloon = true;
                        var textbox = sender as TextBox;
                        toolTip1.Show("텍스트창 비었습니다. \r\n범위 이내의 숫자를 입력해 주십시오", textbox, textbox.Size.Width, textbox.Size.Height, 1000);
                    }
                }
                else
                {
                    btnSave.Enabled = false;
                    btnLottery.Enabled = false;

                    this.toolTip1.ToolTipTitle = "경고";
                    this.toolTip1.IsBalloon = true;
                    var textbox = sender as TextBox;
                    toolTip1.Show("텍스트창에  범위 이외의 숫자가 입력되었습니다. \r\n범위 이내의 숫자를 입력해 주십시오", textbox, textbox.Size.Width, textbox.Size.Height, 1000);
                }
            }
            else
            {
                btnSave.Enabled = false;
                btnLottery.Enabled = false;
                this.toolTip1.ToolTipTitle = "경고";
                this.toolTip1.IsBalloon = true;
                var textbox = sender as TextBox;
                toolTip1.Show("텍스트창에 문자 또는 특수문자가 입력되었습니다. \r\n숫자를 입력해 주십시오", textbox, textbox.Size.Width, textbox.Size.Height, 1000);
            }

        }

        private bool IsInRange(int value, int min, int max)
        {
            return (value >= min && value <= max);
        }

        private void textMax_TextChanged(object sender, EventArgs e)
        {
            btnLottery.Enabled = txtMax.Text == string.Empty ? false : true;
            btnSave.Enabled = txtMax.Text == string.Empty ? false : true;

            var rangeMin = Convert.ToInt32(txtMin.Text);
            var rangeMax = Convert.ToInt32(txtMax.Text);
           
            for (int i = 0; i < 6; i++)
            {
                if (_number[i].Text == string.Empty)
                {
                    // TODO: Show message
                }
                else
                {
                    try
                    {
                        int number = Convert.ToInt32(_number[i].Text);
                    }
                    catch (Exception exception)
                    {
                        //btnLottery.Enabled = false;
                        //this.toolTip1.ToolTipTitle = "경고";
                        //this.toolTip1.IsBalloon = true;
                        //var textbox = sender as TextBox;
                        //toolTip1.Show("텍스트창에 문자 또는 특수문자, 범위 이외의 숫자가 입력되었습니다. 1~45 이내의 숫자를 입력해 주십시오", textbox, textbox.Size.Width, textbox.Size.Height, 1000);

                        MessageBox.Show(exception.Message);
                    }
                }
            }

           

            if (int.TryParse(txtMax.Text, out int value))
            {
                //if (Convert.ToInt32(_range[1].Text) <= value && Convert.ToInt32(_range[1].Text) > 6)
                if (IsInRange(rangeMax, 7, value))
                {
                    if (rangeMax - rangeMin >= 6)
                    {
                        for (int i = 0; i < _number.Length; i++)
                        {
                            if (_number[i].Text != string.Empty && Convert.ToInt32(_number[i].Text) <= Convert.ToInt32(txtMax.Text))//빈칸이 아닐때 텍박이 맥스보다 작거나 같을때
                            {

                            }
                            else
                            {
                                if (_number[i].Text == string.Empty)//공백인지
                                {
                                }
                                else
                                {
                                    btnLottery.Enabled = false;
                                    this.toolTip1.ToolTipTitle = "경고";
                                    this.toolTip1.IsBalloon = true;
                                    var textbox = sender as TextBox;
                                    toolTip1.Show("텍스트창에 문자 또는 특수문자, 범위 이외의 숫자가 입력되었습니다. 1~45 이내의 숫자를 입력해 주십시오", textbox, textbox.Size.Width, textbox.Size.Height, 1000);

                                }
                            }
                        }
                    }
                    else
                    {
                        btnSave.Enabled = false;
                        btnLottery.Enabled = false;
                        this.toolTip1.ToolTipTitle = "경고";
                        this.toolTip1.IsBalloon = true;
                        var textbox = sender as TextBox;
                        toolTip1.Show("텍스트창에  범위 이외의 숫자가 입력되었습니다. \r\n범위 이내의 숫자를 입력해 주십시오", textbox, textbox.Size.Width, textbox.Size.Height, 1000);
                    }
                }
                else
                {
                    btnSave.Enabled = false;
                    btnLottery.Enabled = false;
                    this.toolTip1.ToolTipTitle = "경고";
                    this.toolTip1.IsBalloon = true;
                    var textbox = sender as TextBox;
                    toolTip1.Show("텍스트창에  범위 이외의 숫자가 입력되었습니다. \r\n범위 이내의 숫자를 입력해 주십시오", textbox, textbox.Size.Width, textbox.Size.Height, 1000);
                }
            }
            else
            {
                btnSave.Enabled = false;
                btnLottery.Enabled = false;
                this.toolTip1.ToolTipTitle = "경고";
                this.toolTip1.IsBalloon = true;
                var textbox = sender as TextBox;
                toolTip1.Show("텍스트창에  범위 이외의 숫자가 입력되었습니다. \r\n범위 이내의 숫자를 입력해 주십시오", textbox, textbox.Size.Width, textbox.Size.Height, 1000);
            }

        }



        private void textExclude1_TextChanged(object sender, EventArgs e)
        {
            btnLottery.Enabled = txtExclude1.Text == string.Empty ? false : true;
            btnSave.Enabled = txtExclude1.Text == string.Empty ? false : true;

            if (int.TryParse(txtExclude1.Text, out int value))
            {
                if (txtMax.Text != string.Empty || txtMin.Text != string.Empty)
                {
                    if (int.TryParse(txtMin.Text, out int value1) && int.TryParse(txtMax.Text, out int value2))
                    {
                        if (Convert.ToInt32(_range[1].Text) >= Convert.ToInt32(txtExclude1.Text) && Convert.ToInt32(_range[1].Text) > 6)
                        {

                        }
                        else
                        {
                            btnSave.Enabled = false;
                            btnLottery.Enabled = false;
                            this.toolTip1.ToolTipTitle = "경고";
                            this.toolTip1.IsBalloon = true;
                            var textbox = sender as TextBox;
                            toolTip1.Show("최대,최소, 제외 텍스트창에 범위 이외의 숫자가 입력되었습니다. \r\n범위 이내의 숫자를 입력해 주십시오", textbox, textbox.Size.Width, textbox.Size.Height, 1000);
                        }
                    }
                    else
                    {
                        btnSave.Enabled = false;
                        btnLottery.Enabled = false;
                        this.toolTip1.ToolTipTitle = "경고";
                        this.toolTip1.IsBalloon = true;
                        var textbox = sender as TextBox;
                        toolTip1.Show("최대, 최소 텍스트창에 문자 또는 특수문자가 입력되었습니다. \r\n 숫자를 입력해 주십시오", textbox, textbox.Size.Width, textbox.Size.Height, 1000);
                    }
                }
                else
                {
                    btnSave.Enabled = false;
                    btnLottery.Enabled = false;
                    this.toolTip1.ToolTipTitle = "경고";
                    this.toolTip1.IsBalloon = true;
                    var textbox = sender as TextBox;
                    toolTip1.Show("최대 최소 텍스트창이 비었습니다. \r\n범위 이내의 숫자를 입력해 주십시오", textbox, textbox.Size.Width, textbox.Size.Height, 1000);
                }
            }
            else
            {
                btnSave.Enabled = false;
                btnLottery.Enabled = false;

                this.toolTip1.ToolTipTitle = "경고";
                this.toolTip1.IsBalloon = true;
                var textbox = sender as TextBox;
                toolTip1.Show("텍스트창에 문자 또는 특수문자, 범위 이외의 숫자가 입력되었습니다. \r\n범위 이내의 숫자를 입력해 주십시오", textbox, textbox.Size.Width, textbox.Size.Height, 1000);
            }

        }
    }

}




public class Item
{
    public TextBox _number = new TextBox();
    public Button _btnhd = new Button();

    public Item(TextBox textbox, Button button)
    {
        this._number = textbox;
        this._btnhd = button;
    }
}