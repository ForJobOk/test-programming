﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddTextBoxButton
{
    public partial class Form1 : Form
    {
        int clickCount = 0;

        public Form1()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clickCount++;
            TextBox[] text = new TextBox[clickCount];
            Button[] button = new Button[clickCount];


            for (int i = 0; i < text.Length; i++) /*   i <= text.Length;にすると「インデックスが配列の境界外です」というエラー発生
                　　　　　　　　　　　　　　　　　    　要素数＋１のループになるせい*/
            {
                text[i] = new TextBox();/*これがないとtext[]nullとエラー発生
                　　　　　　　　　　　　　クリックした回数分インスタンスを生成？しないといけないらしい*/　

                text[i].Top = i * text[i].Height + 4;//テキストボックスとボタンのサイズがなかなか揃わず微調整
                text[i].Parent = this;

                button[i] = new Button();
                button[i].Top = i * button[i].Height;
                button[i].Location = new Point(100, (i * button[i].Height) - (i - 1) * 4);//テキストファイルとボタンのサイズがなかなか揃わず微調整
                button[i].Size = new Size(100, 20);
                button[i].Text = "実行完了";
                button[i].Parent = this;
            }
        }
    }
}
